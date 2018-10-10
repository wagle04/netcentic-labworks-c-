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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            /*List<string> lst = new List<string>();
            lst.Add("Select one");
            lst.Add("Nepal");
            lst.Add("UK");
            lst.Add("USA");
            cmdStudent.DataSource = lst;*/

            DataTable dt = new DataTable();
            dt.Columns.Add("roll");
            dt.Columns.Add("name");

            DataRow dr;
            for (int i = 0; i < 3; i++)
            {
                dr = dt.NewRow();
                dr["roll"] = i;
                dr["name"] = "Ram" + i;
                dt.Rows.Add(dr);
             
            }
            cmdStudent.DataSource = dt;
            cmdStudent.DisplayMember = "name";
            cmdStudent.ValueMember = "roll";
            //dt.Rows[0].ItemArray[0].ToString();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dataGridView1[0, 0].Value.ToString() + dataGridView1[1,0].Value.ToString());
            //dataGridView1.Columns[1].Visible = false;//donot show a column
            MessageBox.Show(dataGridView1.Rows.Count.ToString());
        }

    }
}
