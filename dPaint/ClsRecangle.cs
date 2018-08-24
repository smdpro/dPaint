using System;
using System.Drawing;

namespace dPaint
{
    public class ClsRecangle : ClsTriangle
    {
        
        public ClsRecangle(Point sPoint, Point ePoint, Pen p, SolidBrush b, Graphics g)
            : base(sPoint, ePoint, p, b, g)
        {
            rectangle.X = sPoint.X;
            rectangle.Y = sPoint.Y;
            rectangle.Width = Math.Abs(ePoint.X - sPoint.X);
            rectangle.Height = Math.Abs(ePoint.Y - sPoint.Y);
        }
        public override void Draw()
        {
            var sb = new SolidBrush(brush.Color);
            var rectFToFill =
               new RectangleF(rectangle.Location, rectangle.Size);
            Canvas.FillRectangles(sb, new[] { rectFToFill });
            Canvas.DrawRectangle(PenShape, rectangle);
            if (Selected)
                DrawHandle();
            

        }
        
        public override bool PointInObject(Point p)
        {
            return rectangle.Contains(p);
        }
        
    }
}
