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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            DialogResult res =  MessageBox.Show(this,"Are you Sure","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(res==DialogResult.Yes)
            {
                MessageBox.Show("Delete success");
            }
            if(res==DialogResult.No)
            {
                MessageBox.Show("Cancel");
            }
            */

            if(comboBox1.SelectedIndex==0)
            {

                MessageBox.Show("Please select the item");

                
            }

            else
            {

                MessageBox.Show(comboBox1.SelectedItem.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Select One...");
            comboBox1.Items.Add("Nepal");
            comboBox1.Items.Add("USA");
            comboBox1.Items.Add("UK");

            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if(rdoMale.Checked==true)
            {
                MessageBox.Show(rdoMale.Text);
            }
            if(rdoFemale.Checked==true)
            {
                MessageBox.Show(rdoFemale.Text);
            }
            */

            groupBox1.Enabled = false;

        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Visible = false;
            dateTimePicker1.Enabled = false;
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }
    }
}
