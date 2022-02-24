using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1.Alghoritm;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int varInt = 10;
            long varLong = 10l;
            float varFloat = 10.5f;
            double varDouble = 10.5;
            char varChar = 'A';
            string varStr = "ALI";
            bool varBool = true;
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 10;
            int sum = num1 + num2;

            // Console.WriteLine(sum);
            MessageBox.Show(sum.ToString());
        }
    }
}
