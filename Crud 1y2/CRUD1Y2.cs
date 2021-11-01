using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCRUD
{
    public partial class Citaa : Form
    {
        public Citaa()
        {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRO form = new REGISTRO();
            form.MdiParent = this;
            form.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
