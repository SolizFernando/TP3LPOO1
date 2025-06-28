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
    public partial class frmPrincipal : Form
    {
        private Usuario usuarioActivo;
        public frmPrincipal()
        {
            InitializeComponent();
        }

         public frmPrincipal(ClasesBase.Usuario usu,string tipo) {

            InitializeComponent();
            usuarioActivo = usu;
            nomUsu.Text = usu.Usu_nombreUsuario;
            tipoUsu.Text= tipo;

            switch (tipo)
            {
                case "Administrador": 
                    navCliente.Visible = true;
                    break;
                case "Operador": 
                    navUsuario.Visible = false;
                    navDestino.Visible = false;
                    navPeriodo.Visible = false;
                    break;
                case "Auditor": 
                    break;
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCliente formCliente = new frmAltaCliente();
            formCliente.ShowDialog();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPeriodo formPeriodo = new frmAltaPeriodo();
            formPeriodo.ShowDialog();
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDestino formDestino = new frmAltaDestino();
            formDestino.ShowDialog();
        }

       

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estas seguro que quieres salir del sistema?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            frmABMUsuarios formABMUsuarios = new frmABMUsuarios(usuarioActivo);
            formABMUsuarios.ShowDialog();
        }

        public void verificar_login( string rolCodigo)
        {
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void navPrestamos_Click(object sender, EventArgs e)
        {
            FrmAltaPrestamo formPrestamo = new FrmAltaPrestamo();
            formPrestamo.ShowDialog();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagos formPagos = new FrmPagos();
            formPagos.ShowDialog();
        }

        private void historialDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagoPorCliente formPagCli = new frmPagoPorCliente();
            formPagCli.ShowDialog();
        }

    }
}
