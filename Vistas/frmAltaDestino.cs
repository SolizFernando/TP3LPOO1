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
    public partial class frmAltaDestino : Form
    {
        public frmAltaDestino()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea guardar los datos del destino?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                string descripcion = txtDescripcion.Text.Trim();
                if (DestinoABM.ExisteDestino(descripcion))
                {
                    MessageBox.Show("Ya existe un destino conesa descripcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DestinoABM.InsertarDestino(descripcion);
                MessageBox.Show(
                    "Destino creado:\n\nDescripción: " + txtDescripcion.Text,
                    "Destino creado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                limpiarCampos();
                LoadDestinos();
            }

        }

        private void limpiarCampos()
        {
            txtDescripcion.Clear();
            numericUpDownCod.Value = 0;
        }

        private void frmAltaDestino_Load(object sender, EventArgs e)
        {
            LoadDestinos();
            dgvDestinos.CurrentCellChanged += dgvDestinos_CurrentCellChanged;

        }

        private void LoadDestinos(){
            dgvDestinos.DataSource = DestinoABM.list_destinos_sp();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (numericUpDownCod.Value == 0 || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe seleccionar un destino para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea modificar los datos del destino?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                int codigo = (int)numericUpDownCod.Value;
                string descripcion = txtDescripcion.Text.Trim();
                if (DestinoABM.ExisteDestinoExcepto(descripcion,codigo)) {
                    MessageBox.Show("Ya existe otro destinocon esa descripcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DestinoABM.ModificarDestino(codigo, descripcion);

                MessageBox.Show(
                    "Destino modificado:\n\nCódigo: " + codigo + "\nDescripción: " + descripcion,
                    "Modificación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                limpiarCampos();
                LoadDestinos();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (numericUpDownCod.Value == 0)
            {
                MessageBox.Show("Debe seleccionar un destino para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea eliminar este destino?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                int codigo = (int)numericUpDownCod.Value;
                DestinoABM.EliminarDestino(codigo);

                MessageBox.Show(
                    "Destino eliminado exitosamente.",
                    "Eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                limpiarCampos();
                LoadDestinos();
            }

        }

        private void dgvDestinos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvDestinos.CurrentRow != null &&
              dgvDestinos.Columns.Contains("des_codigo") &&
              dgvDestinos.CurrentRow.Cells["des_codigo"].Value != DBNull.Value)
            {
                numericUpDownCod.Value = Convert.ToInt32(dgvDestinos.CurrentRow.Cells["des_codigo"].Value);
                txtDescripcion.Text = dgvDestinos.CurrentRow.Cells["des_descripcion"].Value.ToString();
            }



        }
    }
}
