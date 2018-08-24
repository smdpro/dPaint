using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace dPaint
{
    public class ClsDot : ClsShape
    {
        /// <summary>
        /// Point for draw
        /// </summary>
        protected Point sPoint;
        public ClsDot(Point point,Pen pen,Graphics canvas ):base(pen,canvas)
        {
            sPoint = point;
        }
        public override void Draw()
        {

            Canvas.DrawLine(PenShape, sPoint, new Point(sPoint.X + 2, sPoint.Y + 2));
        }
        public virtual void ChangePen(Pen pen)
        {
            PenShape = pen;
        }
        public virtual void Move(Point p)
        {
            sPoint = p;
        }
        public virtual bool PointInObject(Point p)
        {

            return false;
        }
    }
}
