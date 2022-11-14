using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tecnoservice.Class;

namespace Tecnoservice.Formas
{
    public partial class Dispositivo : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        bool band1, band2;
        char estado;
        string sdconexion;
        public Dispositivo(string sconexion)
        {
            InitializeComponent();
            Consecutivo();
            this.sdconexion = sconexion;
            dispositivoTableAdapter.Connection.ConnectionString = this.sdconexion;
        }
        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Ds_Id),0) + 1 FROM Dispositivo", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }
        public void GuardarDispositivo()
        {

        }


        public void Valida_estado()
        {
            if (band2 == true)
                estado = 'A';
            else
                estado = 'I';
        }
        private void Radbtn_Activo_Click(object sender, EventArgs e)
        {
            if (Radbtn_Activo.Checked)
            {
                Radbtn_Inactivo.Checked = band1;
                band2 = true;
            }
            else
            {
                Radbtn_Activo.Checked = band1;
                band2 = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void Datos_Fijos()
        {
            txtDispositivo.Enabled = false;
            txtDetDispositivo.Enabled = false;
            txtIMEIDispo.Enabled = false;
            txtMarcaDispo.Enabled = false;
            txtModeloDispo.Enabled = false;
        }

        private void Dispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }

        private void Dispositivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDispositivos.Dispositivo' Puede moverla o quitarla según sea necesario.
            this.dispositivoTableAdapter.Fill(this.dsDispositivos.Dispositivo);

        }
    }
}
