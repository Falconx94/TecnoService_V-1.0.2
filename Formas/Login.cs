using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnoservice.Class;

namespace Tecnoservice.Formas
{
    public partial class Login : Form
    {
        //Main_Form mn = new Main_Form(); 
        string user, pass;
        Cls_Login clslog = new Cls_Login();
       public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            user = Txbx_User.Text;
            pass = Txbx_Pass.Text;
        }

        public bool Validar_Usuario()
        {
            if (user == "" && pass == "")
            {
                Txbx_User.Clear();
                Txbx_Pass.Clear();
                MessageBox.Show("Error de usuario o contraseña");
                return false;
            }
            return true;
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            user = Txbx_User.Text;
            pass = Txbx_Pass.Text;
            if (Validar_Usuario())
            {
                //mn.Show();
                this.Hide();
            }
        }

        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                user = Txbx_User.Text;
                pass = Txbx_Pass.Text;
                if (Validar_Usuario())
                {
                    if (Ingreso())
                    {
                        //mn.Show();
                        this.Hide();
                    }
                }
            }
        }
        public bool Ingreso()
        {
            clslog.Log_Usuario = user;
            clslog.Log_Contraseña = pass;

            return true;
        }
    }
}


