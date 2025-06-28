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
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void load_clientes()
        {
            dgvClientes.DataSource = ClienteABM.list_clientes_sp();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cli_dni = txtDni.Text;
            cliente.Cli_apellido = txtApellido.Text;
            cliente.Cli_nombre = txtNombre.Text;
            cliente.Cli_direccion = txtDireccion.Text;
            cliente.Cli_sexo = comboBoxSexo.Text;
            cliente.Cli_fechaNacimiento = dtpFechaNacimiento.Value;
            cliente.Cli_ingresos = nudIngresos.Value;
            cliente.Cli_telefono = txtTelefono.Text;


            if (String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtApellido.Text) ||
        String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text) ||
        String.IsNullOrEmpty(comboBoxSexo.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo cliente", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var respuesta = MessageBox.Show("¿Está seguro que desea registrar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (ClienteABM.search_dni_sp(cliente.Cli_dni) == true)
                    {
                        ClienteABM.insert_cliente_sp(cliente);
                        load_clientes();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente registrado con el DNI aplicado", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        private void load_combo_sexo()
        {
            var listaSexo = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("F", "Femenino"),
                new KeyValuePair<string, string>("M", "Masculino")
            };

            comboBoxSexo.DisplayMember = "Value";
            comboBoxSexo.ValueMember = "Key";     
            comboBoxSexo.DataSource = listaSexo; 
        }


        private void FormAddCliente_Load(object sender, EventArgs e)
        {
            load_clientes();
            load_combo_sexo();

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length < 7 || txtTelefono.Text.Length > 15 || verificarNoTengaLetras(txtTelefono.Text))
            {
                MessageBox.Show("El número de telefono debe tener de 7 a 15 numeros", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Clear();
                txtTelefono.Focus();
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (verificarNoTengaDigitos(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede contener dígitos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Clear();
                txtNombre.Focus();
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (verificarNoTengaDigitos(txtApellido.Text))
            {
                MessageBox.Show("El apellido no puede contener dígitos", "Validación",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Clear(); 
                txtApellido.Focus(); 
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (verificarNoTengaLetras(txtDni.Text))
            {
                MessageBox.Show("El DNI solo puede contener dígitos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDni.Clear();
                txtDni.Focus();
            }
        }

        private bool verificarNoTengaDigitos(string cadena)
        {
            return cadena.Any(char.IsDigit);
        }

        private bool verificarNoTengaLetras(string cadena)
        {
            return cadena.Any(char.IsLetter);
        }

        private void limpiarCampos()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            comboBoxSexo.SelectedIndex = -1;
            nudIngresos.Value = 0.00m;
            txtDireccion.Clear();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            if ((String.IsNullOrEmpty(txtDniSearch.Text)) || (String.IsNullOrEmpty(txtTelefonoSearch.Text)))
            {
                load_clientes();
            }
            else
            {
                dgvClientes.DataSource = ClienteABM.search_clientes_sp(txtDniSearch.Text, txtTelefonoSearch.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ClienteABM.delete_cliente_sp(txtDni.Text);
                MessageBox.Show("Datos del cliente eliminados exitosamente", "Eliminacion exitosa");
                load_clientes();
                txtId.Text = null;
                txtDni.Text = null;
                txtApellido.Text = null;
                txtNombre.Text = null;
                txtDireccion.Text = null;
                comboBoxSexo.Text = null;
                dtpFechaNacimiento.Text = null;
                nudIngresos.Text = null;
                txtTelefono.Text = null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un cliente antes de realizar una modificacion", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Cli_dni = txtDni.Text;
                cliente.Cli_apellido = txtApellido.Text;
                cliente.Cli_nombre = txtNombre.Text;
                cliente.Cli_direccion = txtDireccion.Text;
                cliente.Cli_sexo = comboBoxSexo.Text;
                cliente.Cli_fechaNacimiento = dtpFechaNacimiento.Value;
                cliente.Cli_ingresos = nudIngresos.Value;
                cliente.Cli_telefono = txtTelefono.Text;

                if (String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de modificar un cliente", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        try
                        {
                            ClienteABM.modify_cliente_sp(cliente);
                            MessageBox.Show("Datos modificados exitosamente");
                            load_clientes();
                        }
                        catch
                        {
                            MessageBox.Show("Ya existe un cliente registrado con el DNI a modificar", "Errror al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void dgvClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.Cells["cli_dni"].Value != DBNull.Value)
            {
                txtId.Text = dgvClientes.CurrentRow.Cells["cli_dni"].Value.ToString();
                txtDni.Text = dgvClientes.CurrentRow.Cells["cli_dni"].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["cli_apellido"].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells["cli_nombre"].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells["cli_direccion"].Value.ToString();
                comboBoxSexo.Text = dgvClientes.CurrentRow.Cells["cli_sexo"].Value.ToString();

                
                DateTime fechaNac;
                if (DateTime.TryParse(dgvClientes.CurrentRow.Cells["cli_fechaNacimiento"].Value.ToString(), out fechaNac))
                {
                    dtpFechaNacimiento.Value = fechaNac;
                }

                decimal ingresos;
                if (decimal.TryParse(dgvClientes.CurrentRow.Cells["cli_ingresos"].Value.ToString(), out ingresos))
                {
                    nudIngresos.Value = ingresos;
                }

                txtTelefono.Text = dgvClientes.CurrentRow.Cells["cli_telefono"].Value.ToString();
            }
        }


      
    }
}
