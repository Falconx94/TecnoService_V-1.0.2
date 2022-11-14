
namespace Tecnoservice.Formas
{
    partial class proveedores
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.txtNomContac = new System.Windows.Forms.TextBox();
            this.txtRazo = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prvIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvRazonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvNombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvEstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProveedores = new Tecnoservice.DsProveedores();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.Radbtn_Inactivo = new System.Windows.Forms.RadioButton();
            this.Radbtn_Activo = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripLabel();
            this.btnActualizar = new System.Windows.Forms.ToolStripLabel();
            this.btnEliminarActive = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.proveedoresTableAdapter = new Tecnoservice.DsProveedoresTableAdapters.ProveedoresTableAdapter();
            this.dsPROVEEDOR = new Tecnoservice.dsPROVEEDOR();
            this.proveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter1 = new Tecnoservice.dsPROVEEDORTableAdapters.ProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).BeginInit();
            this.grpEstado.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPROVEEDOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del \r\ncontacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Location = new System.Drawing.Point(130, 63);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(142, 20);
            this.txtIDProveedor.TabIndex = 0;
            // 
            // txtNomContac
            // 
            this.txtNomContac.Location = new System.Drawing.Point(130, 152);
            this.txtNomContac.Name = "txtNomContac";
            this.txtNomContac.Size = new System.Drawing.Size(141, 20);
            this.txtNomContac.TabIndex = 2;
            // 
            // txtRazo
            // 
            this.txtRazo.Location = new System.Drawing.Point(129, 105);
            this.txtRazo.Name = "txtRazo";
            this.txtRazo.Size = new System.Drawing.Size(142, 20);
            this.txtRazo.TabIndex = 1;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(129, 192);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(142, 20);
            this.txtTelef.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 224);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(142, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prvIdDataGridViewTextBoxColumn,
            this.prvRazonsocialDataGridViewTextBoxColumn,
            this.prvNombreContactoDataGridViewTextBoxColumn,
            this.prvTelefonoDataGridViewTextBoxColumn,
            this.prvDireccionDataGridViewTextBoxColumn,
            this.prvEstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedoresBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(287, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 307);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // prvIdDataGridViewTextBoxColumn
            // 
            this.prvIdDataGridViewTextBoxColumn.DataPropertyName = "Prv_Id";
            this.prvIdDataGridViewTextBoxColumn.HeaderText = "Prv_Id";
            this.prvIdDataGridViewTextBoxColumn.Name = "prvIdDataGridViewTextBoxColumn";
            this.prvIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prvRazonsocialDataGridViewTextBoxColumn
            // 
            this.prvRazonsocialDataGridViewTextBoxColumn.DataPropertyName = "Prv_Razonsocial";
            this.prvRazonsocialDataGridViewTextBoxColumn.HeaderText = "Prv_Razonsocial";
            this.prvRazonsocialDataGridViewTextBoxColumn.Name = "prvRazonsocialDataGridViewTextBoxColumn";
            this.prvRazonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prvNombreContactoDataGridViewTextBoxColumn
            // 
            this.prvNombreContactoDataGridViewTextBoxColumn.DataPropertyName = "Prv_Nombre_Contacto";
            this.prvNombreContactoDataGridViewTextBoxColumn.HeaderText = "Prv_Nombre_Contacto";
            this.prvNombreContactoDataGridViewTextBoxColumn.Name = "prvNombreContactoDataGridViewTextBoxColumn";
            this.prvNombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prvTelefonoDataGridViewTextBoxColumn
            // 
            this.prvTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Prv_Telefono";
            this.prvTelefonoDataGridViewTextBoxColumn.HeaderText = "Prv_Telefono";
            this.prvTelefonoDataGridViewTextBoxColumn.Name = "prvTelefonoDataGridViewTextBoxColumn";
            this.prvTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prvDireccionDataGridViewTextBoxColumn
            // 
            this.prvDireccionDataGridViewTextBoxColumn.DataPropertyName = "Prv_Direccion";
            this.prvDireccionDataGridViewTextBoxColumn.HeaderText = "Prv_Direccion";
            this.prvDireccionDataGridViewTextBoxColumn.Name = "prvDireccionDataGridViewTextBoxColumn";
            this.prvDireccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prvEstatusDataGridViewTextBoxColumn
            // 
            this.prvEstatusDataGridViewTextBoxColumn.DataPropertyName = "Prv_Estatus";
            this.prvEstatusDataGridViewTextBoxColumn.HeaderText = "Prv_Estatus";
            this.prvEstatusDataGridViewTextBoxColumn.Name = "prvEstatusDataGridViewTextBoxColumn";
            this.prvEstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dsProveedores;
            // 
            // dsProveedores
            // 
            this.dsProveedores.DataSetName = "DsProveedores";
            this.dsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.Radbtn_Inactivo);
            this.grpEstado.Controls.Add(this.Radbtn_Activo);
            this.grpEstado.Location = new System.Drawing.Point(20, 263);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(207, 55);
            this.grpEstado.TabIndex = 5;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado";
            // 
            // Radbtn_Inactivo
            // 
            this.Radbtn_Inactivo.AutoSize = true;
            this.Radbtn_Inactivo.Location = new System.Drawing.Point(97, 26);
            this.Radbtn_Inactivo.Name = "Radbtn_Inactivo";
            this.Radbtn_Inactivo.Size = new System.Drawing.Size(63, 17);
            this.Radbtn_Inactivo.TabIndex = 1;
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
            this.Radbtn_Activo.TabIndex = 0;
            this.Radbtn_Activo.TabStop = true;
            this.Radbtn_Activo.Text = "Activo";
            this.Radbtn_Activo.UseVisualStyleBackColor = true;
            this.Radbtn_Activo.Click += new System.EventHandler(this.Radbtn_Activo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnActualizar,
            this.btnEliminarActive});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(945, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminarActive
            // 
            this.btnEliminarActive.Name = "btnEliminarActive";
            this.btnEliminarActive.Size = new System.Drawing.Size(59, 22);
            this.btnEliminarActive.Text = "Eliminar";
            this.btnEliminarActive.ToolTipText = "Eliminar";
            this.btnEliminarActive.Click += new System.EventHandler(this.btnEliminarActive_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(152, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // dsPROVEEDOR
            // 
            this.dsPROVEEDOR.DataSetName = "dsPROVEEDOR";
            this.dsPROVEEDOR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingSource1
            // 
            this.proveedoresBindingSource1.DataMember = "Proveedores";
            this.proveedoresBindingSource1.DataSource = this.dsPROVEEDOR;
            // 
            // proveedoresTableAdapter1
            // 
            this.proveedoresTableAdapter1.ClearBeforeFill = true;
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 382);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.txtRazo);
            this.Controls.Add(this.txtNomContac);
            this.Controls.Add(this.txtIDProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.proveedores_FormClosing);
            this.Load += new System.EventHandler(this.proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).EndInit();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPROVEEDOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.TextBox txtNomContac;
        private System.Windows.Forms.TextBox txtRazo;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.RadioButton Radbtn_Inactivo;
        private System.Windows.Forms.RadioButton Radbtn_Activo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripLabel btnEliminarActive;
        private System.Windows.Forms.Button btnEliminar;
        private DsProveedores dsProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DsProveedoresTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvRazonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvNombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvEstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel btnGuardar;
        private System.Windows.Forms.ToolStripLabel btnActualizar;
        private dsPROVEEDOR dsPROVEEDOR;
        private System.Windows.Forms.BindingSource proveedoresBindingSource1;
        private dsPROVEEDORTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter1;
    }
}