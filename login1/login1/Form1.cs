using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string u = textBox1.Text;
            string p = textBox2.Text;
            if(u == "thomas" && p == "ig31")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("incorrect");
            }
        }
    }
}
