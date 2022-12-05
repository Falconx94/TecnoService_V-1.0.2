namespace Tecnoservice.Formas
{
    partial class Ventas_Detalle
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
            this.txtventa = new System.Windows.Forms.TextBox();
            this.dtgventas = new System.Windows.Forms.DataGridView();
            this.detVentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detVentUnidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detVentPrecioUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detVentFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDETVENT_Cholo = new Tecnoservice.dsDETVENT_Cholo();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.detalles_VentaTableAdapter = new Tecnoservice.dsDETVENT_CholoTableAdapters.Detalles_VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDETVENT_Cholo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // txtventa
            // 
            this.txtventa.Location = new System.Drawing.Point(33, 41);
            this.txtventa.Name = "txtventa";
            this.txtventa.Size = new System.Drawing.Size(165, 20);
            this.txtventa.TabIndex = 0;
            this.txtventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtventa_KeyPress);
            // 
            // dtgventas
            // 
            this.dtgventas.AllowUserToAddRows = false;
            this.dtgventas.AllowUserToDeleteRows = false;
            this.dtgventas.AutoGenerateColumns = false;
            this.dtgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detVentIDDataGridViewTextBoxColumn,
            this.vtIdDataGridViewTextBoxColumn,
            this.prodIdDataGridViewTextBoxColumn,
            this.usIdDataGridViewTextBoxColumn,
            this.detVentUnidadesDataGridViewTextBoxColumn,
            this.detVentPrecioUnidadDataGridViewTextBoxColumn,
            this.detVentFechaDataGridViewTextBoxColumn});
            this.dtgventas.DataSource = this.detallesVentaBindingSource;
            this.dtgventas.Location = new System.Drawing.Point(33, 98);
            this.dtgventas.Name = "dtgventas";
            this.dtgventas.ReadOnly = true;
            this.dtgventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgventas.Size = new System.Drawing.Size(744, 197);
            this.dtgventas.TabIndex = 2;
            this.dtgventas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgventas_CellDoubleClick);
            // 
            // detVentIDDataGridViewTextBoxColumn
            // 
            this.detVentIDDataGridViewTextBoxColumn.DataPropertyName = "DetVent_ID";
            this.detVentIDDataGridViewTextBoxColumn.HeaderText = "ID Detalle Venta";
            this.detVentIDDataGridViewTextBoxColumn.Name = "detVentIDDataGridViewTextBoxColumn";
            this.detVentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vtIdDataGridViewTextBoxColumn
            // 
            this.vtIdDataGridViewTextBoxColumn.DataPropertyName = "Vt_Id";
            this.vtIdDataGridViewTextBoxColumn.HeaderText = "Id de Venta";
            this.vtIdDataGridViewTextBoxColumn.Name = "vtIdDataGridViewTextBoxColumn";
            this.vtIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodIdDataGridViewTextBoxColumn
            // 
            this.prodIdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Id";
            this.prodIdDataGridViewTextBoxColumn.HeaderText = "Id Producto";
            this.prodIdDataGridViewTextBoxColumn.Name = "prodIdDataGridViewTextBoxColumn";
            this.prodIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usIdDataGridViewTextBoxColumn
            // 
            this.usIdDataGridViewTextBoxColumn.DataPropertyName = "Us_Id";
            this.usIdDataGridViewTextBoxColumn.HeaderText = "Id Usuario";
            this.usIdDataGridViewTextBoxColumn.Name = "usIdDataGridViewTextBoxColumn";
            this.usIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detVentUnidadesDataGridViewTextBoxColumn
            // 
            this.detVentUnidadesDataGridViewTextBoxColumn.DataPropertyName = "DetVent_Unidades";
            this.detVentUnidadesDataGridViewTextBoxColumn.HeaderText = "DetVent_Unidades";
            this.detVentUnidadesDataGridViewTextBoxColumn.Name = "detVentUnidadesDataGridViewTextBoxColumn";
            this.detVentUnidadesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detVentPrecioUnidadDataGridViewTextBoxColumn
            // 
            this.detVentPrecioUnidadDataGridViewTextBoxColumn.DataPropertyName = "DetVent_PrecioUnidad";
            this.detVentPrecioUnidadDataGridViewTextBoxColumn.HeaderText = "DetVent_PrecioUnidad";
            this.detVentPrecioUnidadDataGridViewTextBoxColumn.Name = "detVentPrecioUnidadDataGridViewTextBoxColumn";
            this.detVentPrecioUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detVentFechaDataGridViewTextBoxColumn
            // 
            this.detVentFechaDataGridViewTextBoxColumn.DataPropertyName = "DetVent_Fecha";
            this.detVentFechaDataGridViewTextBoxColumn.HeaderText = "DetVent_Fecha";
            this.detVentFechaDataGridViewTextBoxColumn.Name = "detVentFechaDataGridViewTextBoxColumn";
            this.detVentFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataMember = "Detalles_Venta";
            this.detallesVentaBindingSource.DataSource = this.dsDETVENT_Cholo;
            // 
            // dsDETVENT_Cholo
            // 
            this.dsDETVENT_Cholo.DataSetName = "dsDETVENT_Cholo";
            this.dsDETVENT_Cholo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(204, 40);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(809, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpiar campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(809, 227);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 68);
            this.btnimprimir.TabIndex = 3;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // detalles_VentaTableAdapter
            // 
            this.detalles_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // Ventas_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 319);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dtgventas);
            this.Controls.Add(this.txtventa);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas_Detalle";
            this.Text = "Ventas_Detalle";
            this.Load += new System.EventHandler(this.Ventas_Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDETVENT_Cholo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtventa;
        private System.Windows.Forms.DataGridView dtgventas;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnimprimir;
        private dsDETVENT_Cholo dsDETVENT_Cholo;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource;
        private dsDETVENT_CholoTableAdapters.Detalles_VentaTableAdapter detalles_VentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn detVentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detVentUnidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detVentPrecioUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detVentFechaDataGridViewTextBoxColumn;
    }
}