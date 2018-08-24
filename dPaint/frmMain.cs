using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dPaint
{
    public enum Choice { Line,Rectangle,Squre,Circle,Ellips,FillEllips,FillCircle,FillSqure,FillRectangle,Triangle,Rhom,FillRoham, Pen,Brush, None }
    public enum SelectionMode
    {
        None,
        Move,           
        Size            
    }
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int handelNum = 0;
        Graphics g;
        private Choice select = Choice.None;
        List<ClsShape> obj = new List<ClsShape>();
        Point oldLocation;
        ClsShape selectShape ;
        Pen pen;
        SolidBrush brush;
        ClsPencil tempPen;
        bool CTRLpresed ;
        private SelectionMode selectMode = SelectionMode.None;
        private void frmMain_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            pen = new Pen(btnCurrentColor.BackColor,(float) upPenSize.Value);
            brush =new SolidBrush( Color.Transparent);
            
        }
        #region Btn_Click
                
        private void btnLine_Click(object sender, EventArgs e)
        {
            select = Choice.Line;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            select = Choice.Rectangle;
        }

        private void btnSqure_Click(object sender, EventArgs e)
        {
            select = Choice.Squre;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            select = Choice.Circle;
        }

        private void btnEllips_Click(object sender, EventArgs e)
        {
            select = Choice.Ellips;
        }

        private void btnFillRectangle_Click(object sender, EventArgs e)
        {
            select = Choice.FillRectangle;
        }

        private void btnFillSqure_Click(object sender, EventArgs e)
        {
            select = Choice.FillSqure;
        }

        private void btnFillCircle_Click(object sender, EventArgs e)
        {
            select = Choice.FillCircle;
        }

        private void btnFillEllips_Click(object sender, EventArgs e)
        {
            select = Choice.FillEllips;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            select = Choice.Triangle;
        }

        private void btnRhom_Click(object sender, EventArgs e)
        {
            select = Choice.Rhom;
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            select = Choice.Pen;
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            select = Choice.Brush;
        }
        #endregion

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            oldLocation = e.Location;
            selectMode = SelectionMode.None;

            foreach (var item in obj)
            {
                int handleNumber = item.CheckHandlePoint(e.Location);
                if (handleNumber > 0)
                {
                    selectMode = SelectionMode.Size;
                    selectShape = item;
                    item.Selected = true;
                    break;
                }
            }

            if (selectMode == SelectionMode.None)
            {
                foreach (var item in obj)
                {
                    if (item.CheckHandlePoint(e.Location) == 0)
                    {
                        item.Selected = true;
                        selectMode = SelectionMode.Move;
                        Cursor = Cursors.SizeAll;
                    }
                    if (!CTRLpresed)
                    {
                        if (item.CheckHandlePoint(e.Location) < 0)
                            item.Selected = false;
                    }
                }
                
               
            }    
            //picBox.Refresh();
            Refresh();
            if (select == Choice.Pen)
            {
                ClsPencil p = new ClsPencil(e.Location, pen, g);
                p.Draw();
                obj.Add(p);
                tempPen = p;
            }
            if (select == Choice.Rectangle || select == Choice.Squre )//|| select==Choice.Rhom)
            {
                
                ClsRecangle s = new ClsRecangle( e.Location,new Point(e.X+ 5,e.Y+ 5), pen, brush, g);
                s.Draw();
                s.DrawHandle();
                s.Selected = true;
                obj.Add(s);
                selectShape = s;
                selectMode = SelectionMode.Size;
                handelNum = 5;
            }
            if (select == Choice.Circle)
            {

                ClsCircle s = new ClsCircle(e.Location, new Point(e.X + 5, e.Y + 5), pen, brush, g);
                s.Draw();
                s.DrawHandle();
                s.Selected = true;
                obj.Add(s);
                selectShape = s;
                selectMode = SelectionMode.Size;
                handelNum = 5;
            }
            if (select == Choice.Triangle)
            {

                ClsTriangle s = new ClsTriangle(e.Location, new Point(e.X + 5, e.Y + 5), pen, brush, g);
                s.Draw();
                s.DrawHandle();
                s.Selected = true;
                obj.Add(s);
                selectShape = s;
                selectMode = SelectionMode.Size;
                handelNum = 5;
            }
            if (select == Choice.Rhom)
            {

                ClsRhomboid s = new ClsRhomboid(e.Location, new Point(e.X + 5, e.Y + 5), pen, brush, g);
                s.Draw();
                s.DrawHandle();
                s.Selected = true;
                obj.Add(s);
                selectShape = s;
                selectShape.Selected = true;
                selectMode = SelectionMode.Size;
                handelNum = 5;
            }
            if (select == Choice.Line)
            {

                ClsLine s = new ClsLine(e.Location, new Point(e.X + 5, e.Y + 5), pen, g);
                s.Draw();
                s.DrawHandle();
                s.Selected = true;
                obj.Add(s);
                selectShape = s;
                selectShape.Selected = true;
                selectMode = SelectionMode.Size;
                handelNum = 5;
            }
            Refresh();
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (tempPen != null)
            {
                tempPen.Add(e.Location);
            }
            
            if (selectShape != null)
            {
                int m = selectShape.CheckHandlePoint(e.Location);
                if (m > 0)
                {
                    Cursor = selectShape.GetHandleCursor(m);
                    handelNum = selectShape.CheckHandlePoint(e.Location);
                }
                if (m == 0)
                {
                    Cursor = Cursor = selectShape.GetHandleCursor(9);
                }
                if (m < 0)
                {
                    Cursor = selectShape.GetHandleCursor(0);

                }
            }
            if (selectMode == SelectionMode.Size)

            {
                if (selectShape != null) selectShape.Resize(e.Location, handelNum);
                oldLocation = e.Location;
                Refresh();
            }
            if (selectMode == SelectionMode.Move)
            {
                int x = e.X - oldLocation.X;
                int y = e.Y - oldLocation.Y;
                oldLocation.X = e.X;
                oldLocation.Y = e.Y;
                foreach (var item in obj)
                {
                    if (item.Selected) item.Move(x, y);
                }
                Refresh();
                //picBox.Refresh(); 
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectMode != SelectionMode.None)
            {
                if (selectMode == SelectionMode.Size || selectMode == SelectionMode.Move )//|| mode == ClickObj.Move)
                {
                    selectMode = SelectionMode.None;
                    select = Choice.None;
                }
            }
            if (select == Choice.Pen)
                tempPen = null;
            
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {

            foreach (var item in obj)
                item.Draw();
        }
        #region Palet
        
        
        private void upPenSize_ValueChanged(object sender, EventArgs e)
        {
            pen.Width =(float) upPenSize.Value;
            selectShape.Draw();
            //foreach (var item in obj)
            //    item.Draw();
        }

        private void btnCurrentColor_BackColorChanged(object sender, EventArgs e)
        {
            pen.Color = btnCurrentColor.BackColor;
            selectShape.Draw();
        }

        private void btnCurrentColor_Click(object sender, EventArgs e)
        {
            DialogResult d= colorDialog1.ShowDialog();
            if (d == DialogResult.OK) btnCurrentColor.BackColor = colorDialog1.Color;

        }
        #endregion

        private void frmMain_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) CTRLpresed = true;
            else CTRLpresed = false;
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control) CTRLpresed = true;
            else CTRLpresed = false;
        }

        private void btnBrushTrans_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK) btnBrushTrans.BackColor = colorDialog1.Color;
        }

        private void btnBrushTrans_BackColorChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(colorDialog1.Color);
            //foreach (var item in obj)
            //    item.Draw();
            selectShape.brush=brush;
            selectShape.Draw();
        }
    }
}
