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

namespace sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "data source=.\\SQLSERVER ; database=test0; integrated security=true";
            using(sqlconnection con=new sqlconnection(cs))
            {
                string q = "select * from Accounting";
                con.open();
                sqlDataAdapter d = new sqlDataAdapter(q, con); 
                DataTable dt = new DataTable();
                d.Fill(dt);
                dataGridView1.Datasource = dt;
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "data source=.\\SQLSERVER ; database=test0; integrated security=true";
            using (sqlconnection con = new sqlconnection(cs))
            {
                string q = "insert into customers values('abebe','kebede''2000-03-4,2500)";
                con.open();
                sqlCommand sqlCommand = new sqlCommand(q, con);
                var result = sqlCommand.ExecuteNonQuery();
                var read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    string name = read[1].ToString();
                    MessageBox.Show(name);

                }
            }
        }
    }
}
