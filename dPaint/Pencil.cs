using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace dPaint
{
    public class Pencil : Dot
    {
        private Point[] points;
        int count;
        public Pencil(Point point, Pen pen, Graphics canvas)
            : base(point, pen, canvas)
        {
            count = 0;
            points = new Point[1000];
        }
        public override void Draw()
        {
            if (count > 0)
            {
                Point temp = sPoint;
                for (int i = 0; i < count; i++)
                {
                    Canvas.DrawLine(PenShape, temp.X, temp.Y, points[i].X, points[i].Y);
                    temp = points[i];
                }

            }
            //g.DrawEllipse(p, start.X, start.Y, 1, 1);
            //Canvas.DrawLine(PenShape, sPoint, new Point(sPoint.X + 2, sPoint.Y + 2));
        }
        public virtual void ChangePen(Pen pen)
        {
            PenShape = pen;
        }
        public void Add(Point p)
        {
            points[count++] = p;
            Draw();
        }
    }
}
