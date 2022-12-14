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
    public partial class frmEliminaVendedor : Form
    {
        DAOVendedor objDAO = new DAOVendedor();
        public frmEliminaVendedor()
        {
            InitializeComponent();
            cboDistrito.DataSource = objDAO.listadoDistritos();
            cboDistrito.DisplayMember = "nom_dis";
            cboDistrito.ValueMember = "ide_dis";

            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            cboDistrito.Enabled = false;
            txtSueldo.Enabled = false;
            dtFecha.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                DataRow dr = objDAO.buscaVendedor(codigo).Rows[0];

                txtNombres.Text = dr[1].ToString();
                txtApellidos.Text = dr[2].ToString();
                txtSueldo.Text = dr[3].ToString();
                dtFecha.Value = DateTime.Parse(dr[4].ToString());
                cboDistrito.Text = dr[5].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vendedor NO existe..!!!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vendedor objV = new Vendedor()
            {
                ide_ven = int.Parse(txtCodigo.Text),
            };
            try
            {
                int n = objDAO.eliminaVendedor(objV);
                if (n == 1)
                    MessageBox.Show(n + " Registro de vendedor ELIMINADO");
                dgVendedores.DataSource = objDAO.listadoVendedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmEliminaVendedor_Load(object sender, EventArgs e)
        {
            dgVendedores.DataSource = objDAO.listadoVendedores();
        }

        private void dgVendedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int codigo = int.Parse(dgVendedores.CurrentRow.Cells[0].Value.ToString());

            DataRow dr = objDAO.buscaVendedor(codigo).Rows[0];
            txtCodigo.Text = dr[0].ToString();
            txtNombres.Text = dr[1].ToString();
            txtApellidos.Text = dr[2].ToString();
            txtSueldo.Text = dr[3].ToString();
            dtFecha.Value = DateTime.Parse(dr[4].ToString());
            cboDistrito.Text = dr[5].ToString();
        }
    }
}
