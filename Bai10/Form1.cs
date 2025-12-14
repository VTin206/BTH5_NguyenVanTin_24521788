using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Point[] pts =
            {
                new Point(250, 30),
                new Point(350, 120),
                new Point(200, 240)
            };
            if(cbDashStyle.SelectedItem == null && cbWidth.SelectedItem == null &&
               cbLineJoin.SelectedItem == null && cbDashCap.SelectedItem == null &&
               sbStartCap.SelectedItem == null && cbEndCap.SelectedItem == null)
            {
                g.DrawPolygon(pen, pts);
                g.DrawLine(pen, 31, 111, 56, 235);
                return;
            }
            if (cbDashStyle.SelectedItem != null)
            {
                pen.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), cbDashStyle.SelectedItem.ToString());
            }
            if(cbWidth.SelectedItem != null)
            {
                pen.Width = float.Parse(cbWidth.SelectedItem.ToString());
            }
            if(cbLineJoin.SelectedItem != null)
            {
                pen.LineJoin = (LineJoin)Enum.Parse(typeof(LineJoin), cbLineJoin.SelectedItem.ToString());
            }
            if(cbDashCap.SelectedItem != null)
            {
                pen.DashCap = (DashCap)Enum.Parse(typeof(DashCap), cbDashCap.SelectedItem.ToString());
            }
            if(sbStartCap.SelectedItem != null)
            {
                pen.StartCap = (LineCap)Enum.Parse(typeof(LineCap), sbStartCap.SelectedItem.ToString());
            }
            if(cbEndCap.SelectedItem != null)
            {
                pen.EndCap = (LineCap)Enum.Parse(typeof(LineCap), cbEndCap.SelectedItem.ToString());
            }
            g.DrawPolygon(pen, pts);
            g.DrawLine(pen, 31, 111, 56, 235);
        }

        private void cbDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Invalidate();
        }

        private void cbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Invalidate();
        }

        private void cbLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Invalidate();
        }

        private void cbDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Invalidate();
        }

        private void sbStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Invalidate();
        }

        private void cbEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Invalidate();
        }
    }
}