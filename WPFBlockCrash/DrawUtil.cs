using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPFBlockCrash
{
    static class DrawUtil
    {
        public static void DrawString(DrawingContext dc, int x, int y, string text, Color color)
        {
            DrawString(dc, x, y, text, color, 16);
        }

        public static void DrawString(DrawingContext dc, int x, int y, string text, Color color, int emSize)
        {
            dc.DrawText(
                new FormattedText(
                    text,
                    CultureInfo.CurrentUICulture,
                    FlowDirection.LeftToRight,
                    new Typeface(
                        new FontFamily("Consolas"),
                        FontStyles.Normal,
                        FontWeights.Normal,
                        FontStretches.Normal),
                    emSize,
                    new SolidColorBrush(color)),
                new Point(x, y));
        }

        public static void DrawBox(DrawingContext dc, int x1, int y1, int x2, int y2, Color? penColor)
        {
            DrawBox(dc, x1, y1, x2, y2, penColor, 3, null);
        }

        public static void DrawBox(DrawingContext dc, int x1, int y1, int x2, int y2, Color? penColor, int penThickness, Color? brushColor)
        {
            dc.DrawRectangle(
                brushColor.HasValue ? new SolidColorBrush(brushColor.Value) : null,
                penColor.HasValue ? new Pen(new SolidColorBrush(penColor.Value), penThickness) : null,
                new Rect(new Point(x1, y1), new Point(x2, y2)));
        }

        public static void DrawGraph(DrawingContext dc, int x, int y, ImageSource imageSource)
        {
            DrawGraph(dc, x, y, (int)imageSource.Width, (int)imageSource.Height, imageSource);
        }

        public static void DrawGraph(DrawingContext dc, int x, int y, int width, int height, ImageSource imageSource)
        {
            dc.DrawImage(imageSource, new Rect(x, y, width, height));
        }

        public static void DrawExtendGraph(DrawingContext dc, int x1, int y1, int x2, int y2, ImageSource imageSource)
        {
            dc.DrawImage(imageSource, new Rect(new Point(x1, y1), new Point(x2, y2)));
        }
    }
}
