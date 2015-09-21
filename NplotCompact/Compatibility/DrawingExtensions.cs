using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NPlot
{
    public static class DrawingExtensions
    {
        static public Brush GetBrush(this Pen pen)
        {
            return new SolidBrush(pen.Color);
        }

        static public void DrawLine(this Graphics g, Pen pen, Point p1, Point p2)
        {
            g.DrawLine(pen, p1.X, p1.Y, p2.X, p2.Y);
        }

        static public void DrawLine(this Graphics g, Pen pen, PointF p1, PointF p2)
        {
            g.DrawLine(pen, (int)p1.X, (int)p1.Y, (int)p2.X, (int)p2.Y);
        }

        static public void DrawLine(this Graphics g, Pen pen, float x1, float y1, float x2, float y2)
        {
            g.DrawLine(pen, (int)x1, (int)y1, (int)x2, (int)y2);
        }

        static public void FillRectangle(this Graphics g, Brush brush, float x, float y, float width, float height)
        {
            g.FillRectangle(brush, (int)x, (int)y, (int)width, (int)height);
        }

        static public void DrawRectangle(this Graphics g, Pen pen, float x, float y, float width, float height)
        {
            g.DrawRectangle(pen, (int)x, (int)y, (int)width, (int)height);
        }

        static public void FillPolygon(this Graphics g, Brush brush, PointF[] pointsf)
        {
            Point[] points = new Point[pointsf.Length];
            for (int i = 0; i < pointsf.Length; i++)
            {
                points[i].X = (int)pointsf[i].X;
                points[i].Y = (int)pointsf[i].Y;
            }
            g.FillPolygon(brush, points);
        }

        static public void DrawPolygon(this Graphics g, Pen pen, PointF[] pointsf)
        {
            Point[] points = new Point[pointsf.Length];
            for (int i = 0; i < pointsf.Length; i++)
            {
                points[i].X = (int)pointsf[i].X;
                points[i].Y = (int)pointsf[i].Y;
            }
            g.DrawPolygon(pen, points);
        }

        static public Brush Clone(this Brush brush)
        {
            //return new SolidBrush(((SolidBrush)brush).Color);
            return brush;
        }

        static public int GetHeight(this Font font)
        {
            return (int)(font.Size * 72 / 96);
        }
    }
}
