namespace Vistas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.navPeriodo = new System.Windows.Forms.ToolStripMenuItem();
            this.navDestino = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoUsu = new System.Windows.Forms.Label();
            this.nomUsu = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navCliente
            // 
            this.navCliente.Name = "navCliente";
            this.navCliente.Size = new System.Drawing.Size(61, 20);
            this.navCliente.Text = "Clientes";
            this.navCliente.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // navPeriodo
            // 
            this.navPeriodo.Name = "navPeriodo";
            this.navPeriodo.Size = new System.Drawing.Size(65, 20);
            this.navPeriodo.Text = "Periodos";
            this.navPeriodo.Click += new System.EventHandler(this.periodosToolStripMenuItem_Click);
            // 
            // navDestino
            // 
            this.navDestino.Name = "navDestino";
            this.navDestino.Size = new System.Drawing.Size(64, 20);
            this.navDestino.Text = "Destinos";
            this.navDestino.Click += new System.EventHandler(this.destinosToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // navUsuario
            // 
            this.navUsuario.Name = "navUsuario";
            this.navUsuario.Size = new System.Drawing.Size(64, 20);
            this.navUsuario.Text = "Usuarios";
            this.navUsuario.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navCliente,
            this.navPeriodo,
            this.navDestino,
            this.navUsuario,
            this.navPrestamos,
            this.pagosToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // navPrestamos
            // 
            this.navPrestamos.Name = "navPrestamos";
            this.navPrestamos.Size = new System.Drawing.Size(74, 20);
            this.navPrestamos.Text = "Préstamos";
            this.navPrestamos.Click += new System.EventHandler(this.navPrestamos_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPagosToolStripMenuItem,
            this.historialDePagoToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // registrarPagosToolStripMenuItem
            // 
            this.registrarPagosToolStripMenuItem.Name = "registrarPagosToolStripMenuItem";
            this.registrarPagosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registrarPagosToolStripMenuItem.Text = "Registrar pagos";
            this.registrarPagosToolStripMenuItem.Click += new System.EventHandler(this.registrarPagosToolStripMenuItem_Click);
            // 
            // historialDePagoToolStripMenuItem
            // 
            this.historialDePagoToolStripMenuItem.Name = "historialDePagoToolStripMenuItem";
            this.historialDePagoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.historialDePagoToolStripMenuItem.Text = "Historial de pago";
            this.historialDePagoToolStripMenuItem.Click += new System.EventHandler(this.historialDePagoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoUsu);
            this.groupBox1.Controls.Add(this.nomUsu);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(133, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenido";
            // 
            // tipoUsu
            // 
            this.tipoUsu.AutoSize = true;
            this.tipoUsu.Location = new System.Drawing.Point(60, 89);
            this.tipoUsu.Name = "tipoUsu";
            this.tipoUsu.Size = new System.Drawing.Size(0, 13);
            this.tipoUsu.TabIndex = 3;
            // 
            // nomUsu
            // 
            this.nomUsu.AutoSize = true;
            this.nomUsu.Location = new System.Drawing.Point(83, 40);
            this.nomUsu.Name = "nomUsu";
            this.nomUsu.Size = new System.Drawing.Size(0, 13);
            this.nomUsu.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(28, 89);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem navCliente;
        private System.Windows.Forms.ToolStripMenuItem navPeriodo;
        private System.Windows.Forms.ToolStripMenuItem navDestino;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label tipoUsu;
        private System.Windows.Forms.Label nomUsu;
        private System.Windows.Forms.ToolStripMenuItem navPrestamos;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePagoToolStripMenuItem;

    }
}