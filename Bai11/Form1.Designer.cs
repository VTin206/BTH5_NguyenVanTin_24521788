namespace Bai11
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbBrushes = new System.Windows.Forms.GroupBox();
            this.rdLinearGradient = new System.Windows.Forms.RadioButton();
            this.rdTexture = new System.Windows.Forms.RadioButton();
            this.rdHatch = new System.Windows.Forms.RadioButton();
            this.rdSolid = new System.Windows.Forms.RadioButton();
            this.grbPen = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbShape = new System.Windows.Forms.GroupBox();
            this.rdEllipse = new System.Windows.Forms.RadioButton();
            this.rdRectangle = new System.Windows.Forms.RadioButton();
            this.rdLine = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbBrushes.SuspendLayout();
            this.grbPen.SuspendLayout();
            this.grbShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.grbBrushes);
            this.splitContainer1.Panel1.Controls.Add(this.grbPen);
            this.splitContainer1.Panel1.Controls.Add(this.grbShape);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 649);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbBrushes
            // 
            this.grbBrushes.Controls.Add(this.rdLinearGradient);
            this.grbBrushes.Controls.Add(this.rdTexture);
            this.grbBrushes.Controls.Add(this.rdHatch);
            this.grbBrushes.Controls.Add(this.rdSolid);
            this.grbBrushes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBrushes.Location = new System.Drawing.Point(6, 421);
            this.grbBrushes.Name = "grbBrushes";
            this.grbBrushes.Size = new System.Drawing.Size(300, 216);
            this.grbBrushes.TabIndex = 2;
            this.grbBrushes.TabStop = false;
            this.grbBrushes.Text = "Brushes";
            // 
            // rdLinearGradient
            // 
            this.rdLinearGradient.AutoSize = true;
            this.rdLinearGradient.Location = new System.Drawing.Point(20, 162);
            this.rdLinearGradient.Name = "rdLinearGradient";
            this.rdLinearGradient.Size = new System.Drawing.Size(255, 33);
            this.rdLinearGradient.TabIndex = 3;
            this.rdLinearGradient.TabStop = true;
            this.rdLinearGradient.Text = "LinearGradientBrush";
            this.rdLinearGradient.UseVisualStyleBackColor = true;
            // 
            // rdTexture
            // 
            this.rdTexture.AutoSize = true;
            this.rdTexture.Location = new System.Drawing.Point(20, 120);
            this.rdTexture.Name = "rdTexture";
            this.rdTexture.Size = new System.Drawing.Size(178, 33);
            this.rdTexture.TabIndex = 2;
            this.rdTexture.TabStop = true;
            this.rdTexture.Text = "TextureBrush";
            this.rdTexture.UseVisualStyleBackColor = true;
            // 
            // rdHatch
            // 
            this.rdHatch.AutoSize = true;
            this.rdHatch.Location = new System.Drawing.Point(20, 76);
            this.rdHatch.Name = "rdHatch";
            this.rdHatch.Size = new System.Drawing.Size(157, 33);
            this.rdHatch.TabIndex = 1;
            this.rdHatch.TabStop = true;
            this.rdHatch.Text = "HatchBrush";
            this.rdHatch.UseVisualStyleBackColor = true;
            // 
            // rdSolid
            // 
            this.rdSolid.AutoSize = true;
            this.rdSolid.Location = new System.Drawing.Point(20, 33);
            this.rdSolid.Name = "rdSolid";
            this.rdSolid.Size = new System.Drawing.Size(152, 33);
            this.rdSolid.TabIndex = 0;
            this.rdSolid.TabStop = true;
            this.rdSolid.Text = "SolidBrush";
            this.rdSolid.UseVisualStyleBackColor = true;
            // 
            // grbPen
            // 
            this.grbPen.Controls.Add(this.btnColor);
            this.grbPen.Controls.Add(this.txtWidth);
            this.grbPen.Controls.Add(this.label1);
            this.grbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPen.Location = new System.Drawing.Point(8, 205);
            this.grbPen.Name = "grbPen";
            this.grbPen.Size = new System.Drawing.Size(298, 181);
            this.grbPen.TabIndex = 1;
            this.grbPen.TabStop = false;
            this.grbPen.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(86, 98);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(118, 56);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(142, 36);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(113, 34);
            this.txtWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // grbShape
            // 
            this.grbShape.Controls.Add(this.rdEllipse);
            this.grbShape.Controls.Add(this.rdRectangle);
            this.grbShape.Controls.Add(this.rdLine);
            this.grbShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShape.Location = new System.Drawing.Point(6, 12);
            this.grbShape.Name = "grbShape";
            this.grbShape.Size = new System.Drawing.Size(300, 187);
            this.grbShape.TabIndex = 0;
            this.grbShape.TabStop = false;
            this.grbShape.Text = "Shape";
            // 
            // rdEllipse
            // 
            this.rdEllipse.AutoSize = true;
            this.rdEllipse.Location = new System.Drawing.Point(20, 130);
            this.rdEllipse.Name = "rdEllipse";
            this.rdEllipse.Size = new System.Drawing.Size(108, 33);
            this.rdEllipse.TabIndex = 2;
            this.rdEllipse.Text = "Ellipse";
            this.rdEllipse.UseVisualStyleBackColor = true;
            this.rdEllipse.CheckedChanged += new System.EventHandler(this.rdEllipse_CheckedChanged);
            // 
            // rdRectangle
            // 
            this.rdRectangle.AutoSize = true;
            this.rdRectangle.Location = new System.Drawing.Point(20, 82);
            this.rdRectangle.Name = "rdRectangle";
            this.rdRectangle.Size = new System.Drawing.Size(143, 33);
            this.rdRectangle.TabIndex = 1;
            this.rdRectangle.Text = "Rectangle";
            this.rdRectangle.UseVisualStyleBackColor = true;
            this.rdRectangle.CheckedChanged += new System.EventHandler(this.rdRectangle_CheckedChanged);
            // 
            // rdLine
            // 
            this.rdLine.AutoSize = true;
            this.rdLine.Checked = true;
            this.rdLine.Location = new System.Drawing.Point(20, 40);
            this.rdLine.Name = "rdLine";
            this.rdLine.Size = new System.Drawing.Size(80, 33);
            this.rdLine.TabIndex = 0;
            this.rdLine.TabStop = true;
            this.rdLine.Text = "Line";
            this.rdLine.UseVisualStyleBackColor = true;
            this.rdLine.CheckedChanged += new System.EventHandler(this.rdLine_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 649);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 649);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbBrushes.ResumeLayout(false);
            this.grbBrushes.PerformLayout();
            this.grbPen.ResumeLayout(false);
            this.grbPen.PerformLayout();
            this.grbShape.ResumeLayout(false);
            this.grbShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbBrushes;
        private System.Windows.Forms.GroupBox grbPen;
        private System.Windows.Forms.GroupBox grbShape;
        private System.Windows.Forms.RadioButton rdEllipse;
        private System.Windows.Forms.RadioButton rdRectangle;
        private System.Windows.Forms.RadioButton rdLine;
        private System.Windows.Forms.RadioButton rdLinearGradient;
        private System.Windows.Forms.RadioButton rdTexture;
        private System.Windows.Forms.RadioButton rdHatch;
        private System.Windows.Forms.RadioButton rdSolid;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

