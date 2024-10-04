using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DCU.Clases
{
    static class TextboxClass
    {

        public static void LenghtTxt(TextBox txt)
        {
            if(txt.Text.Length > 9)
            {
                MessageBox.Show("Limite de digitos alcanzado");
                txt.Text = txt.Text.Remove(9, 1);
            }
        }

        public static void deletetxt(TextBox txt, Label lb)
        {
            if (txt.Text != "")
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
            }

            else if (txt.Text == "")
            {
                try
                {
                    txt.Text = lb.Text.Remove(lb.Text.Length - 1, 1); ;
                    lb.Text = "";
                    txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
                }
                catch (ArgumentOutOfRangeException) { }
            }

        }

        public static void Optxt(TextBox txt, Label lb, double fr, double sc, string op)
        {
            if (txt.Text == sc.ToString() && lb.Text == fr.ToString())
            {
                if (op == "+")
                {
                    txt.Text = fr + sc.ToString();
                }

                if (op == "-")
                {
                    txt.Text = fr + sc.ToString();
                }

                if (op == "X")
                {
                    txt.Text = fr + sc.ToString();
                }

                if (op == "+")
                {
                    txt.Text = fr + sc.ToString();
                }

                if (op == "%")
                {
                    txt.Text = fr + sc.ToString();
                }
            }
        }
    }
}
