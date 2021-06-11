using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Sharp_Practices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fn, sn, result;
            fn = 12;
            sn = 24;
            result = fn + sn;
            MessageBox.Show(result.ToString(), "Summation",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float fn, sn;
            float  result;
            fn = 12.87F; sn = 24.112F;
            //sn = 24.112F;
            result =  fn + (int) sn;
//            MessageBox.Show(result.ToString());
            MessageBox.Show(result.ToString(), "Summation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count += 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }
            MessageBox.Show("the answer is " + count);
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            for (int h = 0; h < 254; h++)
            {
                this.BackColor = Color.FromArgb(h, 255 - h, h);
                Application.DoEvents();
                System.Threading.Thread.Sleep(3);
            }
        }
    }
}
