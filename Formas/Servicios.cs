using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Tecnoservice.Class;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Tecnoservice.Formas
{
    public partial class Servicios : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Clientes clt = new Clientes();
        Cls_Servicios clssrv = new Cls_Servicios();
        bool band1 = true, band2 = false;
        int a;
        char estado;
        public Servicios()
        {
            InitializeComponent();
        }
        private void Servicios_Load(object sender, EventArgs e)
        {
            Actualiza_Datagrid();
            Consecutivo();
        }
        public void Actualiza_Datagrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'dsServicios.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.dsServicios.Servicio);
        }
        public void GuardarServicio()
        {
            if (valida_info())
            {
                Valida_estado();
                Valida_Servicio();
                clssrv.Srv_ID = Convert.ToInt32(txtSVID.Text);
                clssrv.SrvClt_Id = Convert.ToInt32(txtCltId.Text);
                clssrv.Srv_type = a;
                clssrv.Srv_Fecha = Convert.ToDateTime(dtpFec_Servicio.Text);
                clssrv.Srv_Precio = float.Parse(txtPrecio.Text);
                clssrv.Srv_Descripción = txtDescripcion.Text;
                clssrv.Srv_Estado = estado;
                if (Valida_cliente())
                {
                    if (clssrv.Guardar())
                    {
                        MessageBox.Show("Datos guardados exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Los datos no se guardaron");
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("El identificador de cliente no se ha encontrado, Desea crear un nuevo cliente?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            clt.ShowDialog();
                            if (clssrv.Guardar())
                            {
                                MessageBox.Show("Datos guardados exitosamente");
                            }
                            else
                            {
                                MessageBox.Show("Los datos no se guardaron");
                            }
                            break;
                        case DialogResult.No:
                            MessageBox.Show("Se Creara un Invitado");
                            cmd = new SqlCommand(
                                "insert into Clientes(Clt_Id,Clt_Nombre,Clt_Ap_Paterno,Clt_Ap_Materno,Clt_Telefono,Clt_Estatus)" +
                                "values ("+clssrv.SrvClt_Id+",'Invitado','del día','"+clssrv.Srv_Fecha+"',8888888888,'I')",con);
                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al guardar los datos =>" + ex);
                            }
                            con.Close();
                            if (clssrv.Guardar())
                            {
                                MessageBox.Show("Datos guardados exitosamente");
                            }
                            else
                            {
                                MessageBox.Show("Los datos no se guardaron");
                            }
                            break;
                    }
                }
                con.Close();
                Consecutivo();
                Actualiza_Datagrid();
            }
        }
        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Sv_Id),0) + 1 FROM Servicio", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtSVID.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }
        public bool Valida_cliente()
        {
            cmd = new SqlCommand("Select Clt_Id from Clientes Where Clt_Id = " + clssrv.SrvClt_Id,con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read()) band1 = true;
            else band1 = false;
            con.Close();
            return band1;
        }
        public void Valida_Servicio()
        {
            if (Cbox_TipoServicio.SelectedIndex == 0) a = 1;
            else a = 2;
        }
        public void Valida_estado()
        {
            if (Radbtn_Proceso.Checked == true)
            {
                estado = 'P';
                Radbtn_Realizado.Checked = false;
                Radbtn_Fin.Checked = false;
            }
            if(Radbtn_Realizado.Checked == true)
            {
                estado = 'R';
                Radbtn_Proceso.Checked = false;
                Radbtn_Fin.Checked = false;
            }
            if(Radbtn_Fin.Checked == true)
            {
                estado = 'C';
                Radbtn_Proceso.Checked = false;
                Radbtn_Fin.Checked = false;
            }
        }
        public bool valida_info()
        {
            if (txtCltId.Text == "" || txtSVID.Text == "" || Cbox_TipoServicio.Text == "" || txtPrecio.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Verificar que los datos esten llenos");
                band1 = false;
            }
            else band1 = true;
            return band1;
        }
        public bool valida_infoEliminar()
        {
            if (txtCltId.Text == "" )
            {
                MessageBox.Show("Verificar que exista un identificador de cliente registrado");
                band1 = false;
            }
            else band1 = true;
            return band1;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GuardarServicio();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(valida_infoEliminar())
                clssrv.SrvClt_Id = Convert.ToInt32(txtCltId.Text);
            if(txtSVID.Text == "")
                clssrv.Srv_ID = 0; 
            else
                clssrv.Srv_ID = Convert.ToInt32(txtSVID.Text);
            clssrv.Eliminar();
        }

        private void Servicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }
    }
}