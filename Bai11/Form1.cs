using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        bool isDrawing = false;
        Point start;
        int Shapetype;
        Graphics g;
        Bitmap bmp;
        Pen pen;
        Brush brush;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            pen = new Pen(Color.Black, 2);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pictureBox1.Image = bmp;
            txtWidth.Text = pen.Width.ToString();
            HideBrushOptions();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdLine.Checked)
            {
                Shapetype = 1;
            }
            else if(rdRectangle.Checked)
            {
                Shapetype = 2;
            }
            else if(rdEllipse.Checked)
            {
                Shapetype = 3;
            }
            pen.Width = float.Parse(txtWidth.Text);
            if(rdSolid.Checked)
            {
                brush = new SolidBrush(Color.Green);
            }
            else if(rdHatch.Checked)
            {
                brush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
            else if(rdTexture.Checked)
            {
                Bitmap textureBmp = new Bitmap("picture.png");
                brush = new TextureBrush(textureBmp);
            }
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                start = e.Location;
                current = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Draw(g ,Shapetype, start, e.Location);
                pictureBox1.Refresh();
                isDrawing = false;
                start = Point.Empty;
                current = Point.Empty;
            }
        }

        Point current;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                current = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing)
            {
                return;
            }
            Graphics h = e.Graphics;
            h.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw(h, Shapetype, start, current);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
            }
        }
        void HideBrushOptions()
        {
            rdSolid.Enabled = false;
            rdTexture.Enabled = false;
            rdHatch.Enabled = false;
            rdLinearGradient.Enabled = false;
        }
        void ShowBrushOptions()
        {
            rdSolid.Enabled = true;
            rdTexture.Enabled = true;
            rdHatch.Enabled = true;
            rdLinearGradient.Enabled = true;
        }

        private void rdLine_CheckedChanged(object sender, EventArgs e)
        {
            HideBrushOptions();
            btnColor.Enabled = true;
            txtWidth.Enabled = true;
        }

        private void rdRectangle_CheckedChanged(object sender, EventArgs e)
        {
            ShowBrushOptions();
            rdSolid.Checked = true;
        }

        private void rdEllipse_CheckedChanged(object sender, EventArgs e)
        {
            ShowBrushOptions();
            rdSolid.Checked = true;
        }

        void Draw(Graphics graphics, int Shapetype, Point start, Point end)
        {
            switch (Shapetype)
            {
                case 1: // Line
                    graphics.DrawLine(pen, start, end);
                    break;
                case 2: // Rectangle
                    int xr = Math.Min(start.X, end.X);
                    int yr = Math.Min(start.Y, end.Y);
                    float widthr = Math.Abs(end.X - start.X);
                    float heightr = Math.Abs(end.Y - start.Y);
                    if (rdLinearGradient.Checked)
                    {
                        if(widthr > 0 && heightr > 0)
                        {
                            using(LinearGradientBrush lng = new LinearGradientBrush(
                                new Rectangle(xr, yr, (int)widthr, (int)heightr),
                                Color.Red,
                                Color.Green,
                                LinearGradientMode.Vertical) ) 
                            {

                                graphics.FillRectangle(lng, xr, yr, widthr, heightr);
                            }
                        }
                    }
                    else
                    {
                        graphics.FillRectangle(brush, xr, yr, widthr, heightr);
                    }
                    graphics.DrawRectangle(pen, xr, yr, widthr, heightr);
                    break;
                case 3: // Ellipse
                    int xe = Math.Min(start.X, end.X);
                    int ye = Math.Min(start.Y, end.Y);
                    float widthe = Math.Abs(end.X - start.X);
                    float heighte = Math.Abs(end.Y - start.Y);
                    if (rdLinearGradient.Checked)
                    {
                        if (widthe > 0 && heighte > 0)
                        {
                            using (LinearGradientBrush lng = new LinearGradientBrush(
                            new Rectangle(xe, ye, (int)widthe, (int)heighte),
                            Color.Red,
                            Color.Green,
                            LinearGradientMode.Vertical))
                            {
                                graphics.FillEllipse(lng, xe, ye, widthe, heighte);
                            } 
                        }
                    }
                    else
                    {
                        graphics.FillEllipse(brush, xe, ye, widthe, heighte);
                    }
                    graphics.DrawEllipse(pen, xe, ye, widthe, heighte);
                    break;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (pictureBox1.Width <= 0 || pictureBox1.Height <= 0) return;
            Bitmap newBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics newG = Graphics.FromImage(newBmp))
            {
                newG.SmoothingMode = SmoothingMode.AntiAlias;
                newG.Clear(Color.White);
                if (bmp != null)
                {
                    newG.DrawImageUnscaled(bmp, 0, 0);
                }
            }
            g?.Dispose();
            bmp?.Dispose();
            bmp = newBmp;
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            pictureBox1.Image = bmp;
        }
    }
}
