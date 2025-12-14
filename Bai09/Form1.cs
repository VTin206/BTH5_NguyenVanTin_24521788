using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            Brush brush = new SolidBrush(Color.Red);
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    g.DrawEllipse(pen, 92, 101, 200, 200);
                    break;
                case 1:
                    g.DrawRectangle(pen, 92, 101, 200, 200);
                    break;
                case 2:
                    g.DrawEllipse(pen, 92, 101, 200, 100);
                    break;
                case 3:
                    g.DrawPie(pen, 92, 101, 200, 200, 0, 120);
                    break;
                case 4:
                    g.FillEllipse(brush, 92, 101, 200, 200);
                    break;
                case 5:
                    g.FillRectangle(brush, 92, 101, 200, 200);
                    break;
                case 6:
                    g.FillEllipse(brush, 92, 101, 200, 100);
                    break;
                case 7:
                    g.FillPie(brush, 92, 101, 200, 200, 0, 120);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
