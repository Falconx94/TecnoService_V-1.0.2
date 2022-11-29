
namespace Tecnoservice.Formas
{
    partial class Servicios
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCltId = new System.Windows.Forms.TextBox();
            this.txtSVID = new System.Windows.Forms.TextBox();
            this.dtpFec_Servicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.Cbox_TipoServicio = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radbtn_Fin = new System.Windows.Forms.RadioButton();
            this.Radbtn_Proceso = new System.Windows.Forms.RadioButton();
            this.Radbtn_Realizado = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.svIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsServicios = new Tecnoservice.dsServicios();
            this.servicioTableAdapter = new Tecnoservice.dsServiciosTableAdapters.ServicioTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(28, 242);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(139, 20);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtCltId
            // 
            this.txtCltId.Location = new System.Drawing.Point(28, 129);
            this.txtCltId.Name = "txtCltId";
            this.txtCltId.Size = new System.Drawing.Size(100, 20);
            this.txtCltId.TabIndex = 18;
            // 
            // txtSVID
            // 
            this.txtSVID.Location = new System.Drawing.Point(28, 76);
            this.txtSVID.Name = "txtSVID";
            this.txtSVID.Size = new System.Drawing.Size(100, 20);
            this.txtSVID.TabIndex = 17;
            // 
            // dtpFec_Servicio
            // 
            this.dtpFec_Servicio.Location = new System.Drawing.Point(210, 76);
            this.dtpFec_Servicio.Name = "dtpFec_Servicio";
            this.dtpFec_Servicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFec_Servicio.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha del servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Folio Servicio ID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1209, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton2.Text = "Buscar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Cbox_TipoServicio
            // 
            this.Cbox_TipoServicio.FormattingEnabled = true;
            this.Cbox_TipoServicio.Items.AddRange(new object[] {
            "Reparación de equipo",
            "Venta de producto"});
            this.Cbox_TipoServicio.Location = new System.Drawing.Point(28, 186);
            this.Cbox_TipoServicio.Name = "Cbox_TipoServicio";
            this.Cbox_TipoServicio.Size = new System.Drawing.Size(139, 21);
            this.Cbox_TipoServicio.TabIndex = 22;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(28, 305);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(168, 41);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Descripción del Servicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Estado del Servicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radbtn_Fin);
            this.groupBox1.Controls.Add(this.Radbtn_Proceso);
            this.groupBox1.Controls.Add(this.Radbtn_Realizado);
            this.groupBox1.Location = new System.Drawing.Point(210, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 96);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // Radbtn_Fin
            // 
            this.Radbtn_Fin.AutoSize = true;
            this.Radbtn_Fin.Location = new System.Drawing.Point(6, 66);
            this.Radbtn_Fin.Name = "Radbtn_Fin";
            this.Radbtn_Fin.Size = new System.Drawing.Size(76, 17);
            this.Radbtn_Fin.TabIndex = 2;
            this.Radbtn_Fin.TabStop = true;
            this.Radbtn_Fin.Text = "Cancelado";
            this.Radbtn_Fin.UseVisualStyleBackColor = true;
            // 
            // Radbtn_Proceso
            // 
            this.Radbtn_Proceso.AutoSize = true;
            this.Radbtn_Proceso.Location = new System.Drawing.Point(6, 43);
            this.Radbtn_Proceso.Name = "Radbtn_Proceso";
            this.Radbtn_Proceso.Size = new System.Drawing.Size(79, 17);
            this.Radbtn_Proceso.TabIndex = 1;
            this.Radbtn_Proceso.TabStop = true;
            this.Radbtn_Proceso.Text = "Trabajando";
            this.Radbtn_Proceso.UseVisualStyleBackColor = true;
            // 
            // Radbtn_Realizado
            // 
            this.Radbtn_Realizado.AutoSize = true;
            this.Radbtn_Realizado.Location = new System.Drawing.Point(7, 20);
            this.Radbtn_Realizado.Name = "Radbtn_Realizado";
            this.Radbtn_Realizado.Size = new System.Drawing.Size(72, 17);
            this.Radbtn_Realizado.TabIndex = 0;
            this.Radbtn_Realizado.TabStop = true;
            this.Radbtn_Realizado.Text = "Realizado";
            this.Radbtn_Realizado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.svIdDataGridViewTextBoxColumn,
            this.cltIdDataGridViewTextBoxColumn,
            this.svTipoDataGridViewTextBoxColumn,
            this.svPrecioDataGridViewTextBoxColumn,
            this.svDescripcionDataGridViewTextBoxColumn,
            this.svFechaDataGridViewTextBoxColumn,
            this.svEstadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(432, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 292);
            this.dataGridView1.TabIndex = 27;
            // 
            // svIdDataGridViewTextBoxColumn
            // 
            this.svIdDataGridViewTextBoxColumn.DataPropertyName = "Sv_Id";
            this.svIdDataGridViewTextBoxColumn.HeaderText = "Servicio Id";
            this.svIdDataGridViewTextBoxColumn.Name = "svIdDataGridViewTextBoxColumn";
            this.svIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cltIdDataGridViewTextBoxColumn
            // 
            this.cltIdDataGridViewTextBoxColumn.DataPropertyName = "Clt_Id";
            this.cltIdDataGridViewTextBoxColumn.HeaderText = "Cliente Id";
            this.cltIdDataGridViewTextBoxColumn.Name = "cltIdDataGridViewTextBoxColumn";
            this.cltIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svTipoDataGridViewTextBoxColumn
            // 
            this.svTipoDataGridViewTextBoxColumn.DataPropertyName = "Sv_Tipo";
            this.svTipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Servicio";
            this.svTipoDataGridViewTextBoxColumn.Name = "svTipoDataGridViewTextBoxColumn";
            this.svTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svPrecioDataGridViewTextBoxColumn
            // 
            this.svPrecioDataGridViewTextBoxColumn.DataPropertyName = "Sv_Precio";
            this.svPrecioDataGridViewTextBoxColumn.HeaderText = "Precio del Servicio";
            this.svPrecioDataGridViewTextBoxColumn.Name = "svPrecioDataGridViewTextBoxColumn";
            this.svPrecioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svDescripcionDataGridViewTextBoxColumn
            // 
            this.svDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Sv_Descripcion";
            this.svDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion del servicio";
            this.svDescripcionDataGridViewTextBoxColumn.Name = "svDescripcionDataGridViewTextBoxColumn";
            this.svDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svFechaDataGridViewTextBoxColumn
            // 
            this.svFechaDataGridViewTextBoxColumn.DataPropertyName = "Sv_Fecha";
            this.svFechaDataGridViewTextBoxColumn.HeaderText = "Fecha de realizado el servicio";
            this.svFechaDataGridViewTextBoxColumn.Name = "svFechaDataGridViewTextBoxColumn";
            this.svFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svEstadoDataGridViewTextBoxColumn
            // 
            this.svEstadoDataGridViewTextBoxColumn.DataPropertyName = "Sv_Estado";
            this.svEstadoDataGridViewTextBoxColumn.HeaderText = "Estado del Servicio";
            this.svEstadoDataGridViewTextBoxColumn.Name = "svEstadoDataGridViewTextBoxColumn";
            this.svEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.dsServicios;
            // 
            // dsServicios
            // 
            this.dsServicios.DataSetName = "dsServicios";
            this.dsServicios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbox_TipoServicio);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCltId);
            this.Controls.Add(this.txtSVID);
            this.Controls.Add(this.dtpFec_Servicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Servicios_FormClosing);
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCltId;
        private System.Windows.Forms.TextBox txtSVID;
        private System.Windows.Forms.DateTimePicker dtpFec_Servicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ComboBox Cbox_TipoServicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radbtn_Fin;
        private System.Windows.Forms.RadioButton Radbtn_Proceso;
        private System.Windows.Forms.RadioButton Radbtn_Realizado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsServicios dsServicios;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private dsServiciosTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn svIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svEstadoDataGridViewTextBoxColumn;
    }
}