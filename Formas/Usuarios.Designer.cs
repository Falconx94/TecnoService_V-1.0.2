namespace Tecnoservice.Formas
{
    partial class Usuarios
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usApPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usApMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usNivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuarioclass = new Tecnoservice.dsUsuarioclass();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtsegapellido = new System.Windows.Forms.TextBox();
            this.txtpriapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btncapturar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new Tecnoservice.dsUsuarioclassTableAdapters.UsuarioTableAdapter();
            this.txtlimpiar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarioclass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(23, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(89, 20);
            this.txtid.TabIndex = 0;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usIdDataGridViewTextBoxColumn,
            this.usNombreDataGridViewTextBoxColumn,
            this.uspassDataGridViewTextBoxColumn,
            this.usApPaternoDataGridViewTextBoxColumn,
            this.usApMaternoDataGridViewTextBoxColumn,
            this.usTelefonoDataGridViewTextBoxColumn,
            this.usNivelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(160, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(735, 206);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // usIdDataGridViewTextBoxColumn
            // 
            this.usIdDataGridViewTextBoxColumn.DataPropertyName = "Us_Id";
            this.usIdDataGridViewTextBoxColumn.HeaderText = "Us_Id";
            this.usIdDataGridViewTextBoxColumn.Name = "usIdDataGridViewTextBoxColumn";
            this.usIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usNombreDataGridViewTextBoxColumn
            // 
            this.usNombreDataGridViewTextBoxColumn.DataPropertyName = "Us_Nombre";
            this.usNombreDataGridViewTextBoxColumn.HeaderText = "Us_Nombre";
            this.usNombreDataGridViewTextBoxColumn.Name = "usNombreDataGridViewTextBoxColumn";
            this.usNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uspassDataGridViewTextBoxColumn
            // 
            this.uspassDataGridViewTextBoxColumn.DataPropertyName = "Us_pass";
            this.uspassDataGridViewTextBoxColumn.HeaderText = "Us_pass";
            this.uspassDataGridViewTextBoxColumn.Name = "uspassDataGridViewTextBoxColumn";
            this.uspassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usApPaternoDataGridViewTextBoxColumn
            // 
            this.usApPaternoDataGridViewTextBoxColumn.DataPropertyName = "Us_Ap_Paterno";
            this.usApPaternoDataGridViewTextBoxColumn.HeaderText = "Us_Ap_Paterno";
            this.usApPaternoDataGridViewTextBoxColumn.Name = "usApPaternoDataGridViewTextBoxColumn";
            this.usApPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usApMaternoDataGridViewTextBoxColumn
            // 
            this.usApMaternoDataGridViewTextBoxColumn.DataPropertyName = "Us_Ap_Materno";
            this.usApMaternoDataGridViewTextBoxColumn.HeaderText = "Us_Ap_Materno";
            this.usApMaternoDataGridViewTextBoxColumn.Name = "usApMaternoDataGridViewTextBoxColumn";
            this.usApMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usTelefonoDataGridViewTextBoxColumn
            // 
            this.usTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Us_Telefono";
            this.usTelefonoDataGridViewTextBoxColumn.HeaderText = "Us_Telefono";
            this.usTelefonoDataGridViewTextBoxColumn.Name = "usTelefonoDataGridViewTextBoxColumn";
            this.usTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usNivelDataGridViewTextBoxColumn
            // 
            this.usNivelDataGridViewTextBoxColumn.DataPropertyName = "Us_Nivel";
            this.usNivelDataGridViewTextBoxColumn.HeaderText = "Us_Nivel";
            this.usNivelDataGridViewTextBoxColumn.Name = "usNivelDataGridViewTextBoxColumn";
            this.usNivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dsUsuarioclass;
            // 
            // dsUsuarioclass
            // 
            this.dsUsuarioclass.DataSetName = "dsUsuarioclass";
            this.dsUsuarioclass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segundo apellido ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Primer apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nivel";
            // 
            // txtnivel
            // 
            this.txtnivel.Location = new System.Drawing.Point(23, 252);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(50, 20);
            this.txtnivel.TabIndex = 5;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(23, 213);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 4;
            this.txttelefono.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtsegapellido
            // 
            this.txtsegapellido.Location = new System.Drawing.Point(23, 171);
            this.txtsegapellido.Name = "txtsegapellido";
            this.txtsegapellido.Size = new System.Drawing.Size(131, 20);
            this.txtsegapellido.TabIndex = 3;
            // 
            // txtpriapellido
            // 
            this.txtpriapellido.Location = new System.Drawing.Point(23, 129);
            this.txtpriapellido.Name = "txtpriapellido";
            this.txtpriapellido.Size = new System.Drawing.Size(131, 20);
            this.txtpriapellido.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(23, 90);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(131, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // btncapturar
            // 
            this.btncapturar.Location = new System.Drawing.Point(191, 288);
            this.btncapturar.Name = "btncapturar";
            this.btncapturar.Size = new System.Drawing.Size(75, 23);
            this.btncapturar.TabIndex = 7;
            this.btncapturar.Text = "Capturar";
            this.btncapturar.UseVisualStyleBackColor = true;
            this.btncapturar.Click += new System.EventHandler(this.btncapturar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(272, 288);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(353, 288);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 9;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(23, 297);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // txtlimpiar
            // 
            this.txtlimpiar.Location = new System.Drawing.Point(434, 288);
            this.txtlimpiar.Name = "txtlimpiar";
            this.txtlimpiar.Size = new System.Drawing.Size(75, 23);
            this.txtlimpiar.TabIndex = 19;
            this.txtlimpiar.Text = "Limpiar ";
            this.txtlimpiar.UseVisualStyleBackColor = true;
            this.txtlimpiar.Click += new System.EventHandler(this.txtlimpiar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(353, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(270, 20);
            this.txtbuscar.TabIndex = 20;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Buscar";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 333);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtlimpiar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncapturar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtpriapellido);
            this.Controls.Add(this.txtsegapellido);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarioclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtsegapellido;
        private System.Windows.Forms.TextBox txtpriapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btncapturar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label7;
        private dsUsuarioclass dsUsuarioclass;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private dsUsuarioclassTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uspassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usApPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usApMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button txtlimpiar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label8;
    }
}