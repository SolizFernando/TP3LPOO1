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
    public partial class frmAltaPeriodo : Form
    {
        public frmAltaPeriodo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea guardar los datos del periodo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Periodo periodoNuevo = new Periodo((int)numericUpDownCod.Value, txtDescripcion.Text);
                MessageBox.Show(
                    "Periodo creado:\n\n" +
                    "Descripcion: " + periodoNuevo.Per_descripcion,
                    "Periodo creado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                limpiarCampos();
            }
        }

        private void limpiarCampos()
        {
            txtDescripcion.Clear();
            numericUpDownCod.Value = 0;
        }

        private void frmAltaPeriodo_Load(object sender, EventArgs e)
        {

        }
    }
}
