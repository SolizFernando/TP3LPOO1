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
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            CargarClientes();
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            cmbPrestamos.SelectedIndexChanged += cmbPrestamos_SelectedIndexChanged;
            cmbCuotas.SelectedIndexChanged += cmbCuotas_SelectedIndexChanged;
            //this.cuotaTableAdapter.Fill(this.prestamosDataSet1.Cuota);

        }
        private void CargarClientes()
        {
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "cli_dni";
            cmbClientes.DataSource = PagoABM.ListarClientes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                string dni = cmbClientes.SelectedValue.ToString();
                cmbPrestamos.DisplayMember = "pre_numero";
                cmbPrestamos.ValueMember = "pre_numero";
                cmbPrestamos.DataSource = PagoABM.ListarPrestamosPendientes(dni);
            }
        }

        private void cmbPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrestamos.SelectedValue != null)
            {
                int preNum = Convert.ToInt32(cmbPrestamos.SelectedValue);
                DataTable dtCuotas = PagoABM.ListarCuotasPendientes(preNum);
                dgvCuotasPendientes.DataSource = dtCuotas;

                cmbCuotas.DisplayMember = "cuo_numero"; // o "cuo_codigo"
                cmbCuotas.ValueMember = "cuo_codigo";
                cmbCuotas.DataSource = dtCuotas;

                if (dtCuotas.Rows.Count == 0)
                {
                    MessageBox.Show("Este préstamo no tiene cuotas pendientes.");
                }
            }
        }

        private void cmbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCuotas.SelectedIndex!=1){
                DataRowView row = (DataRowView)cmbCuotas.SelectedItem;
                txtImporte.Text = row["cuo_importe"].ToString();
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (cmbCuotas.SelectedValue != null)
            {
                decimal importe;
                if (decimal.TryParse(txtImporte.Text, out importe))
                {
                    int cuoCodigo = Convert.ToInt32(cmbCuotas.SelectedValue);
                    DateTime fechaPago = dtpFechaPago.Value;

                    PagoABM.RegistrarPago(cuoCodigo, fechaPago, importe);

                    MessageBox.Show("Pago registrado con éxito.", "Confirmación");

                    int preNum = Convert.ToInt32(cmbPrestamos.SelectedValue);
                    dgvCuotasPendientes.DataSource = PagoABM.ListarCuotasPendientes(preNum);
                    txtImporte.Clear();
                }
                else
                {
                    MessageBox.Show("El importe ingresado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cuota válida.");
            }




        }

    }
}
