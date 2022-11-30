using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject1
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(
                @"Data Source= .\SQLEXPRESS;    
                Initial Catalog=bit3rdsem;
                user id=sa;
                password=kist@123;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select * from employee";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String[] row = new String[4];
            row[1] = textBox1.Text.ToString();
            row[2] = textBox2.Text.ToString();
            row[3] = textBox3.Text.ToString();
            dataGridView1.Rows.Add(row);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string address = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string salary = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Emloyee" +
                "            (name,address,salary)" +
                "           values('" +
                            textBox1.Text +
                            "','" + textBox2.Text +
                            "','" + textBox3.Text +
                            "')";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
