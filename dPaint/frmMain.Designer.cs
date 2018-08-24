namespace dPaint
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCurrentColor = new System.Windows.Forms.Button();
            this.btnBrushTrans = new System.Windows.Forms.Button();
            this.upPenSize = new System.Windows.Forms.NumericUpDown();
            this.btnRhom = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnFillEllips = new System.Windows.Forms.Button();
            this.btnFillCircle = new System.Windows.Forms.Button();
            this.btnFillSqure = new System.Windows.Forms.Button();
            this.btnFillRectangle = new System.Windows.Forms.Button();
            this.btnEllips = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSqure = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPenSize)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCurrentColor);
            this.panel1.Controls.Add(this.btnBrushTrans);
            this.panel1.Controls.Add(this.upPenSize);
            this.panel1.Controls.Add(this.btnRhom);
            this.panel1.Controls.Add(this.btnTriangle);
            this.panel1.Controls.Add(this.btnBrush);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Controls.Add(this.btnFillEllips);
            this.panel1.Controls.Add(this.btnFillCircle);
            this.panel1.Controls.Add(this.btnFillSqure);
            this.panel1.Controls.Add(this.btnFillRectangle);
            this.panel1.Controls.Add(this.btnEllips);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnSqure);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 491);
            this.panel1.TabIndex = 0;
            // 
            // btnCurrentColor
            // 
            this.btnCurrentColor.BackColor = System.Drawing.Color.Magenta;
            this.btnCurrentColor.Location = new System.Drawing.Point(8, 397);
            this.btnCurrentColor.Name = "btnCurrentColor";
            this.btnCurrentColor.Size = new System.Drawing.Size(26, 24);
            this.btnCurrentColor.TabIndex = 20;
            this.btnCurrentColor.UseVisualStyleBackColor = false;
            this.btnCurrentColor.BackColorChanged += new System.EventHandler(this.btnCurrentColor_BackColorChanged);
            this.btnCurrentColor.Click += new System.EventHandler(this.btnCurrentColor_Click);
            // 
            // btnBrushTrans
            // 
            this.btnBrushTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnBrushTrans.Location = new System.Drawing.Point(10, 459);
            this.btnBrushTrans.Name = "btnBrushTrans";
            this.btnBrushTrans.Size = new System.Drawing.Size(26, 24);
            this.btnBrushTrans.TabIndex = 22;
            this.btnBrushTrans.UseVisualStyleBackColor = false;
            this.btnBrushTrans.BackColorChanged += new System.EventHandler(this.btnBrushTrans_BackColorChanged);
            this.btnBrushTrans.Click += new System.EventHandler(this.btnBrushTrans_Click);
            // 
            // upPenSize
            // 
            this.upPenSize.Location = new System.Drawing.Point(6, 423);
            this.upPenSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upPenSize.Name = "upPenSize";
            this.upPenSize.Size = new System.Drawing.Size(32, 20);
            this.upPenSize.TabIndex = 19;
            this.upPenSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upPenSize.ValueChanged += new System.EventHandler(this.upPenSize_ValueChanged);
            // 
            // btnRhom
            // 
            this.btnRhom.Image = global::dPaint.Properties.Resources.Rhom;
            this.btnRhom.Location = new System.Drawing.Point(8, 303);
            this.btnRhom.Name = "btnRhom";
            this.btnRhom.Size = new System.Drawing.Size(26, 24);
            this.btnRhom.TabIndex = 18;
            this.btnRhom.UseVisualStyleBackColor = true;
            this.btnRhom.Click += new System.EventHandler(this.btnRhom_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Image = global::dPaint.Properties.Resources.Triangle;
            this.btnTriangle.Location = new System.Drawing.Point(8, 273);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(26, 24);
            this.btnTriangle.TabIndex = 17;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.Image = global::dPaint.Properties.Resources.paint_brush;
            this.btnBrush.Location = new System.Drawing.Point(8, 367);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(26, 24);
            this.btnBrush.TabIndex = 10;
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Image = global::dPaint.Properties.Resources.pencil;
            this.btnPencil.Location = new System.Drawing.Point(8, 337);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(26, 24);
            this.btnPencil.TabIndex = 9;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnFillEllips
            // 
            this.btnFillEllips.Image = global::dPaint.Properties.Resources.Fillellips;
            this.btnFillEllips.Location = new System.Drawing.Point(8, 243);
            this.btnFillEllips.Name = "btnFillEllips";
            this.btnFillEllips.Size = new System.Drawing.Size(26, 24);
            this.btnFillEllips.TabIndex = 8;
            this.btnFillEllips.UseVisualStyleBackColor = true;
            this.btnFillEllips.Click += new System.EventHandler(this.btnFillEllips_Click);
            // 
            // btnFillCircle
            // 
            this.btnFillCircle.Image = global::dPaint.Properties.Resources.Fillcircle;
            this.btnFillCircle.Location = new System.Drawing.Point(8, 213);
            this.btnFillCircle.Name = "btnFillCircle";
            this.btnFillCircle.Size = new System.Drawing.Size(26, 24);
            this.btnFillCircle.TabIndex = 7;
            this.btnFillCircle.UseVisualStyleBackColor = true;
            this.btnFillCircle.Click += new System.EventHandler(this.btnFillCircle_Click);
            // 
            // btnFillSqure
            // 
            this.btnFillSqure.Image = global::dPaint.Properties.Resources.Fillsqure;
            this.btnFillSqure.Location = new System.Drawing.Point(8, 183);
            this.btnFillSqure.Name = "btnFillSqure";
            this.btnFillSqure.Size = new System.Drawing.Size(26, 24);
            this.btnFillSqure.TabIndex = 6;
            this.btnFillSqure.UseVisualStyleBackColor = true;
            this.btnFillSqure.Click += new System.EventHandler(this.btnFillSqure_Click);
            // 
            // btnFillRectangle
            // 
            this.btnFillRectangle.Image = global::dPaint.Properties.Resources.Fillrectangle;
            this.btnFillRectangle.Location = new System.Drawing.Point(8, 153);
            this.btnFillRectangle.Name = "btnFillRectangle";
            this.btnFillRectangle.Size = new System.Drawing.Size(26, 24);
            this.btnFillRectangle.TabIndex = 5;
            this.btnFillRectangle.UseVisualStyleBackColor = true;
            this.btnFillRectangle.Click += new System.EventHandler(this.btnFillRectangle_Click);
            // 
            // btnEllips
            // 
            this.btnEllips.Image = global::dPaint.Properties.Resources.ellips;
            this.btnEllips.Location = new System.Drawing.Point(8, 123);
            this.btnEllips.Name = "btnEllips";
            this.btnEllips.Size = new System.Drawing.Size(26, 24);
            this.btnEllips.TabIndex = 4;
            this.btnEllips.UseVisualStyleBackColor = true;
            this.btnEllips.Click += new System.EventHandler(this.btnEllips_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Image = global::dPaint.Properties.Resources.circle;
            this.btnCircle.Location = new System.Drawing.Point(8, 93);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(26, 24);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSqure
            // 
            this.btnSqure.Image = global::dPaint.Properties.Resources.squre;
            this.btnSqure.Location = new System.Drawing.Point(8, 63);
            this.btnSqure.Name = "btnSqure";
            this.btnSqure.Size = new System.Drawing.Size(26, 24);
            this.btnSqure.TabIndex = 2;
            this.btnSqure.UseVisualStyleBackColor = true;
            this.btnSqure.Click += new System.EventHandler(this.btnSqure_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = global::dPaint.Properties.Resources.rectangle;
            this.btnRectangle.Location = new System.Drawing.Point(8, 33);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(26, 24);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Image = global::dPaint.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(8, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(26, 24);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(689, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::dPaint.Properties.Resources.folder;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::dPaint.Properties.Resources.save;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Location = new System.Drawing.Point(710, 394);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(16, 24);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 522);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Jiyar Rahimi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upPenSize)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnEllips;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSqure;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnFillEllips;
        private System.Windows.Forms.Button btnFillCircle;
        private System.Windows.Forms.Button btnFillSqure;
        private System.Windows.Forms.Button btnFillRectangle;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRhom;
        private System.Windows.Forms.NumericUpDown upPenSize;
        private System.Windows.Forms.Button btnCurrentColor;
        private System.Windows.Forms.Button btnBrushTrans;

    }
}

