using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjLaboratorio06_T3SN
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmNuevoVendedor childForm = new frmNuevoVendedor();
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void actualizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmActualizaVendedor childForm = new frmActualizaVendedor();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmEliminaVendedor childForm = new frmEliminaVendedor();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmListadoVendedores childForm = new frmListadoVendedores();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmBuscaVendedor childForm = new frmBuscaVendedor();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
