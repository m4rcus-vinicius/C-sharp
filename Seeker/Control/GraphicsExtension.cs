using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Seeker.Draw;

namespace Seeker
{
    public static class GraphicsExtension
    {
        private static float Height;
        private static float XScroll;
        private static float YScroll;
        private static float ScaleFactor;

        public static void SetParameters(this System.Drawing.Graphics g, float xscroll, float yscroll, float scalefactor, float height)
        {
            XScroll = xscroll;
            YScroll = yscroll;
            ScaleFactor = scalefactor;
            Height = height;
        }

        public static void SetTransform(this System.Drawing.Graphics g)
        {
            g.PageUnit = System.Drawing.GraphicsUnit.Millimeter;
            g.TranslateTransform(0, Height);
            g.ScaleTransform(ScaleFactor, -ScaleFactor);
            g.TranslateTransform(-XScroll / ScaleFactor, YScroll/ScaleFactor);
        }

        public static void DrawPoint(this System.Drawing.Graphics g, System.Drawing.Pen pen, Draw.Point point)
        {
            g.SetTransform();
            System.Drawing.PointF p = point.Position.ToPointf;
            g.DrawEllipse(pen, p.X - 1, p.Y - 1, 2, 2);
            g.ResetTransform();
        }

        public static void DrawLine(this Graphics g, Pen pen, Line line)
        {
            g.SetTransform();
            g.DrawLine(pen, line.StartPoint.ToPointf, line.EndPoint.ToPointf);
            g.ResetTransform();
        }

        public static void DrawCircle(this Graphics g, Pen pen, Circle circle)
        {
            float x = (float)(circle.Center.X - circle.Radius);
            float y = (float)(circle.Center.Y - circle.Radius);
            float d = (float)circle.Diameter;

            g.SetTransform();
            g.DrawEllipse(pen, x, y, d, d);
            g.ResetTransform();

        }

        public static void DrawEllipse(this Graphics g, Pen pen, Ellipse ellipse)
        {
            SetTransform(g);
            g.TranslateTransform(ellipse.Center.ToPointf.X, ellipse.Center.ToPointf.Y);
            g.RotateTransform((float)ellipse.Rotation);
            g.DrawEllipse(pen, -(float)ellipse.MajorAxis, -(float)ellipse.MinorAxis, (float)ellipse.MajorAxis * 2, (float)ellipse.MinorAxis * 2);
            g.ResetTransform();
        }

        public static void DrawArc(this Graphics g, Pen pen, Arc arc)
        {
            float x = (float)(arc.Center.X - arc.Radius);
            float y = (float)(arc.Center.Y - arc.Radius);
            float d = (float)arc.Diameter;

            System.Drawing.RectangleF rect = new System.Drawing.RectangleF(x, y, d, d);

            g.SetTransform();
            g.DrawArc(pen, rect, (float)arc.StartAngle, (float)arc.EndAngle);
            g.ResetTransform();
        }
    
        public static void DrawLwPolyline(this Graphics g, Pen pen, LwPolyline polyline)
        {
            PointF[] vertexes = new PointF[polyline.Vertexes.Count];

            if (polyline.IsClosed)
            {
                vertexes = new PointF[polyline.Vertexes.Count + 1];
                vertexes[polyline.Vertexes.Count] = polyline.Vertexes[0].Position.ToPointF;
            }

            for (int i = 0; i < polyline.Vertexes.Count; i++)
                vertexes[i] = polyline.Vertexes[i].Position.ToPointF;

            g.SetTransform();
            g.DrawLines(pen, vertexes);
            g.ResetTransform();
        }
    }
}
