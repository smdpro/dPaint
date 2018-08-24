using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace dPaint
{
    public class ClsTriangle : ClsLine
    {
        //protected SolidBrush brush;
        protected Rectangle rectangle;
        protected Rectangle rectangletmp;
        public ClsTriangle(Point startPoint, Point endPoint, Pen p, SolidBrush b, Graphics g)
            : base(startPoint, endPoint, p, g)
        {
            
           
            brush = b;
            rectangle = new Rectangle();
            rectangletmp = new Rectangle();
            rectangle.X = sPoint.X;
            rectangle.Y = sPoint.Y;
            rectangle.Width = Math.Abs(ePoint.X - sPoint.X);
            rectangle.Height = Math.Abs(sPoint.Y - ePoint.Y);

            //rectangletmp.Location=rectangle.Location;
            
        }
        
        public override int HandleCount
        {
            get
            {
                return 8;
            }
        }
        public override Cursor GetHandleCursor(int handleNumber)
        {
            switch (handleNumber)
            {
                case 1:
                    return Cursors.SizeNWSE;
                case 2:
                    return Cursors.SizeNS;
                case 3:
                    return Cursors.SizeNESW;
                case 4:
                    return Cursors.SizeWE;
                case 5:
                    return Cursors.SizeNWSE;
                case 6:
                    return Cursors.SizeNS;
                case 7:
                    return Cursors.SizeNESW;
                case 8:
                    return Cursors.SizeWE;
                case 9:
                    return Cursors.SizeAll;
                default:
                    return Cursors.Default;
            }
        }
        public override void Resize(Point point, int handleNumber)
        {
            rectangle = Normalized(rectangle);
            int left = rectangle.Left;
            int top = rectangle.Top;
            int right = rectangle.Right;
            int bottom = rectangle.Bottom;

            switch (handleNumber)
            {
                case 1:
                    left = point.X;
                    top = point.Y;
                    break;
                case 2:
                    top = point.Y;
                    break;
                case 3:
                    right = point.X;
                    top = point.Y;
                    break;
                case 4:
                    right = point.X;
                    break;
                case 5:
                    right = point.X;
                    bottom = point.Y;
                    break;
                case 6:
                    bottom = point.Y;
                    break;
                case 7:
                    left = point.X;
                    bottom = point.Y;
                    break;
                case 8:
                    left = point.X;
                    break;
            }

            rectangle.X = left;
            rectangle.Y = top;
            rectangle.Width = right - left;
            rectangle.Height = bottom - top;
        }
        public override Point GetHandle(int handleNumber)
        {
            int x, y;

            CenterPoint.X = rectangle.X + rectangle.Width / 2;
            CenterPoint.Y = rectangle.Y + rectangle.Height / 2;
            
            x = rectangle.X;
            y = rectangle.Y;

            switch (handleNumber)
            {
                case 1:
                    x = rectangle.X;
                    y = rectangle.Y;
                    break;
                case 2:
                    x = CenterPoint.X;
                    y = rectangle.Y;
                    break;
                case 3:
                    x = rectangle.Right;
                    y = rectangle.Y;
                    break;
                case 4:
                    x = rectangle.Right;
                    y = CenterPoint.Y;
                    break;
                case 5:
                    x = rectangle.Right;
                    y = rectangle.Bottom;
                    break;
                case 6:
                    x = CenterPoint.X;
                    y = rectangle.Bottom;
                    break;
                case 7:
                    x = rectangle.X;
                    y = rectangle.Bottom;
                    break;
                case 8:
                    x = rectangle.X;
                    y = CenterPoint.Y;
                    break;
            }

            return new Point(x, y);

        }
        
        public override void DrawHandle()
        {
            SolidBrush tbrush = new SolidBrush(Color.Black);

            for (int i = 1; i <= HandleCount; i++)
            {
                Canvas.FillRectangle(tbrush, GetHandleRectangle(i));
            }
            Canvas.DrawEllipse(Handle.PenHandle, rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height / 2, Handle.HandelSize, Handle.HandelSize);
            brush.Dispose();
        }
        
        public override void Draw()
        {
            
            Point[] arp = { GetHandle(1), GetHandle(5), GetHandle(7) };
            SolidBrush sb = new SolidBrush(brush.Color);
            Canvas.FillPolygon(sb,arp);
            Canvas.DrawPolygon(PenShape, arp);
            if (Selected)
                DrawHandle();
            
           
        }
        
        public override void Move(int deltaX, int deltaY)
        {
           
            sPoint = new Point(sPoint.X + deltaX, sPoint.Y + deltaY);
            rectangle.X = sPoint.X;
            rectangle.Y = sPoint.Y;
           
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
        public override bool PointInObject(Point p)
        {
            return rectangle.Contains(p);
        }
        #region Normalized Functions

        public virtual  Rectangle Normalized(int x1, int y1, int x2, int y2)
        {
            if (x2 < x1)
            {
                int tmp = x2;
                x2 = x1;
                x1 = tmp;
            }

            if (y2 < y1)
            {
                int tmp = y2;
                y2 = y1;
                y1 = tmp;
            }

            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

        public virtual  Rectangle GetNormalizedRectangle(Point p1, Point p2)
        {
            return Normalized(p1.X, p1.Y, p2.X, p2.Y);
        }

        public virtual  Rectangle Normalized(Rectangle r)
        {
            return Normalized(r.X, r.Y, r.X + r.Width, r.Y + r.Height);
        }

        #endregion
    }
}
