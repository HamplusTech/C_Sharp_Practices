using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace C_Sharp_Practices
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }        
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == btn0.Text)
                txtScreen.Text = btn0.Text;
            else 
            txtScreen.Text += btn0.Text;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtScreen.Text += btn1.Text;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn2.Text;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtScreen.Text += btn3.Text;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtScreen.Text += btn4.Text;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn5.Text;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtScreen.Text += btn6.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtScreen.Text += btn7.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
         txtScreen.Text += btn9.Text;
        }
        double temp=0, total=0;
        string action;
        bool btnStateOn;
        bool PlusBtnClicked;
        bool MinusBtnClicked;
        //bool DivideBtnClicked = false;
        //bool MultiplyBtnClicked = false;
        string btnPeriodClick;
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
            temp = 0; total = 0;
            btnPeriodClick = "no"; btnStateOn = false;
        }
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (btnPeriodClick == "yes")
                txtScreen.Text = txtScreen.Text;
            else
                txtScreen.Text = txtScreen.Text + ".";
                btnPeriodClick = "yes";
        }        
        private void btnPlus_Click(object sender, EventArgs e)
        {            
                if (btnStateOn == true)
                {
                    temp = temp + double.Parse(txtScreen.Text);
                }
                else
                {
                    temp = double.Parse(txtScreen.Text); btnStateOn = true; PlusBtnClicked = false;
                }           
            //txtScreen.Lines[1] = temp.ToString();
            txtScreen.Clear();
            action = "+";
            //PlusBtnClicked="+";
            //btnPeriodClick = "no";
            //MinusBtnClicked = "-"; MultiplyBtnClicked = false; DivideBtnClicked = false;
        }        
        private void btnMinus_Click(object sender, EventArgs e)
        {           
                if (btnStateOn == true)
                {
                    temp = temp - double.Parse(txtScreen.Text);
                }
                else
                {
                    temp = double.Parse(txtScreen.Text); btnStateOn = true; MinusBtnClicked = true;
                }          
            txtScreen.Clear();
            action = "-";            
           // MinusBtnClicked = "-";
           // btnPeriodClick = "no";
            //PlusBtnClicked = false; MultiplyBtnClicked = false; DivideBtnClicked = false;
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (btnStateOn == true)
            {
                temp = temp * double.Parse(txtScreen.Text);
            }
            else
            {
                temp = double.Parse(txtScreen.Text); btnStateOn = true;
            } 
            txtScreen.Clear();
            action = "*";
            //MultiplyBtnClicked = true;
            //btnPeriodClick = "no";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (btnStateOn == true)
            {
                temp = temp / double.Parse(txtScreen.Text);
            }
            else
            {
                temp = double.Parse(txtScreen.Text); btnStateOn = true;
            } 
            txtScreen.Clear();
            action = "/";
            //DivideBtnClicked = true;
            //btnPeriodClick = "no";
        }
        private void Cal()
        {
            ////temp  = double.Parse(txtScreen.Text);
            //if (action == "+")
            //    total = temp + double.Parse(txtScreen.Text);
            //else if (action == "-")
            //    temp = temp - double.Parse(txtScreen.Text);
            //else if (action == "*")
            //    total = temp * double.Parse(txtScreen.Text);
            //else if (action == "/")
            //    total = temp / double.Parse(txtScreen.Text);
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double tempP = double.Parse(txtScreen.Text);
            if (action == "+")
            {
                total = temp + double.Parse(txtScreen.Text); // or tempP
            }
            else if (action == "-")
            {
                total = temp - tempP;
            }
            else if (action == "*")
            {
                total = temp * double.Parse(txtScreen.Text); // or tempP
            }
            else if (action == "/")
            {
                total = temp / tempP;
            }
            // total = temp + double.Parse(txtScreen.Text);
            txtScreen.Text = total.ToString();
            temp = 0;
            btnPeriodClick = "no"; btnStateOn = false;
            total = 0;
        }
        double MemAdd, MemSub;
        public string GetStringLength(string TextboxString)
        {
            string StringLenght = Convert.ToString(TextboxString.Length);
            return StringLenght;
        }
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text != "")
                txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1);
            /* //txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
              or
              //int StringNewLenght = int.Parse(GetStringLength(txtScreen.Text));
              //StringNewLenght = StringNewLenght -1;
              //txtScreen.Text = (txtScreen.Text).Remove(StringNewLenght);*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int StringLength = int.Parse(GetStringLength(txtScreen.Text));
            MessageBox.Show(Convert.ToString(StringLength), "The Length of the String", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }                        
    }
}
