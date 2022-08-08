using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gui.models;

namespace gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mod m = new models.mod();
           m.number=Convert.ToInt32(num1.Text);
            m.date = Convert.ToDateTime(date1.Text);
            m.inventory = Convert.ToInt32(inv1.Text);
            m.objectname = obj1.Text;
            m.count = Convert.ToInt32(c1.Text);
            m.price = Convert.ToInt32(p1.Text);
            MessageBox.Show(m.save());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
