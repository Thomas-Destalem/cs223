using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class searchcs : Form
    {
        public searchcs()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           
            var product = Add.findOne(obj1.Text);
            if (product == null)
            {
                MessageBox.Show("product is not found");
            }
            else
                label1.Text = product.objname;
        }
    }
}
