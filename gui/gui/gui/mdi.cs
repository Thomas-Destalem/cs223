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
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if(activescreen != null)
            {
                activescreen.Close();
            }
            Form1 form1 = new Form1();  
            form1.MdiParent = this;
            form1.Show();
        }
        display d = new display();
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.MdiParent = this;
            d.Show();
        }
        searchcs s=new searchcs();
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.MdiParent=this;
            s.Show();
        }
    }
}
