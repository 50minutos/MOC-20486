using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace _001_Handler.Handlers
{
    /// <summary>
    /// Summary description for PNGHandler
    /// </summary>
    public class PNGHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            using (Bitmap bmp = new Bitmap(200, 50))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Yellow);
                    g.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), new Font("Arial", 14, FontStyle.Regular), SystemBrushes.WindowText, new PointF(10, 10));
                }

                context.Response.ContentType = "image/png";
                bmp.Save(context.Response.OutputStream, ImageFormat.Png);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}