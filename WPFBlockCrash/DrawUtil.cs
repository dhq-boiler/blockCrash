using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFBlockCrash
{
    static class DrawUtil
    {
        public static Image SetOpacity(this Image image, float opacity)
        {
            var colorMatrix = new ColorMatrix();
            colorMatrix.Matrix33 = opacity;
            var imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            var output = new Bitmap(image.Width, image.Height);
            using (var gfx = Graphics.FromImage(output))
            {
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.DrawImage(
                    image,
                    new Rectangle(0, 0, image.Width, image.Height),
                    0,
                    0,
                    image.Width,
                    image.Height,
                    GraphicsUnit.Pixel,
                    imageAttributes);
            }
            return output;
        }

        public static Color RGB(byte a, byte r, byte g, byte b)
        {
            return Color.FromArgb(a, r, g, b);
        }

        public static Color RGB(byte r, byte g, byte b)
        {
            return Color.FromArgb(r, g, b);
        }

        public static Brush BrushRGB(int alpha, byte r, byte g, byte b)
        {
            return new SolidBrush(Color.FromArgb(alpha, r, g, b));
        }

        public static Brush BrushRGB(byte r, byte g, byte b)
        {
            return new SolidBrush(Color.FromArgb(r, g, b));
        }

        [Conditional("DEBUG")]
        public static void Debug_DrawBlockRectangle(Graphics g, int x, int y, int width, int height)
        {
            g.DrawRectangle(new Pen(Brushes.Red, 1), new Rectangle(x, y, width, height));
        }
    }
}
