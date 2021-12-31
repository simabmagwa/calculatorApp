/*Simanye Magwa
 * December 2021
 * Simple Calculator that switches from light mode to dark mode
 * This is a calculator which performs the basic calculations(+,*,-,/). It also includes a button for calculating percentage. The user can also click the 'Dark mode' button to switch the calculator UI from light mode to dark mode.
 * backspace-for erasing the last integer entered, helpful when user makes a mistake.
 * CLR-clears the whole calculation
 * ','-can be used when working with decimal numbers
 * dark mode-switches UI from lightmode to darkmode
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double firstNum ;
        double answer;
        string operation;
        public Form1()
        {
            InitializeComponent();

            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "0"; //clears text when form is loaded
            btnLightMode.Visible = false;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            if (lblDisplay.Text=="0")
            {
                lblDisplay.Text = num1.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num1.ToString();

            }   

            


        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            int num2 = 2;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num2.ToString();
            }
            else
            {

                lblDisplay.Text = lblDisplay.Text + num2.ToString();
            }

        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            int num3 = 3;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num3.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num3.ToString();
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            int num4 = 4;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num4.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num4.ToString();
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            int num5 = 5;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num5.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num5.ToString();
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            int num6=6;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num6.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num6.ToString();
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            int num7 = 7;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num7.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num7.ToString();
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            int num8 = 8;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num8.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num8.ToString();
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            int num9 = 9;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num9.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num9.ToString();
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            int num0 = 0;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = num0.ToString();
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + num0;
            }
        }
       

        private void btnCLR_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != null)
            {
                //fuction to clear text
                lblDisplay.Text = "0";
                lblCalculation.Text = "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
              firstNum = Double.Parse(lblDisplay.Text);
                lblDisplay.Text = "0";
            operation = "+";
            lblCalculation.Text = firstNum.ToString() + operation.ToString();



        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "-";
            lblCalculation.Text = firstNum.ToString() + operation.ToString();

        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "*";
            lblCalculation.Text = firstNum.ToString() + operation.ToString();

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "/";
            lblCalculation.Text = firstNum.ToString() + operation.ToString();


        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNum;
           
            secondNum=double.Parse(lblDisplay.Text);
            if(operation=="+")
            {
                answer = (firstNum + secondNum);
                lblDisplay.Text = answer.ToString();
                lblCalculation.Text = lblCalculation.Text+secondNum.ToString();
                firstNum = answer;
            }
            if (operation == "-")
            {
                answer = (firstNum - secondNum);
                lblDisplay.Text = answer.ToString();
                lblCalculation.Text = lblCalculation.Text + secondNum.ToString();
                firstNum = answer;
            }
            if (operation == "*")
            {
                answer = (firstNum * secondNum);
                lblDisplay.Text = answer.ToString();
                lblCalculation.Text = lblCalculation.Text + secondNum.ToString();
                firstNum = answer;
            }
            if (operation=="/")
            {
                answer = (firstNum / secondNum);
                lblDisplay.Text = answer.ToString();
                lblCalculation.Text = lblCalculation.Text + secondNum.ToString();
                firstNum = answer;
            }
            if(operation=="/"&&secondNum==0)
            {
                lblDisplay.Text = "Error!can't divide by zero";
            }
            if(operation=="%")
            {
                answer = secondNum * (firstNum / 100);
                lblDisplay.Text = answer.ToString();
                lblCalculation.Text = lblCalculation.Text + secondNum.ToString();
                firstNum = answer;
            }
          

        }

        private void lblCalculation_Click(object sender, EventArgs e)
        {

        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            lblDisplay.Text =lblDisplay.Text+ ",";
            
        }

        private void btnPerc_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "%";
            lblCalculation.Text = firstNum.ToString() + operation.ToString();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int length = lblDisplay.Text.Length - 1;
            string text = lblDisplay.Text;
            lblDisplay.Text = "";
            for(int i=0;i<length;i++)
            {
                lblDisplay.Text = lblDisplay.Text + text[i];
            }

        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            lblAuthorName.ForeColor = Color.White;
            bool keyPressed = true;
            if(keyPressed==true)
            {
                btnLightMode.Visible = true;
                btnDarkMode.Visible = false;

            }
            
            
        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            lblAuthorName.ForeColor = Color.Black;
            bool keyisPressed = true;
            if( keyisPressed==true)
            {
                btnLightMode.Visible = false;
                btnDarkMode.Visible = true;
            }
          
        }
    }
}