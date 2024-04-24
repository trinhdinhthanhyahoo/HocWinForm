using ClassPTBac1a;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HocWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            PTB1 pt = NhapPT();
            try
            {
                label3.Text = pt.Giai().ToString();

            }
            catch (Exception ex)
            {

                label3.Text = ex.Message;
            }
        }

        private PTB1 NhapPT()
        {
            double a, b;

            if(double.TryParse(txtSoA.Text, out a) == false)
            {
                txtSoA.Focus();
            }
            if (double.TryParse(txtSoB.Text, out b) == false)
            {
                txtSoB.Focus();
            }
            return new PTB1()
            {
                soA = a,
                soB = b,
            };
        }
    }
}
