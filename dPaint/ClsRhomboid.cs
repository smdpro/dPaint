using System;
using System.Drawing;

namespace dPaint
{
    public class ClsRhomboid : ClsRecangle
    {
        public ClsRhomboid(Point startPoint,Point Endpoint,Pen pen,SolidBrush brush,Graphics g)
            :base(startPoint,Endpoint,pen,brush,g)
        {
            rectangle.X = sPoint.X;
            rectangle.Y = sPoint.Y;
            rectangle.Width = Math.Abs(ePoint.X - sPoint.X);
            rectangle.Height = Math.Abs(ePoint.Y - sPoint.Y);

        }
        public override void Draw()
        {

            var sb = new SolidBrush(brush.Color);
            Point[] arp = { GetHandle(2), GetHandle(4), GetHandle(6), GetHandle(8) };
            Canvas.FillPolygon(sb, arp);
            Canvas.DrawPolygon(PenShape, arp);
            if(Selected)
            DrawHandle();
           
        }
    }
}
