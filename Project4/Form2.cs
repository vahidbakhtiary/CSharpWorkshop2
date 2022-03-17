using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form2 : Form
    {

        string firstNumber = "";
        string secondNumber = "";
        string opt = "";

        public Form2()
        {
            InitializeComponent();
        }

         

        private void number_click(object sender, EventArgs e)
        {
             
            Button button = (Button) sender;
            string number = button.Text;

            if (string.IsNullOrWhiteSpace(opt))
            {
                firstNumber = firstNumber + number;
            }else
            {
                secondNumber = secondNumber + number;
            }
           

            string lastValue = txtResult.Text;

            txtResult.Text = lastValue + number;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            opt = button.Text;

            string lastValue = txtResult.Text;
            txtResult.Text = lastValue + Environment.NewLine + opt + Environment.NewLine;
        }

        private void equal_click(object sender, EventArgs e)
        {
            string lastValue = txtResult.Text;

            int result = calc( int.Parse(firstNumber) , int.Parse(secondNumber) ,  opt);

            txtResult.Text = lastValue + Environment.NewLine + "=" +  Environment.NewLine+  result;
        }

        int calc(int num1 , int num2 , string opt)
        {
            switch(opt)
            {

                case "+":
                  return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                default:
                    return num1 / num2;
            }
        }

        private void clear_click(object sender, EventArgs e)
        {

             firstNumber = "";
             secondNumber = "";
             opt = "";
             txtResult.Text = "";
        }

        private void break_click(object sender, EventArgs e)
        {
            string lastValue = txtResult.Text;

            if (lastValue.Length > 0)
            {
                string newStr = lastValue.Substring(0, lastValue.Length - 1);

                txtResult.Text = newStr;
            }
               
        }
    }
}
