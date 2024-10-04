using Calculadora_DCU.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Calculadora_DCU
{
    public partial class CalcudaloraForm : Form
    {

        private double frtvalue;
        private double secvalue;
        private string op;
        private double result;
        private double last_result;
        private double lastfr_value;
        private double lastsc_value;

        public CalcudaloraForm()
        {
            InitializeComponent();
        }
        //--------Txt
        private void textBox1_Click(object sender, EventArgs e)
        {
            btn0.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextboxClass.LenghtTxt(textBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text += label1.Text.Remove(label1.Text.Length - 1, 1);
        }
        //--------------------------------

        


        //--------NUMBERS
        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""){}
            else if (textBox1.Text.Contains(".")){}
            else
            {
                textBox1.Text += ".";
            }
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text += "00";
            }
        }
        //--------------------------------


        //--------OPERATIONS
        private void btnsum_Click(object sender, EventArgs e)
        {
            op = "+";
            if (ClassOperations.Valueverify(frtvalue, textBox1))
            {
                frtvalue = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + op;
                textBox1.Clear();
            }

            if (label1.Text != "")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1) + op;
            }
        }

        private void btnsubtraction_Click(object sender, EventArgs e)
        {
            op = "-";
            if (ClassOperations.Valueverify(frtvalue, textBox1))
            {
                frtvalue = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + op;
                textBox1.Clear();
            }

            if (label1.Text != "")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1) + op;
            }
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            op = "X";
            if (ClassOperations.Valueverify(frtvalue, textBox1))
            {
                frtvalue = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + op;
                textBox1.Clear();
            }

            if (label1.Text != "")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1) + op;
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            op = "÷";
            if (ClassOperations.Valueverify(frtvalue, textBox1))
            {
                frtvalue = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + op;
                textBox1.Clear();
            }

            if (label1.Text != "")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1) + op;
            }
        }

        private void btnporcentage_Click(object sender, EventArgs e)
        {
            op = "%";
            if (ClassOperations.Valueverify(frtvalue, textBox1))
            {
                frtvalue = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + op;
                textBox1.Clear();
            }

            if (label1.Text != "")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1) + op;
            }
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    {
                        if (ClassOperations.Valueverify(frtvalue, textBox1))
                        {
                            secvalue = Convert.ToDouble(textBox1.Text);
                            if (frtvalue.ToString() == textBox1.Text && secvalue.ToString() == label1.Text)
                            {
                                TextboxClass.Optxt(textBox1, label1, frtvalue, secvalue, op);
                                break;
                            }
                            else
                            {
                                textBox1.Text = (frtvalue + secvalue).ToString();
                                last_result = Convert.ToDouble(textBox1.Text);
                                ClassOperations.Results(last_result, frtvalue, secvalue, op);
                                label1.Text = "";
                                op = "";
                                break;
                            }
                            
                        }
                        else
                        {
                            secvalue = 0;
                            textBox1.Text = frtvalue.ToString();
                            label1.Text = "";
                            op = "";
                            break;
                        }
                    }

                case "-":
                    {
                        if (ClassOperations.Valueverify(frtvalue, textBox1))
                        {
                            secvalue = Convert.ToDouble(textBox1.Text);
                            textBox1.Text = (frtvalue - secvalue).ToString();
                            last_result = Convert.ToDouble(textBox1.Text);
                            ClassOperations.Results(last_result, frtvalue, secvalue, op);
                            label1.Text = "";
                            op = "";
                            break;
                        }
                        else
                        {
                            secvalue = 0;
                            textBox1.Text = frtvalue.ToString();
                            label1.Text = "";
                            op = "";
                            break;
                        }
                    }

                case "X":
                    {
                        if (ClassOperations.Valueverify(frtvalue, textBox1))
                        {
                            secvalue = Convert.ToDouble(textBox1.Text);
                            textBox1.Text = (frtvalue * secvalue).ToString();
                            last_result = Convert.ToDouble(textBox1.Text);
                            ClassOperations.Results(last_result, frtvalue, secvalue, op);
                            label1.Text = "";
                            op = "";
                            break;
                        }
                        else
                        {
                            textBox1.Text = frtvalue.ToString();
                            label1.Text = "";
                            op = "";
                            break;
                        }
                    }

                case "÷":
                    {


                        if (ClassOperations.Valueverify(frtvalue, textBox1))
                        {
                            secvalue = Convert.ToDouble(textBox1.Text);
                            textBox1.Text = (frtvalue / secvalue).ToString();
                            last_result = Convert.ToDouble(textBox1.Text);
                            ClassOperations.Results(last_result, frtvalue, secvalue, op);
                            label1.Text = "";
                            op = "";
                            break;
                        }
                        else
                        {
                            textBox1.Text = frtvalue.ToString();
                            label1.Text = "";
                            op = "";
                            break;
                        }
                    }

                case "%":
                    {

                        if (ClassOperations.Valueverify(frtvalue, textBox1))
                        {
                            secvalue = Convert.ToDouble(textBox1.Text);
                            textBox1.Text = ClassOperations.Por(frtvalue, secvalue).ToString();
                            last_result = Convert.ToDouble(textBox1.Text);
                            ClassOperations.Results(last_result, frtvalue, secvalue, op);
                            label1.Text = "";
                            op = "";
                            break;
                        }
                        else
                        {
                            textBox1.Text = frtvalue.ToString();
                            label1.Text = "";
                            op = "";
                            break;
                        }
                    }
            }
        }

        //--------------------------------Features

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            frtvalue = 0;
            secvalue = 0;
            op = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            TextboxClass.deletetxt(textBox1, label1);
        }

        private void btnans_Click(object sender, EventArgs e)
        {
            if (last_result != 0)
            {
                textBox1.Text += last_result.ToString();
            }

        }
          
        private void btnundo_Click(object sender, EventArgs e)
        {
            ClassOperations.Undo(textBox1, label1);
        }
        //--------------------------------
    }
}
