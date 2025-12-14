namespace Bai10
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
            this.cbEndCap = new System.Windows.Forms.ComboBox();
            this.cbDashCap = new System.Windows.Forms.ComboBox();
            this.sbStartCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLineJoin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDashStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.cbEndCap);
            this.splitContainer1.Panel1.Controls.Add(this.cbDashCap);
            this.splitContainer1.Panel1.Controls.Add(this.sbStartCap);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cbLineJoin);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cbWidth);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cbDashStyle);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(873, 391);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbEndCap
            // 
            this.cbEndCap.FormattingEnabled = true;
            this.cbEndCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "ArrowAnchor",
            "RoundAnchor",
            "SquareAnchor",
            "DiamondAnchor"});
            this.cbEndCap.Location = new System.Drawing.Point(114, 324);
            this.cbEndCap.Name = "cbEndCap";
            this.cbEndCap.Size = new System.Drawing.Size(121, 24);
            this.cbEndCap.TabIndex = 11;
            this.cbEndCap.SelectedIndexChanged += new System.EventHandler(this.cbEndCap_SelectedIndexChanged);
            // 
            // cbDashCap
            // 
            this.cbDashCap.FormattingEnabled = true;
            this.cbDashCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Triangle"});
            this.cbDashCap.Location = new System.Drawing.Point(114, 198);
            this.cbDashCap.Name = "cbDashCap";
            this.cbDashCap.Size = new System.Drawing.Size(121, 24);
            this.cbDashCap.TabIndex = 8;
            this.cbDashCap.SelectedIndexChanged += new System.EventHandler(this.cbDashCap_SelectedIndexChanged);
            // 
            // sbStartCap
            // 
            this.sbStartCap.FormattingEnabled = true;
            this.sbStartCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "ArrowAnchor",
            "RoundAnchor",
            "SquareAnchor",
            "DiamondAnchor"});
            this.sbStartCap.Location = new System.Drawing.Point(114, 259);
            this.sbStartCap.Name = "sbStartCap";
            this.sbStartCap.Size = new System.Drawing.Size(121, 24);
            this.sbStartCap.TabIndex = 10;
            this.sbStartCap.SelectedIndexChanged += new System.EventHandler(this.sbStartCap_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "End Cap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Cap:";
            // 
            // cbLineJoin
            // 
            this.cbLineJoin.FormattingEnabled = true;
            this.cbLineJoin.Items.AddRange(new object[] {
            "Miter",
            "Bevel",
            "Round"});
            this.cbLineJoin.Location = new System.Drawing.Point(114, 142);
            this.cbLineJoin.Name = "cbLineJoin";
            this.cbLineJoin.Size = new System.Drawing.Size(121, 24);
            this.cbLineJoin.TabIndex = 6;
            this.cbLineJoin.SelectedIndexChanged += new System.EventHandler(this.cbLineJoin_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dash Cap:";
            // 
            // cbWidth
            // 
            this.cbWidth.FormattingEnabled = true;
            this.cbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbWidth.Location = new System.Drawing.Point(114, 85);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(121, 24);
            this.cbWidth.TabIndex = 7;
            this.cbWidth.SelectedIndexChanged += new System.EventHandler(this.cbWidth_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Line Join:";
            // 
            // cbDashStyle
            // 
            this.cbDashStyle.FormattingEnabled = true;
            this.cbDashStyle.Items.AddRange(new object[] {
            "Custom",
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot ",
            "Solid"});
            this.cbDashStyle.Location = new System.Drawing.Point(114, 29);
            this.cbDashStyle.Name = "cbDashStyle";
            this.cbDashStyle.Size = new System.Drawing.Size(121, 24);
            this.cbDashStyle.TabIndex = 9;
            this.cbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbDashStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dash Style:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 391);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbEndCap;
        private System.Windows.Forms.ComboBox sbStartCap;
        private System.Windows.Forms.ComboBox cbDashStyle;
        private System.Windows.Forms.ComboBox cbDashCap;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.ComboBox cbLineJoin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

