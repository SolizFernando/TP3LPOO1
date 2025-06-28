using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmABMUsuarios : Form
    {
        private Usuario usuarioLogueado;
        public frmABMUsuarios(ClasesBase.Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                ClasesBase.Usuario oUser = new ClasesBase.Usuario();
         
                oUser.Rol_codigo = cmbRol.SelectedValue.ToString();
                oUser.Usu_apellidoNombre = txtApellidoNombre.Text;
                oUser.Usu_nombreUsuario = txtUserName.Text;
                oUser.Usu_contrasenia = txtPassword.Text;

                if (String.IsNullOrEmpty(cmbRol.Text) || String.IsNullOrEmpty(txtApellidoNombre.Text) || String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo usuario", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea registrar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (UsuarioABM.search_username_sp(oUser.Usu_nombreUsuario) == true)
                        {
                            UsuarioABM.insert_usuario_sp(oUser);
                            load_usuarios();
                            cmbRol.Text = null;
                            txtApellidoNombre.Text = null;
                            txtUserName.Text = null;
                            txtPassword.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un usuario con el username aplicado", "Errror al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo usuario", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                UsuarioABM.delete_usuario_sp(txtId.Text);
                MessageBox.Show("Datos del usuario eliminados exitosamente", "Aviso");
                load_usuarios();
                txtId.Text = null;
                txtRolCodigo.Text = null;
                cmbRol.Text = null;
                txtUserName.Text = null;
                txtPassword.Text = null;
                txtApellidoNombre.Text = null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un usuario antes de realizar una modificacion", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               ClasesBase.Usuario usuario = new ClasesBase.Usuario();
                usuario.Usu_id = Int32.Parse(txtId.Text);
                usuario.Rol_codigo = cmbRol.SelectedValue.ToString();
                usuario.Usu_nombreUsuario = txtUserName.Text;
                usuario.Usu_contrasenia = txtPassword.Text;
                usuario.Usu_apellidoNombre = txtApellidoNombre.Text;

                if (String.IsNullOrEmpty(cmbRol.Text) || String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtApellidoNombre.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de modificar un usuario", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (UsuarioABM.get_id_usuario_sp(usuario.Usu_nombreUsuario).Equals(txtId.Text) || (UsuarioABM.get_id_usuario_sp(usuario.Usu_nombreUsuario).Equals("null")))
                        {
                            UsuarioABM.modify_usuario_sp(usuario);
                            MessageBox.Show("Datos modificados exitosamente", "Aviso");
                            load_usuarios();
                        }
                        else
                        {
                            MessageBox.Show("No puede modificar y aplicar el nuevo username, ya se encuentra registrado", "Errror al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
            }
        }


        private void load_combo_roles()
        {
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = UsuarioABM.list_roles_sp();
        }

        private void load_usuarios()
        {
            dgwUsuarios.DataSource = UsuarioABM.list_usuarios_ordenados_sp("apellido");
        }

        private void frmABMUsuarios_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();

            if (usuarioLogueado != null)
            {
                txtId.Text = usuarioLogueado.Usu_id.ToString();
                txtUserName.Text = usuarioLogueado.Usu_nombreUsuario;
                txtPassword.Text = usuarioLogueado.Usu_contrasenia;
                txtApellidoNombre.Text = usuarioLogueado.Usu_apellidoNombre;
                cmbRol.SelectedValue = usuarioLogueado.Rol_codigo;
            }
        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.CurrentRow != null)
            {
                if (dgwUsuarios.CurrentRow.Cells["rol_codigo"].Value.ToString().Equals(""))
                {
                    cmbRol.SelectedValue = 1;
                }
                else
                {
                    cmbRol.SelectedValue = dgwUsuarios.CurrentRow.Cells["rol_codigo"].Value.ToString();
                }
                txtId.Text = dgwUsuarios.CurrentRow.Cells["usu_id"].Value.ToString();
                txtUserName.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtApellidoNombre.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
            }
        }

       /* private void btnRegresar_Click(object sender, EventArgs e)
        {
            AltaUsuario.ActiveForm.Hide();
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        } */

        private void BotonGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {

                ClasesBase.Usuario oUser = new ClasesBase.Usuario();
                oUser.Rol_codigo = cmbRol.SelectedValue.ToString();
                oUser.Usu_apellidoNombre = txtApellidoNombre.Text;
                oUser.Usu_nombreUsuario = txtUserName.Text;
                oUser.Usu_contrasenia = txtPassword.Text;

                if (String.IsNullOrEmpty(cmbRol.Text) || String.IsNullOrEmpty(txtApellidoNombre.Text) || String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo usuario", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea registrar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (UsuarioABM.search_username_sp(oUser.Usu_nombreUsuario) == true)
                        {
                            UsuarioABM.insert_usuario_sp(oUser);
                            load_usuarios();
                            cmbRol.Text = null;
                            txtApellidoNombre.Text = null;
                            txtUserName.Text = null;
                            txtPassword.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un usuario con el username aplicado", "Errror al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo usuario", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

     

        private void dgwUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string texto = txtUsuarioSearch.Text.Trim();
            if (!string.IsNullOrEmpty(texto))
            {
                var dt = UsuarioABM.search_usuarios_sp(texto);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios que coincidan con el criterio.");
                }
                else
                {
                    dgwUsuarios.DataSource = dt;

                    // Cargar el primer resultado en los campos del formulario:
                    DataRow row = dt.Rows[0];
                    txtId.Text = row["usu_id"].ToString();
                    txtUserName.Text = row["Usuario"].ToString();
                    txtPassword.Text = row["Contraseña"].ToString();
                    txtApellidoNombre.Text = row["Apellido y Nombre"].ToString();
                    cmbRol.SelectedValue = row["rol_codigo"].ToString();
                }
            }
            else
            {
                load_usuarios();
            }
        }

        private void btbOrdenar_Click(object sender, EventArgs e)
        {
            string criterio = "";

            if (rbUsuario.Checked)
                criterio = "usuario";
            else if (rbApellido.Checked)
                criterio = "apellido";
            else
            {
                MessageBox.Show("Seleccioná un criterio de ordenamiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgwUsuarios.DataSource = UsuarioABM.list_usuarios_ordenados_sp(criterio);

        }
    
        
    }
}
