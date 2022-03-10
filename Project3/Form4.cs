using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ChkDiplom_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("checked change");
        }

        //private void ChkMS_CheckedChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("checked change");
        //}

        //private void ChkPHD_CheckedChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("checked change");
        //}

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool isCheckDiplom = chkDiplom.Checked;
            if(isCheckDiplom )
            {
                MessageBox.Show("Diplom is checked");
            }

            bool isCheckMS = chkMS.Checked;
            if (isCheckMS)
            {
                MessageBox.Show("Master is checked");
            }

            bool isCheckPHD = chkPHD.Checked;
            if (isCheckPHD)
            {
                MessageBox.Show("PHD is checked");
            }

            bool isCheckMale = rdMale.Checked;
            if (isCheckMale)
            {
                MessageBox.Show("Male is checked");
            }

            bool isCheckFemale = rdFemale.Checked;
            if (isCheckFemale)
            {
                MessageBox.Show("Female is checked");
            }
        }

        private void RdMale_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheckMale = rdMale.Checked;
            if (isCheckMale)
            {
                MessageBox.Show("check is change");
            }
            
        }

        private void RdFemale_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheckFemale = rdFemale.Checked;
            if(isCheckFemale)
            {
                MessageBox.Show("check is change");
            }
            
        }
    }
}
