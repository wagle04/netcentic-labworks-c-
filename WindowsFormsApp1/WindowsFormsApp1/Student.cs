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
    public partial class Student : Form
    {
        int c;
        public Student(int c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            label1.Text = c.ToString();
        }
    }
}
