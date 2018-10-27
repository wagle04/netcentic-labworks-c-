using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            string connstr = "Data Source=LAPTOP-4NU18DVA;Initial Catalog=test;UID=sa;pwd=sql";
            SqlConnection con = new SqlConnection(connstr);
            string sql = "select * from tblStudent where roll=@roll";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@roll", 1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            */
           

        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            string connstr = "Data Source=LAPTOP-4NU18DVA;Initial Catalog=test;UID=sa;pwd=sql";
            SqlConnection con = new SqlConnection(connstr);
            string sql = "select * from tblTest1 where roll=" + textBox1.Text;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        */}

        private void button3_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=LAPTOP-4NU18DVA;Initial Catalog=test;UID=sa;pwd=sql";
            SqlConnection con = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insEmployee";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ename", "nehu");
            cmd.Parameters.AddWithValue("@age", 21);
            cmd.Parameters.AddWithValue("@salary", 40000);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlTransaction trans=null;
            SqlConnection con = null;
            SqlCommand cmd = null;
            string connstr = "Data Source=LAPTOP-4NU18DVA;Initial Catalog=test;UID=sa;pwd=sql";
            string sql1, sql2;
            try
            {
                con = new SqlConnection(connstr);
                sql1 = "update tblAccount set amount=amount-1000 where account_no=1";
                sql2 = "update tblAccounts set amount=amount+1000 where account_no=2";

                con.Open();
                trans = con.BeginTransaction();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql1;
                cmd.Connection = con;
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql2;
                cmd.Connection = con;
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();
                trans.Commit();
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
                trans.Rollback();
            }

        }
    }
}
