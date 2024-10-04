using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DCU.Clases
{
    static class ClassOperations
    {

        private static double last_result;
        private static double lastfr_value;
        private static double lastsc_value;
        private static string last_op;
        private static double[] history = new double[3];

        public static double Por(double a, double b)
        {
            return b * (a / 100);
        }

        public static bool Valueverify(double x, TextBox txt)
        {
            if (txt.Text == "")
            {
                return false;
            }

            if (txt.Text != "")
            {
                return true;
            }

            return false;
        }

        public static bool Changeop(Label lb, string op)
        {
            if (lb.Text != "")
            {
                lb.Text = lb.Text.Remove(lb.Text.Length - 1, 1) + op;
                return true;
            }

            return false;
        }

        public static void Results( double re, double fr, double sc, string op)
        {

            last_result = re;
            lastfr_value = fr;
            lastsc_value = sc;
            last_op = op;

        }

        public static void Undo(TextBox txt, Label lb)
        {
            if (txt.Text != lastfr_value.ToString() && lb.Text != lastsc_value.ToString() && lb.Text != last_result.ToString())
            {
                if (last_result != 0)
                {
                    txt.Text = last_result.ToString();
                    lb.Text = "";
                }

            }

            if (txt.Text == last_result.ToString())
            {
                if (lastfr_value != 0 && lastsc_value != 0)
                {
                    txt.Text = lastsc_value.ToString();
                    lb.Text = (lastfr_value + last_op).ToString();
                }

            }
        }

    }
}
