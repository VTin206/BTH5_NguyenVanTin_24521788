using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        FontFamily fontFamily;
        int size;
        Color fontColor;
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families) 
            {
                cbFont.Items.Add(font.Name);
            }
            btnColor.BackColor = rtxtDisplay.ForeColor;
            cbSize.Items.Add("8");
            cbSize.Items.Add("9");
            cbSize.Items.Add("10");
            cbSize.Items.Add("11");
            cbSize.Items.Add("12");
            cbSize.Items.Add("14");
            cbSize.Items.Add("16");
            cbSize.Items.Add("18");
            cbSize.Items.Add("20");
            cbSize.Items.Add("22");
            cbSize.Items.Add("24");
            cbSize.Items.Add("26");
            cbSize.Items.Add("28");
            cbSize.Items.Add("36");
            cbSize.Items.Add("48");
            cbSize.Items.Add("72");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamily = new FontFamily(cbFont.SelectedItem.ToString());
            rtxtDisplay.Font = new Font(fontFamily, rtxtDisplay.Font.Size, rtxtDisplay.Font.Style);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                rtxtDisplay.ForeColor = colorDialog.Color;
            }
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            if(cbBold.Checked)
            {
                rtxtDisplay.Font = new Font(rtxtDisplay.Font, rtxtDisplay.Font.Style ^ FontStyle.Bold);
            }
            else
            {
                rtxtDisplay.Font = new Font(rtxtDisplay.Font, rtxtDisplay.Font.Style & ~FontStyle.Bold);
            }
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if(cbItalic.Checked)
            {
                rtxtDisplay.Font = new Font(rtxtDisplay.Font, rtxtDisplay.Font.Style ^ FontStyle.Italic);
            }
            else
            {
                rtxtDisplay.Font = new Font(rtxtDisplay.Font, rtxtDisplay.Font.Style & ~FontStyle.Italic);
            }  
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnderline.Checked) {
                rtxtDisplay.Font = new Font(rtxtDisplay.Font, rtxtDisplay.Font.Style ^ FontStyle.Underline);
            }
            else
            {
                rtxtDisplay.Font = new Font(rtxtDisplay.Font, rtxtDisplay.Font.Style & ~FontStyle.Underline);
            }
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = int.Parse(cbSize.SelectedItem.ToString());
            rtxtDisplay.Font = new Font(rtxtDisplay.Font.FontFamily, size, rtxtDisplay.Font.Style);
        }

        private void chkLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeft.Checked) 
            {
                rtxtDisplay.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void chkCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCenter.Checked) 
            {
                rtxtDisplay.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void chkRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRight.Checked)
            {
                rtxtDisplay.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
    }
}
