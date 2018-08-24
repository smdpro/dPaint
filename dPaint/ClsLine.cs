using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace dPaint
{
    public class ClsLine : ClsDot
    {
        protected Point ePoint;
        public Matrix matrix;
        public Point CenterPoint;
        
        public virtual int HandleCount
        {
            get
            {
                return 2;
            }
        }
        public override void Resize(Point point, int handleNumber)
        {
            if (handleNumber == 1)
                sPoint = point;
            else
                ePoint = point;
            
        }
        public override void Move(int deltaX, int deltaY)
        {
            sPoint.X += deltaX;
            sPoint.Y += deltaY;

            ePoint.X += deltaX;
            ePoint.Y += deltaY;

            
        }
        public virtual Point GetHandle(int handleNumber)
        {
           
            if (handleNumber == 1)
                return sPoint;
           
            return ePoint;
        }
        
        
        public override Cursor GetHandleCursor(int handleNumber)
        {
            switch (handleNumber)
            {
                case 1:
                case 2:
                    return Cursors.SizeAll;
                default:
                    return Cursors.Default;
            }
        }
        public ClsLine(Point p1,Point p2,Pen p,Graphics g):base(p1,p,g)
        {
            ePoint = p2;
            matrix = new Matrix();
            
        }
        public override void Draw()
        {
            Canvas.DrawLine(PenShape, sPoint, ePoint);

           
            DrawHandle();
        }
        
        public  void Rotate(float angle)//, Point center)
        {
            matrix.RotateAt(angle,CenterPoint);// center);
            base.Canvas.Transform = matrix;
            
            
        }
        public virtual void DrawHandle()
        {
            SolidBrush tbrush = new SolidBrush(Color.Black);

            for (int i = 1; i <= HandleCount; i++)
            {
                Canvas.FillRectangle(tbrush, GetHandleRectangle(i));
            }
            CenterPoint.X = (sPoint.X + ePoint.X) / 2;
            CenterPoint.Y = (sPoint.Y + ePoint.Y) / 2;
            Canvas.DrawEllipse(Handle.PenHandle, CenterPoint.X, CenterPoint.Y, Handle.HandelSize, Handle.HandelSize);
            tbrush.Dispose();
            
        }
        public override bool PointInObject(Point p)
        {
            bool ret = false;
            float m = 0;
            if (ePoint.X - sPoint.X>0)
                m = (ePoint.Y - sPoint.Y) / (ePoint.X - sPoint.X);
            float b=sPoint.Y-(m*sPoint.X);
            if ((float)p.Y == ((m * p.X) + b)) ret = true;
            return ret;
        }
        public override int CheckHandlePoint(Point point)
        {
            if (Selected)
            {
                for (int i = 1; i <= HandleCount; i++)
                {
                    if (GetHandleRectangle(i).Contains(point))
                        return i;
                }
            }
            if (PointInObject(point))
                return 0;

            return -1;
        }
        public virtual Rectangle GetHandleRectangle(int handleNumber)
        {
            Point point = GetHandle(handleNumber);

            return new Rectangle(point.X - 3, point.Y - 3, 6, 6);
            //Rectangle r;//
            //int x = 0, y = 0, w, h;
            //Point point = GetHandle(handleNumber);
            //switch (handleNumber)
            //{
            //    case 1:
            //        //r= new Rectangle(point.X,point.Y,8,8);
            //        x = point.X;
            //        y = point.Y;
            //        break;
            //    case 2:
            //        //r = new Rectangle(point.X-4, point.Y, 8, 8);
            //        x = point.X - 4;
            //        y = point.Y;
            //        break;
            //    case 3:
            //        //r = new Rectangle(point.X-8, point.Y, 8, 8);
            //        x = point.X - 8;
            //        y = point.Y;
            //        break;
            //    case 4:
            //        x = point.X - 8;
            //        y = point.Y - 4;
            //        //r = new Rectangle(point.X-8, point.Y-4, 8, 8);
            //        break;
            //    case 5:
            //        x = point.X - 8;
            //        y = point.Y - 8;
            //        //r = new Rectangle(point.X-8, point.Y-8, 8, 8);
            //        break;
            //    case 6:
            //        x = point.X - 4;
            //        y = point.Y - 8;
            //        //r = new Rectangle(point.X-4, point.Y-8, 8, 8);
            //        break;
            //    case 7:
            //        x = point.X;
            //        y = point.Y - 8;
            //        //r = new Rectangle(point.X, point.Y-8, 8, 8);
            //        break;
            //    case 8:
            //        x = point.X;
            //        y = point.Y - 4;
            //        //r = new Rectangle(point.X, point.Y-4, 8, 8);
            //        break;
            //}
            ////return new Rectangle(point.X - 4, point.Y - 4, 8, 8);
            //return new Rectangle(x, y, 8, 8);

        }

    }
}
