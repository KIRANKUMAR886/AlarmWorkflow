﻿using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AlarmWorkflow.Shared.Core;
using AlarmWorkflow.Shared.Diagnostics;
using AlarmWorkflow.Shared.ObjectExpressions;

namespace AlarmWorkflow.Job.OperationPrinter
{
    /// <summary>
    /// Renders an <see cref="Operation"/>-object using a customizable HTML-page for layouting.
    /// </summary>
    static class TemplateRenderer
    {
        /// <summary>
        /// Renders the given operation using the provided template file and restricts the output to the given size.
        /// </summary>
        /// <param name="operation">The operation to render.</param>
        /// <param name="templateFile">The HTML template file to use for layouting.</param>
        /// <param name="size">The maximum size of the created image.</param>
        /// <returns></returns>
        internal static Image RenderOperation(Operation operation, string templateFile, Size size)
        {
            TemplateObject to = new TemplateObject();
            to.Operation = operation;
            to.RouteImageFilePath = RoutePlanHelper.GetRouteAsStoredFile(operation.Einsatzort);

            // Create HTML to render
            StringBuilder sb = new StringBuilder();
            foreach (string line in File.ReadAllLines(templateFile))
            {
                sb.AppendLine(ObjectFormatter.ToString(to, line));
            }

            Image image = RenderOperationWithBrowser(to, sb.ToString(), size);

            TryDeleteRouteImageFile(to);

            return image;
        }

        private static Image RenderOperationWithBrowser(TemplateObject to, string htmlToRender, Size size)
        {
            using (WebBrowser w = new WebBrowser())
            {
                w.AllowNavigation = true;
                w.ScrollBarsEnabled = false;
                w.ScriptErrorsSuppressed = true;

                w.DocumentText = htmlToRender;

                while (w.ReadyState != WebBrowserReadyState.Complete)
                {
                    // Pump the message queue for the web browser.
                    Application.DoEvents();
                }

                // Set the size of the WebBrowser control
                int suggestedWidth = w.Document.Body.ScrollRectangle.Width;
                int suggestedHeight = w.Document.Body.ScrollRectangle.Height;

                int realWidth = (suggestedWidth < size.Width) ? suggestedWidth : size.Width;
                int realHeight = (suggestedHeight < size.Height) ? suggestedHeight : size.Height;

                // If any of the Size-properties is set to zero, use the full size part.
                w.Width = (realWidth > 0) ? realWidth : suggestedWidth;
                w.Height = (realHeight > 0) ? realHeight : suggestedHeight;

                // Get a Bitmap representation of the webpage as it's rendered in the WebBrowser control
                using (Bitmap bitmap = new Bitmap(w.Width, w.Height))
                {
                    w.DrawToBitmap(bitmap, new Rectangle(0, 0, w.Width, w.Height));
                    return (Image)bitmap.Clone();
                }
            }
        }

        private static void TryDeleteRouteImageFile(TemplateObject to)
        {
            try
            {
                File.Delete(to.RouteImageFilePath);
            }
            catch (Exception ex)
            {
                Logger.Instance.LogException(typeof(TemplateRenderer), ex);
            }
        }
    }
}