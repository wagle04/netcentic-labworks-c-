using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a, b;
            if(txtFirstNumber.Text=="")
            {
                MessageBox.Show("Please Enter the first number");
                txtFirstNumber.Focus();
                return;
            }
            if(txtSecondNumber.Text=="")
            {
                MessageBox.Show("Please Enter the second number");
                txtSecondNumber.Focus();
                return;
            }
            a = Convert.ToInt32(txtFirstNumber.Text);
            b = Convert.ToInt32(txtSecondNumber.Text);
            Business.Sum obj = new Business.Sum();
            c = obj.add(a, b);
            txtResult.Text = c.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
            txtResult.Text = "";
            txtFirstNumber.Focus();
            txtResult.ReadOnly = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            Student obj = new Student(c);
            obj.ShowDialog();
        }

        private void lblFirstNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
