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
    public partial class form_5 : Form
    {
        public form_5()
        {
            InitializeComponent();
        }

        private void form_5_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*label1.Text = DateTime.Now.ToLongTimeString();
            label1.Left = label1.Left + 10;
            if (label1.Left > this.Width)
            {
                label1.Left = 0;
            }*/
            label2.Text = "This is St. Xavier's College";
            label2.Left = label2.Left + 10;
            if (label2.Left > this.Width)
            {
                label2.Left = 0;
                timer1.Stop();
                timer2.Start();
                label2.Enabled = false;
                label3.Enabled = true;
                label2.Text = "";
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = "This is TU affilated college";
            label3.Left = label3.Left + 10;
            if (label3.Left > this.Width)
            {
                label3.Left = 0;
                timer2.Stop();
                timer1.Start();
                label2.Enabled = false;
                label1.Enabled = true;
                label3.Text = "";
            }
        }
    }
}
