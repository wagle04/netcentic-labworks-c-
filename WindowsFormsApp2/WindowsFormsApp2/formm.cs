using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formm : Form
    {
        public formm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Substring(2, 4);
            textBox2.Text = s;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string path = openFileDialog1.FileName;
            int s = path.LastIndexOf("\\");
            string photo = path.Substring(s + 1);
            pictureBox1.Image = Image.FromFile.Copy(Application.StartupPath + "\\Images\\" + photo);
        }*/

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int s = path.LastIndexOf("\\");
                string photo = path.Substring(s + 1);
                File.Copy(path, Application.StartupPath + "\\Images\\" + photo, true);

                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + photo);
            }
        }
    }
}
