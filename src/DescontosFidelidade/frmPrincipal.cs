using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescontosFidelidade
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCliente { MdiParent = this };
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProduto { MdiParent = this };
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void lançarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmLancamento { MdiParent = this };
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
