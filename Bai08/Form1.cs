using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int h = this.ClientSize.Height;
            int w = this.ClientSize.Width;
            Point center = new Point(w / 2, h / 2);
            float radius = Math.Min(w, h) / 2 - 30;
            DrawDots(g, center, radius);
            
            DateTime now = DateTime.Now;
            double ms = now.Millisecond;
            double sec = now.Second + ms / 1000.0;
            double min = now.Minute + sec / 60.0;
            double hour = (now.Hour % 12) + now.Minute / 60.0 + now.Second / 3600.0;
            double hourAngle = hour * 30.0;    
            double minuteAngle = min * 6.0;
            double secondAngle = sec * 6.0;
            DrawPolygon(g, center, radius * 0.7f, hourAngle, 0.2f, 0.13f);
            DrawPolygon(g, center, radius * 0.9f, minuteAngle , 0.2f, 0.05f);
            DrawSecond(g, center, radius * 0.95f, secondAngle);
        }
        private void DrawDots(Graphics g, Point center, float radius)
        {
            for (int i = 0; i < 60; i++)
            {
                double angleDeg = i * 6.0 - 90.0;
                double angle = angleDeg * Math.PI / 180.0;
                float x = center.X + (float)(radius * Math.Cos(angle));
                float y = center.Y + (float)(radius * Math.Sin(angle));
                if (i % 5 == 0)
                {
                    float big = radius * 0.08f;
                    using (Brush brush = new SolidBrush(Color.White))
                    {
                        g.FillEllipse(brush, x - big / 2, y - big / 2, big, big);
                    }
                }
                else
                {
                    float small = radius * 0.015f;
                    using (Brush brush = new SolidBrush(Color.White))
                    {
                        g.FillEllipse(brush, x - small / 2, y - small / 2, small, small);
                    }
                }
            }
        }
        private void DrawPolygon(Graphics g, Point center, float length, double angleDeg, float tailRatio, float widthRatio)
        {
            float width = length * widthRatio;
            float tail = length * tailRatio;
            PointF[] clockwise = new PointF[]
            {
                new PointF(length, 0),
                new PointF(0, width),
                new PointF(-tail, 0),                
                new PointF(0, -width)
            };
            var state = g.Save();

            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(-90);
            g.RotateTransform((float)angleDeg);

            using (Pen pen = new Pen(Color.White, 1))
            {
                g.DrawPolygon(pen, clockwise);
            }
            g.Restore(state);
        }
        private void DrawSecond(Graphics g, Point center, float length, double angleDeg)
        {
            var state = g.Save();
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(-90);
            g.RotateTransform((float)angleDeg);
            using (Pen pen = new Pen(Color.White, 2f))
            {
                g.DrawLine(pen, 0, 0, length, 0);
            }
            g.Restore(state);
        }
    }
}
