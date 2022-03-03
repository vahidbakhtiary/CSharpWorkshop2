using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string name = txtFirstName.Text;

            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("name can't be empty");
                return;
            }

            string newText = "welcome " + name;
            lblResult.Text = newText;

            //Arrange  ==>ctrl + k + D

        }
    }
}
