using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist2
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f11)
        {
            InitializeComponent();
            f1 = f11; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.dataGridView1.Rows.Add(textBox1.Text,textBox2.Text);
        }
    }
}
