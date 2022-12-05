namespace Tecnoservice.Formas
{
    partial class Ventas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vtIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vttotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecnoServiceDataSet1 = new Tecnoservice.TecnoServiceDataSet1();
            this.ventasTableAdapter = new Tecnoservice.TecnoServiceDataSet1TableAdapters.VentasTableAdapter();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnoServiceDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vtIdDataGridViewTextBoxColumn,
            this.cltIdDataGridViewTextBoxColumn,
            this.vttotalDataGridViewTextBoxColumn,
            this.usIdDataGridViewTextBoxColumn,
            this.vtFechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ventasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vtIdDataGridViewTextBoxColumn
            // 
            this.vtIdDataGridViewTextBoxColumn.DataPropertyName = "Vt_Id";
            this.vtIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.vtIdDataGridViewTextBoxColumn.Name = "vtIdDataGridViewTextBoxColumn";
            this.vtIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vtIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // cltIdDataGridViewTextBoxColumn
            // 
            this.cltIdDataGridViewTextBoxColumn.DataPropertyName = "Clt_Id";
            this.cltIdDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cltIdDataGridViewTextBoxColumn.Name = "cltIdDataGridViewTextBoxColumn";
            this.cltIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cltIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // vttotalDataGridViewTextBoxColumn
            // 
            this.vttotalDataGridViewTextBoxColumn.DataPropertyName = "Vt_total";
            this.vttotalDataGridViewTextBoxColumn.HeaderText = "total";
            this.vttotalDataGridViewTextBoxColumn.Name = "vttotalDataGridViewTextBoxColumn";
            this.vttotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usIdDataGridViewTextBoxColumn
            // 
            this.usIdDataGridViewTextBoxColumn.DataPropertyName = "Us_Id";
            this.usIdDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usIdDataGridViewTextBoxColumn.Name = "usIdDataGridViewTextBoxColumn";
            this.usIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vtFechaDataGridViewTextBoxColumn
            // 
            this.vtFechaDataGridViewTextBoxColumn.DataPropertyName = "Vt_Fecha";
            this.vtFechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.vtFechaDataGridViewTextBoxColumn.Name = "vtFechaDataGridViewTextBoxColumn";
            this.vtFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.tecnoServiceDataSet1;
            // 
            // tecnoServiceDataSet1
            // 
            this.tecnoServiceDataSet1.DataSetName = "TecnoServiceDataSet1";
            this.tecnoServiceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(332, 20);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            this.btnbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnbuscar_KeyPress);
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(109, 22);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(217, 20);
            this.txtarticulo.TabIndex = 2;
            this.txtarticulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtarticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtarticulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Articulo";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnoServiceDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TecnoServiceDataSet1 tecnoServiceDataSet1;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private TecnoServiceDataSet1TableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vttotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label1;
    }
}