using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seeker.Draw;
using Seeker.Control;


namespace Seeker
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
        }
        #region Variables
        //Lists
        private List<Draw.Point> points = new List<Draw.Point>();
        private List<Draw.Line> lines = new List<Draw.Line>();
        private List<Draw.Circle> circles = new List<Draw.Circle>();
        private List<Draw.Ellipse> ellipses = new List<Draw.Ellipse>();
        private List<Draw.Arc> arcs = new List<Draw.Arc>();
        private List<LwPolyline> polylines = new List<LwPolyline>();
        private LwPolyline tempPolyline = new LwPolyline();

        //Vector
        private Vector3 currentPosition;
        private Vector3 firstPoint;
        private Vector3 secondPoint;

        //Ints
        private int DrawIndex = -1;
        private int ClickNum = 1;
        private int direction;
        private int sidesQty = 5;
        private int inscribed = 0;
        //Float
        private float XScroll;
        private float YScroll;
        private float ScaleFactor = 1.0f;

        //Bool
        private bool active_drawing = false;
        #endregion

        #region "PictureBox events"

        #region Mouse Down
        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (active_drawing)
                {
                    switch (DrawIndex)
                    {
                        case 11: //Arc (3-Points)
                        case 12: //Arc (Start, Center, End)
                        case 13: //Arc (Center, Start, End)
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 2:
                                    secondPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 3:
                                    Arc a = new Arc();
                                    switch (DrawIndex)
                                    {
                                        case 11: // 3=Points
                                            a = Method.GetArcWith3Points(firstPoint, secondPoint, currentPosition);
                                            break;
                                        case 12://Start, Center, End
                                            a = Method.GetArcWithCenterStartEnd(secondPoint, firstPoint, currentPosition);
                                            break;
                                        case 13:// Center, Start, End
                                            a = Method.GetArcWithCenterStartEnd(firstPoint, secondPoint, currentPosition);
                                            break;
                                    }
                                    arcs.Add(a);
                                    CancelAll();
                                    break;
                            }
                            break;
                        case 21: // Circle
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 2:
                                    double r = firstPoint.DistanceFrom(currentPosition);
                                    circles.Add(new Draw.Circle(firstPoint, r));
                                    ClickNum = 1;
                                    break;
                            }
                            break;
                        case 22: // Circle with 3 point
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 2:
                                    secondPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 3:
                                    Draw.Circle c = Control.Method.GetCirclewWith3Point(firstPoint, secondPoint, currentPosition);
                                    circles.Add(c);
                                    CancelAll();
                                    break;
                            }
                            break;
                        case 31: // Ellipse
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 2:
                                    secondPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 3:
                                    Draw.Ellipse ellipse = Control.Method.GetEllipse(firstPoint, secondPoint, currentPosition);
                                    ellipses.Add(ellipse);
                                    ClickNum = 1;
                                    active_drawing = true;
                                    drawing.Cursor = Cursors.Default;
                                    break;
                            }
                            break;
                        case 3: // line
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    points.Add(new Draw.Point(currentPosition));
                                    ClickNum++;
                                    break;
                                case 2:
                                    lines.Add(new Draw.Line(firstPoint, currentPosition));
                                    points.Add(new Draw.Point(currentPosition));
                                    firstPoint = currentPosition;
                                    break;
                            }
                            break;
                        case 4: // LwPolyline
                            firstPoint = currentPosition;
                            tempPolyline.Vertexes.Add(new LwPolylineVertex(firstPoint.ToVector2));
                            ClickNum = 2;
                            break;
                        case 5: // Polygon
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    ClickNum++;
                                    using (var setpolygon = new SetPolygonValuesForm())
                                    {
                                        var result = setpolygon.ShowDialog();
                                        if (result == DialogResult.OK)
                                        {
                                            sidesQty = setpolygon.SidesQty;
                                            inscribed = setpolygon.Inscribed;
                                        }
                                        else
                                            CancelAll();
                                    }
                                    break;
                                case 2:
                                    polylines.Add(Method.GetPolygon(firstPoint, currentPosition, sidesQty, inscribed));
                                    CancelAll();
                                    break;
                            }
                            break;
                        case 6: // point
                            points.Add(new Draw.Point(currentPosition));
                            break;
                        case 7: //Rectangle
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 2:
                                    polylines.Add(Method.PointToRect(firstPoint, currentPosition, out direction));
                                    CancelAll();
                                    break;
                            }
                            break;
                    }
                    drawing.Refresh();
                }
            }
        }
        #endregion

        #region Paint
        Line extline = new Line();

        private void drawing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetParameters(XScroll, YScroll, ScaleFactor, Pixel_to_Mm(drawing.Height));
            Pen pen = new Pen(Color.Blue, 0.1f);
            Pen extpen = new Pen(Color.Gray, 0.1f);
            extpen.DashPattern = new float[] { 1.0f, 2.0f };

            // Draw all points
            if (points.Count > 0)
            {
                foreach (Draw.Point p in points)
                {
                    e.Graphics.DrawPoint(new Pen(Color.Red, 0.1f), p);
                }
            }
            // Draw all lines
            if (lines.Count > 0)
            {
                foreach (Draw.Line l in lines)
                {
                    e.Graphics.DrawLine(pen, l);
                }
            }
            // Draw all circle
            if (circles.Count > 0)
            {
                foreach(Draw.Circle c in circles)
                {
                    e.Graphics.DrawCircle(pen, c);
                }
            }
            // Draw all ellipses
            if (ellipses.Count > 0)
            {
                foreach(Draw.Ellipse elp in ellipses)
                {
                    e.Graphics.DrawEllipse(pen, elp);
                }
            }
            // Draw all arcs
            if (arcs.Count > 0)
            {
                foreach(Arc a in arcs)
                {
                    e.Graphics.DrawArc(pen, a);
                }
            }
            // Draw all LwPolylines
            if (polylines.Count > 0)
            {
                foreach(LwPolyline lw in polylines)
                {
                    e.Graphics.DrawLwPolyline(pen, lw);
                }
            }
            // DrawtempPolyline
            if (tempPolyline.Vertexes.Count > 1)
            {
                e.Graphics.DrawLwPolyline(pen, tempPolyline);
            }
            // Draw line extended

            switch (DrawIndex)
            {
                case 3: //Line
                case 4: //LwPolyline
                    if(ClickNum == 2)
                    {
                        extline = new Draw.Line(firstPoint, currentPosition);
                        e.Graphics.DrawLine(extpen, extline);
                    }
                    break;
                case 5: //Polygon
                    if(ClickNum == 2)
                    {
                        extline = new Draw.Line(firstPoint, currentPosition);
                        e.Graphics.DrawLine(extpen, extline);
                        LwPolyline lw = Method.GetPolygon(firstPoint, currentPosition,sidesQty,inscribed);
                        e.Graphics.DrawLwPolyline(extpen, lw);
                    }
                    break;
                case 7: // Rectangle
                    if(ClickNum == 2)
                    {
                        LwPolyline lw = Method.PointToRect(firstPoint, currentPosition, out direction);
                        e.Graphics.DrawLwPolyline(extpen, lw);
                    }
                    break;
                case 11: // 3-Points
                case 12: // Start, Center, End
                case 13: // Center, Start, End
                    extline = new Draw.Line(firstPoint, currentPosition);

                    switch (ClickNum)
                    {
                        case 2:
                            e.Graphics.DrawLine(extpen, extline);
                            break;
                        case 3:
                            Arc a = new Arc();
                            switch (DrawIndex)
                            {
                                case 11:
                                    a = Method.GetArcWith3Points(firstPoint, secondPoint, currentPosition);
                                    break;
                                case 12:
                                    extline = new Line(secondPoint, currentPosition);
                                    e.Graphics.DrawLine(extpen, extline);
                                    a = Method.GetArcWithCenterStartEnd(secondPoint, firstPoint, currentPosition);
                                    break;
                                case 13:
                                    e.Graphics.DrawLine(extpen, extline);
                                    a = Method.GetArcWithCenterStartEnd(firstPoint, secondPoint, currentPosition);
                                    break;
                            }
                            e.Graphics.DrawArc(extpen, a);
                            break;
                    }
                    break;

                case 21:
                    switch (ClickNum)
                    {
                        case 2:
                            extline = new Draw.Line(firstPoint, currentPosition);
                            e.Graphics.DrawLine(extpen, extline);
                            double r = firstPoint.DistanceFrom(currentPosition);
                            Draw.Circle circle = new Draw.Circle(firstPoint, r);
                            e.Graphics.DrawCircle(extpen, circle);
                        break;
                    }
                    break;
                case 22:
                   
                    switch (ClickNum)
                    {
                        case 2:
                            extline = new Draw.Line(firstPoint, currentPosition); 
                            e.Graphics.DrawLine(extpen, extline);
                            break;
                        case 3:
                            Draw.Circle c = Control.Method.GetCirclewWith3Point(firstPoint, secondPoint, currentPosition);
                            e.Graphics.DrawCircle(extpen, c);
                            break;
                    }
                    break;
                case 31:
                    extline = new Draw.Line(firstPoint, currentPosition);
                    switch (ClickNum)
                    {
                        case 2:
                            e.Graphics.DrawLine(extpen, extline);
                            break;
                        case 3:
                            e.Graphics.DrawLine(extpen, extline);
                            Draw.Ellipse elp = Control.Method.GetEllipse(firstPoint, secondPoint, currentPosition);
                            e.Graphics.DrawEllipse(extpen, elp);
                            break;

                    }
                    break;
            
            }

            // Test line line intersection
            if (lines.Count > 0)
            {
                foreach(Draw.Line l1 in lines)
                {
                    foreach(Draw.Line l2 in lines)
                    {
                        Vector3 v = Control.Method.LineLineIntersection(l1, l2, true);
                        Draw.Point p = new Draw.Point(v);
                        e.Graphics.DrawPoint(new Pen(Color.Red, 0), p);
                    }
                }
            }
        }

        #endregion

        #region Mouse move
        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            coordinate.Text = string.Format("{0,0:F2}, {1,0:F2}", currentPosition.X, currentPosition.Y);
            drawing.Refresh();

        }
        #endregion

        #endregion

        #region "Custom function"

        #region Convert pixels to milimeters
        // Convert pixels to milimeters
        private float Pixel_to_Mm(float pixel)
        {
            return pixel * 25.4f / DPI;
        }
        #endregion

        #region Convert system point to world point
        // Convert system point to world point 
        private Vector3 PointToCartesian(System.Drawing.Point point)
        {
            return new Vector3(Pixel_to_Mm(point.X + XScroll) / ScaleFactor, (Pixel_to_Mm(drawing.Height - point.Y) - YScroll) / ScaleFactor);
        }
        #endregion

        #region Cancell All command
        private void CancelAll(int index = 1)
        {
            DrawIndex = -1;
            active_drawing = false;
            drawing.Cursor = Cursors.Default;
            ClickNum = 1;
            LwPolylineCloseStatus(index);
        }
        #endregion

        #region Cancel Button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CancelAll();
        }
        #endregion

        #region CloseBoundary
        private void closeBoundary_Click(object sender, EventArgs e)
        {
            switch (DrawIndex)
            {
                case 3: //Line
                    break;
                case 4: // LwPolyline
                    CancelAll(2);
                    break;
            }
        }
        #endregion

        #region Get Dpi
        // Get screen dpi
        private float DPI
        {
            get
            {
                using (var g = CreateGraphics())
                    return g.DpiX;
            }
        }
        #endregion

        #endregion

        #region Graphics form components event
        #region Draw buttons
        private void DrawBtn_Click(object sender, EventArgs e)
        {
            var item = sender as RibbonButton;
            DrawIndex = drawPanel.Items.IndexOf(item);
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }
        #endregion

        #region Circle Button
        private void CircleBtn_Click(object sender,EventArgs e)
        {
            var item = sender as RibbonButton;
            DrawIndex = circleBtn.DropDownItems.IndexOf(item) + 21;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }
        #endregion

        #region Arc Button
        private void ArcBtn_Click(object sender, EventArgs e)
        {
            var item = sender as RibbonButton;
            DrawIndex = arcBtn.DropDownItems.IndexOf(item) + 11;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }
        #endregion

        #region Ellipse Button
        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            var item = sender as RibbonButton;
            DrawIndex = ellipseBtn.DropDownItems.IndexOf(item) + 31;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }
        #endregion

        #region Horizontal Scroll
        private void hS_Scroll(object sender, ScrollEventArgs e)
        {
            XScroll = (sender as HScrollBar).Value;
            drawing.Refresh();
        }
        #endregion

        #region Vertical Scroll
        private void vS_Scroll(object sender, ScrollEventArgs e)
        {
            YScroll = (sender as VScrollBar).Value;
            drawing.Refresh();
        }
        #endregion

        #endregion

        
        private void LwPolylineCloseStatus(int index)
        {
            List<LwPolylineVertex> vertexes = new List<LwPolylineVertex>();
            foreach (LwPolylineVertex lw in tempPolyline.Vertexes)
                vertexes.Add(lw);
            if (vertexes.Count > 1)
            {
                switch (index)
                {
                    case 1:
                        polylines.Add(new LwPolyline(vertexes, false));
                        break;
                    case 2:
                        if (vertexes.Count > 2)
                            polylines.Add(new LwPolyline(vertexes, true));
                        else
                            polylines.Add(new LwPolyline(vertexes, false));
                        break;

                }
            }
            tempPolyline.Vertexes.Clear();
        }

    }
}
