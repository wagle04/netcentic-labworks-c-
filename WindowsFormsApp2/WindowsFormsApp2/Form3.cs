using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            openFileDialog1.Filter = "PNG(*.png)|*.png|jpg(*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            /*
            if (textBox1.Text=="")
            {

                errorProvider1.SetError(textBox1, "Please Enter a value");
            }

            else
            {
                errorProvider1.SetError(textBox1, "");
            }*/
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
