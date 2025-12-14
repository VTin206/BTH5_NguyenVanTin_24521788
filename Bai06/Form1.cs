using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.ItemHeight = 30;
            listBox1.DrawItem += listBox1_DrawItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                listBox1.Items.Add(font.Name);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string fontName = listBox1.Items[e.Index].ToString();
            e.DrawBackground();
            try
            {
                using (Font font = new Font(fontName, 14))
                {
                    e.Graphics.DrawString(fontName, font, new SolidBrush(e.ForeColor), e.Bounds.X + 5, e.Bounds.Y + 5);
                }
            }
            catch
            {
                using (Font fallback = new Font("Arial", 14))
                {
                    e.Graphics.DrawString(fontName, fallback, new SolidBrush(e.ForeColor), e.Bounds.X + 5, e.Bounds.Y + 5);
                }
            }
        }
    }
}
