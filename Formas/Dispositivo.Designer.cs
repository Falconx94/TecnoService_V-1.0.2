
namespace Tecnoservice.Formas
{
    partial class Dispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispositivo));
            this.txtIMEIDispo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModeloDispo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarcaDispo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetDispositivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdDispositivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTG_Dispositivo = new System.Windows.Forms.DataGridView();
            this.dsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsProblemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsIMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispositivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DispositivosFalcon = new Tecnoservice.DS_DispositivosFalcon();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteActive = new System.Windows.Forms.ToolStripLabel();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radbtn_Inactivo = new System.Windows.Forms.RadioButton();
            this.Radbtn_Activo = new System.Windows.Forms.RadioButton();
            this.DTG_Cliente = new System.Windows.Forms.DataGridView();
            this.cltIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltApPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltApMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltEstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientesFalcon = new Tecnoservice.dsClientesFalcon();
            this.clientesTableAdapter = new Tecnoservice.dsClientesFalconTableAdapters.ClientesTableAdapter();
            this.txtCltID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dispositivoTableAdapter = new Tecnoservice.DS_DispositivosFalconTableAdapters.DispositivoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Dispositivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DispositivosFalcon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesFalcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIMEIDispo
            // 
            this.txtIMEIDispo.Location = new System.Drawing.Point(32, 315);
            this.txtIMEIDispo.MaxLength = 15;
            this.txtIMEIDispo.Name = "txtIMEIDispo";
            this.txtIMEIDispo.Size = new System.Drawing.Size(207, 20);
            this.txtIMEIDispo.TabIndex = 4;
            this.txtIMEIDispo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIMEIDispo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "IMEI del Dispositivo:";
            // 
            // txtModeloDispo
            // 
            this.txtModeloDispo.Location = new System.Drawing.Point(32, 267);
            this.txtModeloDispo.Name = "txtModeloDispo";
            this.txtModeloDispo.Size = new System.Drawing.Size(207, 20);
            this.txtModeloDispo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Modelo del Dispositivo:";
            // 
            // txtMarcaDispo
            // 
            this.txtMarcaDispo.Location = new System.Drawing.Point(32, 219);
            this.txtMarcaDispo.Name = "txtMarcaDispo";
            this.txtMarcaDispo.Size = new System.Drawing.Size(207, 20);
            this.txtMarcaDispo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Marca del Dispositivo:";
            // 
            // txtDetDispositivo
            // 
            this.txtDetDispositivo.Location = new System.Drawing.Point(32, 371);
            this.txtDetDispositivo.Multiline = true;
            this.txtDetDispositivo.Name = "txtDetDispositivo";
            this.txtDetDispositivo.Size = new System.Drawing.Size(207, 54);
            this.txtDetDispositivo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Detalles del Dispositivo:";
            // 
            // txtIdDispositivo
            // 
            this.txtIdDispositivo.Location = new System.Drawing.Point(32, 72);
            this.txtIdDispositivo.Name = "txtIdDispositivo";
            this.txtIdDispositivo.Size = new System.Drawing.Size(207, 20);
            this.txtIdDispositivo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dispositivo:";
            // 
            // DTG_Dispositivo
            // 
            this.DTG_Dispositivo.AllowUserToAddRows = false;
            this.DTG_Dispositivo.AllowUserToDeleteRows = false;
            this.DTG_Dispositivo.AutoGenerateColumns = false;
            this.DTG_Dispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Dispositivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dsIdDataGridViewTextBoxColumn,
            this.cltIdDataGridViewTextBoxColumn,
            this.dsMarcaDataGridViewTextBoxColumn,
            this.dsModeloDataGridViewTextBoxColumn,
            this.dsProblemaDataGridViewTextBoxColumn,
            this.dsIMEIDataGridViewTextBoxColumn,
            this.dsEstadoDataGridViewTextBoxColumn});
            this.DTG_Dispositivo.DataSource = this.dispositivoBindingSource;
            this.DTG_Dispositivo.Location = new System.Drawing.Point(260, 253);
            this.DTG_Dispositivo.Name = "DTG_Dispositivo";
            this.DTG_Dispositivo.ReadOnly = true;
            this.DTG_Dispositivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_Dispositivo.Size = new System.Drawing.Size(697, 172);
            this.DTG_Dispositivo.TabIndex = 35;
            this.DTG_Dispositivo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_Dispositivo_CellDoubleClick);
            // 
            // dsIdDataGridViewTextBoxColumn
            // 
            this.dsIdDataGridViewTextBoxColumn.DataPropertyName = "Ds_Id";
            this.dsIdDataGridViewTextBoxColumn.HeaderText = "Id Dispositivo";
            this.dsIdDataGridViewTextBoxColumn.Name = "dsIdDataGridViewTextBoxColumn";
            this.dsIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cltIdDataGridViewTextBoxColumn
            // 
            this.cltIdDataGridViewTextBoxColumn.DataPropertyName = "Clt_Id";
            this.cltIdDataGridViewTextBoxColumn.HeaderText = "Id Cliente";
            this.cltIdDataGridViewTextBoxColumn.Name = "cltIdDataGridViewTextBoxColumn";
            this.cltIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsMarcaDataGridViewTextBoxColumn
            // 
            this.dsMarcaDataGridViewTextBoxColumn.DataPropertyName = "Ds_Marca";
            this.dsMarcaDataGridViewTextBoxColumn.HeaderText = "Marca del Dispositivo";
            this.dsMarcaDataGridViewTextBoxColumn.Name = "dsMarcaDataGridViewTextBoxColumn";
            this.dsMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsModeloDataGridViewTextBoxColumn
            // 
            this.dsModeloDataGridViewTextBoxColumn.DataPropertyName = "Ds_Modelo";
            this.dsModeloDataGridViewTextBoxColumn.HeaderText = "Modelo del Dispositivo";
            this.dsModeloDataGridViewTextBoxColumn.Name = "dsModeloDataGridViewTextBoxColumn";
            this.dsModeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsProblemaDataGridViewTextBoxColumn
            // 
            this.dsProblemaDataGridViewTextBoxColumn.DataPropertyName = "Ds_Problema";
            this.dsProblemaDataGridViewTextBoxColumn.HeaderText = "Problemas del Dispositivos";
            this.dsProblemaDataGridViewTextBoxColumn.Name = "dsProblemaDataGridViewTextBoxColumn";
            this.dsProblemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsIMEIDataGridViewTextBoxColumn
            // 
            this.dsIMEIDataGridViewTextBoxColumn.DataPropertyName = "Ds_IMEI";
            this.dsIMEIDataGridViewTextBoxColumn.HeaderText = "IMEI del Dispositivo";
            this.dsIMEIDataGridViewTextBoxColumn.Name = "dsIMEIDataGridViewTextBoxColumn";
            this.dsIMEIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsEstadoDataGridViewTextBoxColumn
            // 
            this.dsEstadoDataGridViewTextBoxColumn.DataPropertyName = "Ds_Estado";
            this.dsEstadoDataGridViewTextBoxColumn.HeaderText = "Estado del Dispositivo";
            this.dsEstadoDataGridViewTextBoxColumn.Name = "dsEstadoDataGridViewTextBoxColumn";
            this.dsEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dispositivoBindingSource
            // 
            this.dispositivoBindingSource.DataMember = "Dispositivo";
            this.dispositivoBindingSource.DataSource = this.dS_DispositivosFalcon;
            // 
            // dS_DispositivosFalcon
            // 
            this.dS_DispositivosFalcon.DataSetName = "DS_DispositivosFalcon";
            this.dS_DispositivosFalcon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnDeleteActive,
            this.btnLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(999, 25);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 22);
            this.btnGuardar.Tag = "8";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDeleteActive
            // 
            this.btnDeleteActive.Name = "btnDeleteActive";
            this.btnDeleteActive.Size = new System.Drawing.Size(50, 22);
            this.btnDeleteActive.Tag = "9";
            this.btnDeleteActive.Text = "Eliminar";
            this.btnDeleteActive.Click += new System.EventHandler(this.btnDeleteActive_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 22);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radbtn_Inactivo);
            this.groupBox1.Controls.Add(this.Radbtn_Activo);
            this.groupBox1.Location = new System.Drawing.Point(260, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 55);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // Radbtn_Inactivo
            // 
            this.Radbtn_Inactivo.AutoSize = true;
            this.Radbtn_Inactivo.Location = new System.Drawing.Point(97, 26);
            this.Radbtn_Inactivo.Name = "Radbtn_Inactivo";
            this.Radbtn_Inactivo.Size = new System.Drawing.Size(63, 17);
            this.Radbtn_Inactivo.TabIndex = 7;
            this.Radbtn_Inactivo.TabStop = true;
            this.Radbtn_Inactivo.Text = "Inactivo";
            this.Radbtn_Inactivo.UseVisualStyleBackColor = true;
            // 
            // Radbtn_Activo
            // 
            this.Radbtn_Activo.AutoSize = true;
            this.Radbtn_Activo.Location = new System.Drawing.Point(6, 26);
            this.Radbtn_Activo.Name = "Radbtn_Activo";
            this.Radbtn_Activo.Size = new System.Drawing.Size(55, 17);
            this.Radbtn_Activo.TabIndex = 6;
            this.Radbtn_Activo.TabStop = true;
            this.Radbtn_Activo.Text = "Activo";
            this.Radbtn_Activo.UseVisualStyleBackColor = true;
            // 
            // DTG_Cliente
            // 
            this.DTG_Cliente.AllowUserToAddRows = false;
            this.DTG_Cliente.AllowUserToDeleteRows = false;
            this.DTG_Cliente.AutoGenerateColumns = false;
            this.DTG_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cltIdDataGridViewTextBoxColumn1,
            this.cltNombreDataGridViewTextBoxColumn,
            this.cltApPaternoDataGridViewTextBoxColumn,
            this.cltApMaternoDataGridViewTextBoxColumn,
            this.cltTelefonoDataGridViewTextBoxColumn,
            this.cltEstatusDataGridViewTextBoxColumn});
            this.DTG_Cliente.DataSource = this.clientesBindingSource;
            this.DTG_Cliente.Location = new System.Drawing.Point(260, 109);
            this.DTG_Cliente.Name = "DTG_Cliente";
            this.DTG_Cliente.ReadOnly = true;
            this.DTG_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_Cliente.Size = new System.Drawing.Size(607, 126);
            this.DTG_Cliente.TabIndex = 40;
            this.DTG_Cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_Cliente_CellDoubleClick);
            // 
            // cltIdDataGridViewTextBoxColumn1
            // 
            this.cltIdDataGridViewTextBoxColumn1.DataPropertyName = "Clt_Id";
            this.cltIdDataGridViewTextBoxColumn1.HeaderText = "Id Cliente";
            this.cltIdDataGridViewTextBoxColumn1.Name = "cltIdDataGridViewTextBoxColumn1";
            this.cltIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cltNombreDataGridViewTextBoxColumn
            // 
            this.cltNombreDataGridViewTextBoxColumn.DataPropertyName = "Clt_Nombre";
            this.cltNombreDataGridViewTextBoxColumn.HeaderText = "Nombre de Cliente";
            this.cltNombreDataGridViewTextBoxColumn.Name = "cltNombreDataGridViewTextBoxColumn";
            this.cltNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cltApPaternoDataGridViewTextBoxColumn
            // 
            this.cltApPaternoDataGridViewTextBoxColumn.DataPropertyName = "Clt_Ap_Paterno";
            this.cltApPaternoDataGridViewTextBoxColumn.HeaderText = "Ap Paterno";
            this.cltApPaternoDataGridViewTextBoxColumn.Name = "cltApPaternoDataGridViewTextBoxColumn";
            this.cltApPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cltApMaternoDataGridViewTextBoxColumn
            // 
            this.cltApMaternoDataGridViewTextBoxColumn.DataPropertyName = "Clt_Ap_Materno";
            this.cltApMaternoDataGridViewTextBoxColumn.HeaderText = "Ap Materno";
            this.cltApMaternoDataGridViewTextBoxColumn.Name = "cltApMaternoDataGridViewTextBoxColumn";
            this.cltApMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cltTelefonoDataGridViewTextBoxColumn
            // 
            this.cltTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Clt_Telefono";
            this.cltTelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.cltTelefonoDataGridViewTextBoxColumn.Name = "cltTelefonoDataGridViewTextBoxColumn";
            this.cltTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cltEstatusDataGridViewTextBoxColumn
            // 
            this.cltEstatusDataGridViewTextBoxColumn.DataPropertyName = "Clt_Estatus";
            this.cltEstatusDataGridViewTextBoxColumn.HeaderText = "Estado de Cliente";
            this.cltEstatusDataGridViewTextBoxColumn.Name = "cltEstatusDataGridViewTextBoxColumn";
            this.cltEstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dsClientesFalcon;
            // 
            // dsClientesFalcon
            // 
            this.dsClientesFalcon.DataSetName = "dsClientesFalcon";
            this.dsClientesFalcon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // txtCltID
            // 
            this.txtCltID.Location = new System.Drawing.Point(32, 125);
            this.txtCltID.Name = "txtCltID";
            this.txtCltID.Size = new System.Drawing.Size(207, 20);
            this.txtCltID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Id de Cliente:";
            // 
            // txtNameCliente
            // 
            this.txtNameCliente.Location = new System.Drawing.Point(32, 173);
            this.txtNameCliente.Name = "txtNameCliente";
            this.txtNameCliente.Size = new System.Drawing.Size(207, 20);
            this.txtNameCliente.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cliente:";
            // 
            // dispositivoTableAdapter
            // 
            this.dispositivoTableAdapter.ClearBeforeFill = true;
            // 
            // Dispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.txtNameCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCltID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTG_Cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DTG_Dispositivo);
            this.Controls.Add(this.txtIMEIDispo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtModeloDispo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMarcaDispo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDetDispositivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdDispositivo);
            this.Controls.Add(this.label5);
            this.Name = "Dispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispositivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dispositivo_FormClosing);
            this.Load += new System.EventHandler(this.Dispositivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Dispositivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DispositivosFalcon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesFalcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIMEIDispo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModeloDispo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarcaDispo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetDispositivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdDispositivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DTG_Dispositivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnDeleteActive;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radbtn_Inactivo;
        private System.Windows.Forms.RadioButton Radbtn_Activo;
        private System.Windows.Forms.DataGridView DTG_Cliente;
        private dsClientesFalcon dsClientesFalcon;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dsClientesFalconTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltApPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltApMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltEstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCltID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCliente;
        private System.Windows.Forms.Label label1;
        private DS_DispositivosFalcon dS_DispositivosFalcon;
        private System.Windows.Forms.BindingSource dispositivoBindingSource;
        private DS_DispositivosFalconTableAdapters.DispositivoTableAdapter dispositivoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsProblemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsIMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
    }
}