
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
            this.txtDispositivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsProblemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsIMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispositivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDispositivos = new Tecnoservice.DsDispositivos();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteActive = new System.Windows.Forms.ToolStripLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dispositivoTableAdapter = new Tecnoservice.DsDispositivosTableAdapters.DispositivoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radbtn_Inactivo = new System.Windows.Forms.RadioButton();
            this.Radbtn_Activo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDispositivos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIMEIDispo
            // 
            this.txtIMEIDispo.Location = new System.Drawing.Point(45, 270);
            this.txtIMEIDispo.Name = "txtIMEIDispo";
            this.txtIMEIDispo.Size = new System.Drawing.Size(207, 20);
            this.txtIMEIDispo.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "IMEI del Dispositivo:";
            // 
            // txtModeloDispo
            // 
            this.txtModeloDispo.Location = new System.Drawing.Point(45, 209);
            this.txtModeloDispo.Name = "txtModeloDispo";
            this.txtModeloDispo.Size = new System.Drawing.Size(207, 20);
            this.txtModeloDispo.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Modelo del Dispositivo:";
            // 
            // txtMarcaDispo
            // 
            this.txtMarcaDispo.Location = new System.Drawing.Point(45, 151);
            this.txtMarcaDispo.Name = "txtMarcaDispo";
            this.txtMarcaDispo.Size = new System.Drawing.Size(207, 20);
            this.txtMarcaDispo.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Marca del Dispositivo:";
            // 
            // txtDetDispositivo
            // 
            this.txtDetDispositivo.Location = new System.Drawing.Point(45, 337);
            this.txtDetDispositivo.Multiline = true;
            this.txtDetDispositivo.Name = "txtDetDispositivo";
            this.txtDetDispositivo.Size = new System.Drawing.Size(207, 88);
            this.txtDetDispositivo.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Detalles del Dispositivo:";
            // 
            // txtDispositivo
            // 
            this.txtDispositivo.Location = new System.Drawing.Point(45, 78);
            this.txtDispositivo.Name = "txtDispositivo";
            this.txtDispositivo.Size = new System.Drawing.Size(207, 20);
            this.txtDispositivo.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dispositivo:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dsIdDataGridViewTextBoxColumn,
            this.cltIdDataGridViewTextBoxColumn,
            this.dsMarcaDataGridViewTextBoxColumn,
            this.dsModeloDataGridViewTextBoxColumn,
            this.dsProblemaDataGridViewTextBoxColumn,
            this.dsIMEIDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dispositivoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(273, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(644, 306);
            this.dataGridView2.TabIndex = 35;
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
            this.cltIdDataGridViewTextBoxColumn.HeaderText = "Id de Cliente";
            this.cltIdDataGridViewTextBoxColumn.Name = "cltIdDataGridViewTextBoxColumn";
            this.cltIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsMarcaDataGridViewTextBoxColumn
            // 
            this.dsMarcaDataGridViewTextBoxColumn.DataPropertyName = "Ds_Marca";
            this.dsMarcaDataGridViewTextBoxColumn.HeaderText = "Marca del dispositivo";
            this.dsMarcaDataGridViewTextBoxColumn.Name = "dsMarcaDataGridViewTextBoxColumn";
            this.dsMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsModeloDataGridViewTextBoxColumn
            // 
            this.dsModeloDataGridViewTextBoxColumn.DataPropertyName = "Ds_Modelo";
            this.dsModeloDataGridViewTextBoxColumn.HeaderText = "Modelo del dispositivo";
            this.dsModeloDataGridViewTextBoxColumn.Name = "dsModeloDataGridViewTextBoxColumn";
            this.dsModeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsProblemaDataGridViewTextBoxColumn
            // 
            this.dsProblemaDataGridViewTextBoxColumn.DataPropertyName = "Ds_Problema";
            this.dsProblemaDataGridViewTextBoxColumn.HeaderText = "Detalles del dispositivo";
            this.dsProblemaDataGridViewTextBoxColumn.Name = "dsProblemaDataGridViewTextBoxColumn";
            this.dsProblemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsIMEIDataGridViewTextBoxColumn
            // 
            this.dsIMEIDataGridViewTextBoxColumn.DataPropertyName = "Ds_IMEI";
            this.dsIMEIDataGridViewTextBoxColumn.HeaderText = "IMEI  del dispositivo";
            this.dsIMEIDataGridViewTextBoxColumn.Name = "dsIMEIDataGridViewTextBoxColumn";
            this.dsIMEIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dispositivoBindingSource
            // 
            this.dispositivoBindingSource.DataMember = "Dispositivo";
            this.dispositivoBindingSource.DataSource = this.dsDispositivos;
            // 
            // dsDispositivos
            // 
            this.dsDispositivos.DataSetName = "DsDispositivos";
            this.dsDispositivos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnDeleteActive});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(993, 25);
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
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDeleteActive
            // 
            this.btnDeleteActive.Name = "btnDeleteActive";
            this.btnDeleteActive.Size = new System.Drawing.Size(50, 22);
            this.btnDeleteActive.Text = "Eliminar";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(271, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(207, 20);
            this.txtID.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Dispositivo:";
            // 
            // dispositivoTableAdapter
            // 
            this.dispositivoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radbtn_Inactivo);
            this.groupBox1.Controls.Add(this.Radbtn_Activo);
            this.groupBox1.Location = new System.Drawing.Point(520, 43);
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
            // 
            // Dispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtIMEIDispo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtModeloDispo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMarcaDispo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDetDispositivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDispositivo);
            this.Controls.Add(this.label5);
            this.Name = "Dispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispositivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dispositivo_FormClosing);
            this.Load += new System.EventHandler(this.Dispositivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDispositivos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtDispositivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnDeleteActive;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private DsDispositivos dsDispositivos;
        private System.Windows.Forms.BindingSource dispositivoBindingSource;
        private DsDispositivosTableAdapters.DispositivoTableAdapter dispositivoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsProblemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsIMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radbtn_Inactivo;
        private System.Windows.Forms.RadioButton Radbtn_Activo;
    }
}