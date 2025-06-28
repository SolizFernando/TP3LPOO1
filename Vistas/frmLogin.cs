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
    public partial class frmLogin : Form
    {
       

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtUsuario.Text;
            string contrasena = txtContrasenia.Text;

            try
            {
                string rolCodigo = UsuarioABM.verificar_loginBD_sp(nombreUsuario, contrasena);

                DataTable dt = UsuarioABM.search_usuarios_sp(nombreUsuario);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Usuario usuario = new Usuario
                    {
                        Usu_id = Convert.ToInt32(row["usu_id"]),
                        Usu_nombreUsuario = row["Usuario"].ToString(),
                        Usu_contrasenia = row["Contraseña"].ToString(),
                        Usu_apellidoNombre = row["Apellido y Nombre"].ToString(),
                        Rol_codigo = row["rol_codigo"].ToString()
                    };

                    MessageBox.Show("Bienvenido de nuevo " + usuario.Usu_nombreUsuario, "Acceso al Sistema");
                    frmLogin.ActiveForm.Hide();
                    frmPrincipal principal = new frmPrincipal(usuario, UsuarioABM.get_rolDescripcion_sp(rolCodigo));
                    principal.Show();
                }
            }
            catch
            {
                MessageBox.Show("Acceso denegado. Verifique los datos colocados.");
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.Blue;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Font = new Font(btnIngresar.Font, FontStyle.Bold);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = SystemColors.Control;
            btnIngresar.ForeColor = SystemColors.ControlText;
            btnIngresar.Font = new Font(btnIngresar.Font, FontStyle.Regular);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
