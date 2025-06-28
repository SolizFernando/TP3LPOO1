namespace Vistas
{
    partial class frmAltaDestino
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.numericUpDownCod = new System.Windows.Forms.NumericUpDown();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDestinos = new System.Windows.Forms.DataGridView();
            this.descodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet = new Vistas.prestamosDataSet();
            this.destinoTableAdapter = new Vistas.prestamosDataSetTableAdapters.DestinoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(57, 151);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(57, 113);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(276, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(54, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(54, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            // 
            // numericUpDownCod
            // 
            this.numericUpDownCod.Location = new System.Drawing.Point(57, 64);
            this.numericUpDownCod.Name = "numericUpDownCod";
            this.numericUpDownCod.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownCod.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(151, 151);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 36);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(245, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvDestinos
            // 
            this.dgvDestinos.AutoGenerateColumns = false;
            this.dgvDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descodigoDataGridViewTextBoxColumn,
            this.desdescripcionDataGridViewTextBoxColumn});
            this.dgvDestinos.DataSource = this.destinoBindingSource;
            this.dgvDestinos.Location = new System.Drawing.Point(57, 213);
            this.dgvDestinos.Name = "dgvDestinos";
            this.dgvDestinos.Size = new System.Drawing.Size(412, 150);
            this.dgvDestinos.TabIndex = 7;
            this.dgvDestinos.CurrentCellChanged += new System.EventHandler(this.dgvDestinos_CurrentCellChanged);
            // 
            // descodigoDataGridViewTextBoxColumn
            // 
            this.descodigoDataGridViewTextBoxColumn.DataPropertyName = "des_codigo";
            this.descodigoDataGridViewTextBoxColumn.HeaderText = "des_codigo";
            this.descodigoDataGridViewTextBoxColumn.Name = "descodigoDataGridViewTextBoxColumn";
            this.descodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desdescripcionDataGridViewTextBoxColumn
            // 
            this.desdescripcionDataGridViewTextBoxColumn.DataPropertyName = "des_descripcion";
            this.desdescripcionDataGridViewTextBoxColumn.HeaderText = "des_descripcion";
            this.desdescripcionDataGridViewTextBoxColumn.Name = "desdescripcionDataGridViewTextBoxColumn";
            // 
            // destinoBindingSource
            // 
            this.destinoBindingSource.DataMember = "Destino";
            this.destinoBindingSource.DataSource = this.prestamosDataSet;
            // 
            // prestamosDataSet
            // 
            this.prestamosDataSet.DataSetName = "prestamosDataSet";
            this.prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinoTableAdapter
            // 
            this.destinoTableAdapter.ClearBeforeFill = true;
            // 
            // frmAltaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 427);
            this.Controls.Add(this.dgvDestinos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.numericUpDownCod);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAltaDestino";
            this.Text = " frmAltaDestino";
            this.Load += new System.EventHandler(this.frmAltaDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.NumericUpDown numericUpDownCod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDestinos;
        private prestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource destinoBindingSource;
        private prestamosDataSetTableAdapters.DestinoTableAdapter destinoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desdescripcionDataGridViewTextBoxColumn;

    }
}