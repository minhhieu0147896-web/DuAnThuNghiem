using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmfornhvhc
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void báoQuânSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbqs f = new frmbqs();
            f.MdiParent = this;
            f.Show();
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLSQS f=new frmLSQS();
            f.MdiParent = this;
            f.Show();   

        }

        private void danhSáchQuânNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
