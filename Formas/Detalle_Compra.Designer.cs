
namespace Tecnoservice.Formas
{
    partial class Detalle_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle_Compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.Radbtn_Inactivo = new System.Windows.Forms.RadioButton();
            this.Radbtn_Activo = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnElimininarAct = new System.Windows.Forms.ToolStripButton();
            this.txtDetComID = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.txtproducID = new System.Windows.Forms.TextBox();
            this.txtcompraID = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detComIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detComObservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detComUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detComPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detComCantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detimporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detComEstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetalleCompra = new Tecnoservice.dsDetalleCompra();
            this.detalles_CompraTableAdapter = new Tecnoservice.dsDetalleCompraTableAdapters.Detalles_CompraTableAdapter();
            this.grpEstado.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle\r\nCompra ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compra ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 416);
            this.label9.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Importe";
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.Radbtn_Inactivo);
            this.grpEstado.Controls.Add(this.Radbtn_Activo);
            this.grpEstado.Location = new System.Drawing.Point(18, 464);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(207, 55);
            this.grpEstado.TabIndex = 9;
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
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnActualizar,
            this.btnElimininarAct});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 10;
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
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnElimininarAct
            // 
            this.btnElimininarAct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnElimininarAct.Image = ((System.Drawing.Image)(resources.GetObject("btnElimininarAct.Image")));
            this.btnElimininarAct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElimininarAct.Name = "btnElimininarAct";
            this.btnElimininarAct.Size = new System.Drawing.Size(54, 22);
            this.btnElimininarAct.Text = "Eliminar";
            this.btnElimininarAct.Click += new System.EventHandler(this.btnElimininarAct_Click);
            // 
            // txtDetComID
            // 
            this.txtDetComID.Location = new System.Drawing.Point(115, 32);
            this.txtDetComID.Name = "txtDetComID";
            this.txtDetComID.Size = new System.Drawing.Size(58, 20);
            this.txtDetComID.TabIndex = 11;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(115, 414);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(142, 20);
            this.txtImporte.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(115, 366);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 20);
            this.txtCantidad.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(115, 313);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 20);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(115, 274);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(142, 20);
            this.txtUnidad.TabIndex = 16;
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Location = new System.Drawing.Point(115, 151);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(58, 20);
            this.txtIDProveedor.TabIndex = 18;
            // 
            // txtproducID
            // 
            this.txtproducID.Location = new System.Drawing.Point(115, 111);
            this.txtproducID.Name = "txtproducID";
            this.txtproducID.Size = new System.Drawing.Size(58, 20);
            this.txtproducID.TabIndex = 19;
            // 
            // txtcompraID
            // 
            this.txtcompraID.Location = new System.Drawing.Point(115, 74);
            this.txtcompraID.Name = "txtcompraID";
            this.txtcompraID.Size = new System.Drawing.Size(58, 20);
            this.txtcompraID.TabIndex = 20;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(115, 189);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(153, 62);
            this.txtObservacion.TabIndex = 21;
            this.txtObservacion.Text = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(242, 496);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detComIdDataGridViewTextBoxColumn,
            this.comIdDataGridViewTextBoxColumn,
            this.prodIdDataGridViewTextBoxColumn,
            this.prvIdDataGridViewTextBoxColumn,
            this.detComObservacionDataGridViewTextBoxColumn,
            this.detComUnidadDataGridViewTextBoxColumn,
            this.detComPrecioDataGridViewTextBoxColumn,
            this.detComCantidadDataGridViewTextBoxColumn,
            this.detimporteDataGridViewTextBoxColumn,
            this.detComEstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detallesCompraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(321, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(691, 487);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // detComIdDataGridViewTextBoxColumn
            // 
            this.detComIdDataGridViewTextBoxColumn.DataPropertyName = "DetCom_Id";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detComIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.detComIdDataGridViewTextBoxColumn.HeaderText = "DetCom_Id";
            this.detComIdDataGridViewTextBoxColumn.Name = "detComIdDataGridViewTextBoxColumn";
            this.detComIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.detComIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // comIdDataGridViewTextBoxColumn
            // 
            this.comIdDataGridViewTextBoxColumn.DataPropertyName = "Com_Id";
            this.comIdDataGridViewTextBoxColumn.HeaderText = "Com_Id";
            this.comIdDataGridViewTextBoxColumn.Name = "comIdDataGridViewTextBoxColumn";
            this.comIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.comIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // prodIdDataGridViewTextBoxColumn
            // 
            this.prodIdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Id";
            this.prodIdDataGridViewTextBoxColumn.HeaderText = "Prod_Id";
            this.prodIdDataGridViewTextBoxColumn.Name = "prodIdDataGridViewTextBoxColumn";
            this.prodIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // prvIdDataGridViewTextBoxColumn
            // 
            this.prvIdDataGridViewTextBoxColumn.DataPropertyName = "Prv_Id";
            this.prvIdDataGridViewTextBoxColumn.HeaderText = "Prv_Id";
            this.prvIdDataGridViewTextBoxColumn.Name = "prvIdDataGridViewTextBoxColumn";
            this.prvIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.prvIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // detComObservacionDataGridViewTextBoxColumn
            // 
            this.detComObservacionDataGridViewTextBoxColumn.DataPropertyName = "DetCom_Observacion";
            this.detComObservacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.detComObservacionDataGridViewTextBoxColumn.Name = "detComObservacionDataGridViewTextBoxColumn";
            this.detComObservacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detComUnidadDataGridViewTextBoxColumn
            // 
            this.detComUnidadDataGridViewTextBoxColumn.DataPropertyName = "DetCom_Unidad";
            this.detComUnidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.detComUnidadDataGridViewTextBoxColumn.Name = "detComUnidadDataGridViewTextBoxColumn";
            this.detComUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.detComUnidadDataGridViewTextBoxColumn.Width = 70;
            // 
            // detComPrecioDataGridViewTextBoxColumn
            // 
            this.detComPrecioDataGridViewTextBoxColumn.DataPropertyName = "DetCom_Precio";
            this.detComPrecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.detComPrecioDataGridViewTextBoxColumn.Name = "detComPrecioDataGridViewTextBoxColumn";
            this.detComPrecioDataGridViewTextBoxColumn.ReadOnly = true;
            this.detComPrecioDataGridViewTextBoxColumn.Width = 70;
            // 
            // detComCantidadDataGridViewTextBoxColumn
            // 
            this.detComCantidadDataGridViewTextBoxColumn.DataPropertyName = "DetCom_Cantidad";
            this.detComCantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.detComCantidadDataGridViewTextBoxColumn.Name = "detComCantidadDataGridViewTextBoxColumn";
            this.detComCantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.detComCantidadDataGridViewTextBoxColumn.Width = 70;
            // 
            // detimporteDataGridViewTextBoxColumn
            // 
            this.detimporteDataGridViewTextBoxColumn.DataPropertyName = "Det_importe";
            this.detimporteDataGridViewTextBoxColumn.HeaderText = "importe";
            this.detimporteDataGridViewTextBoxColumn.Name = "detimporteDataGridViewTextBoxColumn";
            this.detimporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.detimporteDataGridViewTextBoxColumn.Width = 70;
            // 
            // detComEstatusDataGridViewTextBoxColumn
            // 
            this.detComEstatusDataGridViewTextBoxColumn.DataPropertyName = "DetCom_Estatus";
            this.detComEstatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.detComEstatusDataGridViewTextBoxColumn.Name = "detComEstatusDataGridViewTextBoxColumn";
            this.detComEstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.detComEstatusDataGridViewTextBoxColumn.Width = 50;
            // 
            // detallesCompraBindingSource
            // 
            this.detallesCompraBindingSource.DataMember = "Detalles_Compra";
            this.detallesCompraBindingSource.DataSource = this.dsDetalleCompra;
            // 
            // dsDetalleCompra
            // 
            this.dsDetalleCompra.DataSetName = "dsDetalleCompra";
            this.dsDetalleCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalles_CompraTableAdapter
            // 
            this.detalles_CompraTableAdapter.ClearBeforeFill = true;
            // 
            // Detalle_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtcompraID);
            this.Controls.Add(this.txtproducID);
            this.Controls.Add(this.txtIDProveedor);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtDetComID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Detalle_Compra";
            this.Text = "Detalle_Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Detalle_Compra_FormClosing);
            this.Load += new System.EventHandler(this.Detalle_Compra_Load);
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.RadioButton Radbtn_Inactivo;
        private System.Windows.Forms.RadioButton Radbtn_Activo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnElimininarAct;
        private System.Windows.Forms.TextBox txtDetComID;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.TextBox txtproducID;
        private System.Windows.Forms.TextBox txtcompraID;
        private System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsDetalleCompra dsDetalleCompra;
        private System.Windows.Forms.BindingSource detallesCompraBindingSource;
        private dsDetalleCompraTableAdapters.Detalles_CompraTableAdapter detalles_CompraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn detComIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detComObservacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detComUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detComPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detComCantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detimporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detComEstatusDataGridViewTextBoxColumn;
    }
}