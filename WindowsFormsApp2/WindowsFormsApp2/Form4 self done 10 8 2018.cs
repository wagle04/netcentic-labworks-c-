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
    public partial class form4 : Form
    {
        public form4()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student obj = new student();
            obj.MdiParent = this;
            obj.Show();
        }

        private void form4_Load(object sender, EventArgs e)
        {

        }
    }
}
