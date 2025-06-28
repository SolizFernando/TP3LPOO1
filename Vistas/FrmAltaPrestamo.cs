using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClasesBase;

namespace Vistas
{
    public partial class FrmAltaPrestamo : Form
    {
        public FrmAltaPrestamo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCantCuotas_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaPrestamo_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarDestinos();
            cargarPeriodos();
            cargarPrestamos();

            DataTable dt = PrestamoABM.ListarDestinos();
            DataRow row = dt.NewRow();
            row["des_codigo"] = 0;
            row["des_descripcion"] = "-- TODOS --";
            dt.Rows.InsertAt(row, 0);

            cmbDestinoBusqueda.DisplayMember = "des_descripcion";
            cmbDestinoBusqueda.ValueMember = "des_codigo";
            cmbDestinoBusqueda.DataSource = dt;

            // Fechas por defecto
            dtpDesde.Value = new DateTime(2000, 1, 1);
            dtpHasta.Value = DateTime.Today;

            dgvPrestamos.DataSource = PrestamoABM.ListarPrestamosFiltrados(0, dtpDesde.Value, dtpHasta.Value);

        }

        private void cargarClientes()
        {
            DataTable clientes = ClienteABM.list_clientes_sp();

 
            clientes.Columns.Add("nombre_completo", typeof(string), "cli_apellido + ', ' + cli_nombre");

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "nombre_completo";
            cmbCliente.ValueMember = "cli_dni";
        }

        private void cargarDestinos()
        {
            DataTable destinos = DestinoABM.list_destinos_sp();
            cmbDestino.DataSource = destinos;
            cmbDestino.DisplayMember = "des_descripcion";
            cmbDestino.ValueMember = "des_codigo";
        }

        private void cargarPeriodos()
        {
            DataTable periodos = PeriodoABM.list_periodos_sp();
            cmbPeriodo.DataSource = periodos;
            cmbPeriodo.DisplayMember = "per_descripcion";
            cmbPeriodo.ValueMember = "per_codigo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cuotas = int.Parse(txtCantidadCuotas.Text);
            decimal importe = decimal.Parse(txtImporte.Text);
            float tasa = float.Parse(txtTasa.Text);
            DateTime fecha = dtpFecha.Value;

            int desCodigo = (int)cmbDestino.SelectedValue;
            int perCodigo = (int)cmbPeriodo.SelectedValue;
            string cliDni = cmbCliente.SelectedValue.ToString();

            int preNumero = PrestamoABM.InsertarPrestamo(fecha, importe, tasa, cuotas, cliDni, desCodigo, perCodigo);

            decimal importeCuota = importe / cuotas;
            DateTime primerVencimiento = fecha.AddMonths(1);
            PrestamoABM.InsertarCuotas(preNumero, importeCuota, cuotas, primerVencimiento);

            DataTable dt = PrestamoABM.buscar_prestamo_por_numero(preNumero);
            if (dt.Rows.Count > 0)
            {
                dgvPrestamos.DataSource = dt;

                DataRow row = dt.Rows[0];
                MessageBox.Show("Préstamo guardado:\nCliente: " + row["Cliente"].ToString() +
                                "\nImporte: $" + row["pre_importe"].ToString());
            }
            limpiarCampos();
        }

        private void cargarPrestamos()
        {
            DataTable prestamos = PrestamoABM.listar_prestamos_sp();
            dgvPrestamos.DataSource = prestamos;
        }

        private void limpiarCampos()
        {
            txtImporte.Clear();
            txtTasa.Clear();
            txtCantidadCuotas.Clear();

            dtpFecha.Value = DateTime.Today;

            cmbCliente.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            cmbPeriodo.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codDestino = Convert.ToInt32(cmbDestinoBusqueda.SelectedValue);
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.", "Error");
                return;
            }

            dgvPrestamos.DataSource = PrestamoABM.ListarPrestamosFiltrados(codDestino, desde, hasta);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
