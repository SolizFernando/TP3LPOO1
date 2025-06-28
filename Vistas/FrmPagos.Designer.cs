namespace Vistas
{
    partial class FrmPagos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCuotasPendientes = new System.Windows.Forms.DataGridView();
            this.prestamosDataSet1 = new Vistas.prestamosDataSet1();
            this.cuotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuotaTableAdapter = new Vistas.prestamosDataSet1TableAdapters.CuotaTableAdapter();
            this.cuocodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuonumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuovencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuoimporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuoestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbPrestamos = new System.Windows.Forms.ComboBox();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuotras pendientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Préstamo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // dgvCuotasPendientes
            // 
            this.dgvCuotasPendientes.AutoGenerateColumns = false;
            this.dgvCuotasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuocodigoDataGridViewTextBoxColumn,
            this.prenumeroDataGridViewTextBoxColumn,
            this.cuonumeroDataGridViewTextBoxColumn,
            this.cuovencimientoDataGridViewTextBoxColumn,
            this.cuoimporteDataGridViewTextBoxColumn,
            this.cuoestadoDataGridViewTextBoxColumn});
            this.dgvCuotasPendientes.DataSource = this.cuotaBindingSource;
            this.dgvCuotasPendientes.Location = new System.Drawing.Point(32, 136);
            this.dgvCuotasPendientes.Name = "dgvCuotasPendientes";
            this.dgvCuotasPendientes.Size = new System.Drawing.Size(642, 150);
            this.dgvCuotasPendientes.TabIndex = 4;
            // 
            // prestamosDataSet1
            // 
            this.prestamosDataSet1.DataSetName = "prestamosDataSet1";
            this.prestamosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuotaBindingSource
            // 
            this.cuotaBindingSource.DataMember = "Cuota";
            this.cuotaBindingSource.DataSource = this.prestamosDataSet1;
            // 
            // cuotaTableAdapter
            // 
            this.cuotaTableAdapter.ClearBeforeFill = true;
            // 
            // cuocodigoDataGridViewTextBoxColumn
            // 
            this.cuocodigoDataGridViewTextBoxColumn.DataPropertyName = "cuo_codigo";
            this.cuocodigoDataGridViewTextBoxColumn.HeaderText = "cuo_codigo";
            this.cuocodigoDataGridViewTextBoxColumn.Name = "cuocodigoDataGridViewTextBoxColumn";
            this.cuocodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeroDataGridViewTextBoxColumn
            // 
            this.prenumeroDataGridViewTextBoxColumn.DataPropertyName = "pre_numero";
            this.prenumeroDataGridViewTextBoxColumn.HeaderText = "pre_numero";
            this.prenumeroDataGridViewTextBoxColumn.Name = "prenumeroDataGridViewTextBoxColumn";
            // 
            // cuonumeroDataGridViewTextBoxColumn
            // 
            this.cuonumeroDataGridViewTextBoxColumn.DataPropertyName = "cuo_numero";
            this.cuonumeroDataGridViewTextBoxColumn.HeaderText = "cuo_numero";
            this.cuonumeroDataGridViewTextBoxColumn.Name = "cuonumeroDataGridViewTextBoxColumn";
            // 
            // cuovencimientoDataGridViewTextBoxColumn
            // 
            this.cuovencimientoDataGridViewTextBoxColumn.DataPropertyName = "cuo_vencimiento";
            this.cuovencimientoDataGridViewTextBoxColumn.HeaderText = "cuo_vencimiento";
            this.cuovencimientoDataGridViewTextBoxColumn.Name = "cuovencimientoDataGridViewTextBoxColumn";
            // 
            // cuoimporteDataGridViewTextBoxColumn
            // 
            this.cuoimporteDataGridViewTextBoxColumn.DataPropertyName = "cuo_importe";
            this.cuoimporteDataGridViewTextBoxColumn.HeaderText = "cuo_importe";
            this.cuoimporteDataGridViewTextBoxColumn.Name = "cuoimporteDataGridViewTextBoxColumn";
            // 
            // cuoestadoDataGridViewTextBoxColumn
            // 
            this.cuoestadoDataGridViewTextBoxColumn.DataPropertyName = "cuo_estado";
            this.cuoestadoDataGridViewTextBoxColumn.HeaderText = "cuo_estado";
            this.cuoestadoDataGridViewTextBoxColumn.Name = "cuoestadoDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seleccionar cuota:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Importe";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(305, 382);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(105, 23);
            this.btnRegistrarPago.TabIndex = 7;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(131, 30);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 8;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(131, 56);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 9;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // cmbPrestamos
            // 
            this.cmbPrestamos.FormattingEnabled = true;
            this.cmbPrestamos.Location = new System.Drawing.Point(131, 83);
            this.cmbPrestamos.Name = "cmbPrestamos";
            this.cmbPrestamos.Size = new System.Drawing.Size(121, 21);
            this.cmbPrestamos.TabIndex = 10;
            this.cmbPrestamos.SelectedIndexChanged += new System.EventHandler(this.cmbPrestamos_SelectedIndexChanged);
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Location = new System.Drawing.Point(131, 306);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(121, 21);
            this.cmbCuotas.TabIndex = 11;
            this.cmbCuotas.SelectedIndexChanged += new System.EventHandler(this.cmbCuotas_SelectedIndexChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(131, 336);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 20);
            this.txtImporte.TabIndex = 12;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 446);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.cmbCuotas);
            this.Controls.Add(this.cmbPrestamos);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCuotasPendientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCuotasPendientes;
        private prestamosDataSet1 prestamosDataSet1;
        private System.Windows.Forms.BindingSource cuotaBindingSource;
        private prestamosDataSet1TableAdapters.CuotaTableAdapter cuotaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuocodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuonumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuovencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuoimporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuoestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbPrestamos;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.TextBox txtImporte;
    }
}