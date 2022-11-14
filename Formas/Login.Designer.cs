
namespace Tecnoservice.Formas
{
    partial class Login
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
            this.Txbx_User = new System.Windows.Forms.TextBox();
            this.Txbx_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Login = new System.Windows.Forms.Button();
            this.Bt_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txbx_User
            // 
            this.Txbx_User.Location = new System.Drawing.Point(39, 136);
            this.Txbx_User.Name = "Txbx_User";
            this.Txbx_User.Size = new System.Drawing.Size(250, 20);
            this.Txbx_User.TabIndex = 0;
            // 
            // Txbx_Pass
            // 
            this.Txbx_Pass.Location = new System.Drawing.Point(39, 210);
            this.Txbx_Pass.Name = "Txbx_Pass";
            this.Txbx_Pass.PasswordChar = '♠';
            this.Txbx_Pass.Size = new System.Drawing.Size(250, 20);
            this.Txbx_Pass.TabIndex = 1;
            this.Txbx_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // BT_Login
            // 
            this.BT_Login.Location = new System.Drawing.Point(55, 255);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(75, 23);
            this.BT_Login.TabIndex = 5;
            this.BT_Login.Text = "Entrar";
            this.BT_Login.UseVisualStyleBackColor = true;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // Bt_Cancelar
            // 
            this.Bt_Cancelar.Location = new System.Drawing.Point(199, 255);
            this.Bt_Cancelar.Name = "Bt_Cancelar";
            this.Bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cancelar.TabIndex = 6;
            this.Bt_Cancelar.Text = "Cancelar";
            this.Bt_Cancelar.UseVisualStyleBackColor = true;
            this.Bt_Cancelar.Click += new System.EventHandler(this.Bt_Cancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 308);
            this.Controls.Add(this.Bt_Cancelar);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txbx_Pass);
            this.Controls.Add(this.Txbx_User);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txbx_User;
        private System.Windows.Forms.TextBox Txbx_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.Button Bt_Cancelar;
    }
}