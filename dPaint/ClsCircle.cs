using System;
using System.Drawing;
namespace dPaint
{
    public class ClsCircle : ClsRecangle
    {

        public ClsCircle(Point startPoint, Point endPoint, Pen p, SolidBrush b, Graphics g)
            : base(startPoint, endPoint, p, b, g)
        {
            rectangle.X = sPoint.X;
            rectangle.Y = sPoint.Y;
            rectangle.Width = Math.Abs(ePoint.X - sPoint.X);
            rectangle.Height = Math.Abs(ePoint.Y - sPoint.Y);
        }
        public override void Draw()
        {
            var sb = new SolidBrush(brush.Color);
            Canvas.FillEllipse(sb,rectangle );
            Canvas.DrawEllipse(PenShape, rectangle);
            if (Selected)       
                DrawHandle();
            
        }
    }
}
