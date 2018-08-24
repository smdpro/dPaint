using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace dPaint
{
    public class Shape
    {
        /// <summary>
        /// shape color
        /// </summary>
        public Pen PenShape;
        public SolidBrush brush;
        //protected SolidBrush brush;
        /// <summary>
        /// Drawing on object
        /// </summary>
        protected Graphics Canvas;
        public bool Selected;
        public virtual int HandleCount
        {
            get
            {
                return 0;
            }
        }
        public Shape(Pen p,Graphics g)
        {
            PenShape = p;
            Canvas = g;
            Canvas.SmoothingMode = SmoothingMode.AntiAlias;
            Handle.HandelSize = 3;
            Handle.PenHandle = new Pen(Color.Black, Handle.HandelSize);
        }

        /// <summary>
        /// Draw Shape
        /// </summary>
        public virtual void Draw()
        {
            
        }
        
        public virtual void Move(int deltaX, int deltaY)
        {
            
        }

        public virtual void Resize(Point point, int handleNumber)
        {
        }
        
        
       
        public virtual int CheckHandlePoint(Point point)
        {
            return -1;
        }
        public virtual Cursor GetHandleCursor(int handleNumber)
        {
            
                    return Cursors.Default;
            
        }
        
    }
    class  Handle
    {
        public static Pen PenHandle;
        public static int HandelSize;
    }
}
