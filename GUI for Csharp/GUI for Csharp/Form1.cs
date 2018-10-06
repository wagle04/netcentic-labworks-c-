using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Summing;

namespace GUI_for_Csharp
{
    public partial class Form1 : Form
    {
        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b;
            if (txtFirstNumber.Text == "")
            {
                MessageBox.Show("Please Enter the first Number");
                txtFirstNumber.Focus();
                return;
            }
            if (txtSecondNumber.Text == "")
            {
                MessageBox.Show("Please Enter the second Number");
                txtSecondNumber.Focus();
                return;
            }
            a = Convert.ToInt32(txtFirstNumber.Text);
            b = Convert.ToInt32(txtSecondNumber.Text);
            Summing.sum obj = new Summing.sum();
            c = obj.add(a , b);
            txtResult.Text = Convert.ToString(c);
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
            txtResult.Text = "";
            txtFirstNumber.Focus();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
