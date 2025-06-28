using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
namespace Vistas
{
    public partial class frmPagoPorCliente : Form
    {
        public frmPagoPorCliente()
        {
            InitializeComponent();
        }

        private void frmPagoPorCliente_Load(object sender, EventArgs e)
        {
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "cli_dni";
            cmbClientes.DataSource = PagoABM.ListarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                string dni = cmbClientes.SelectedValue.ToString();
                dgvPagosCliente.DataSource = PagoABM.ListarPagosPorCliente(dni);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente.", "Aviso");
            }
        }
    }
}
