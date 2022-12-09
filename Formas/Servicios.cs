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
        bool band1 = true;
        int a,b = 0000000000,cltid;
        char estado;
        string clienteId,clientefecha,telefono,descripcion,type;
        float money;
        public Servicios()
        {
            InitializeComponent();
        }
        public void Set_Data()
        {
            if (txtCltId.Text == "") cltid = 0;
            else cltid = Convert.ToInt32(txtCltId.Text);
            if (txtPrecio.Text == "") money = 0;
            else money = float.Parse(txtPrecio.Text);
            if (txtDescripcion.Text == "") descripcion = "no hay descripcion";
            else descripcion = txtDescripcion.Text;
            clssrv.Srv_ID = Convert.ToInt32(txtSVID.Text);
            clssrv.SrvClt_Id = cltid;
            clssrv.Srv_type = a;
            clssrv.Srv_Fecha = Convert.ToDateTime(dtpFec_Servicio.Text);
            clssrv.Srv_Precio = money;
            clssrv.Srv_Descripcion = descripcion;
            clssrv.Srv_Estado = estado;
        }
        private void Servicios_Load(object sender, EventArgs e)
        {
            Actualiza_Datagrid();
            Consecutivo();
        }
        public void Actualiza_Datagrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'dSClientesFalcon.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dSClientesFalcon.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'dsServicios.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.dsServicios.Servicio);
        }
        public void GuardarServicio()
        {
            if (valida_info())
            {
                Valida_estado();
                Valida_Servicio();
                Set_Data();
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
                    b++;
                    telefono = Convert.ToString(b);
                    clienteId = txtCltId.Text;
                    clientefecha = Convert.ToString(clssrv.Srv_Fecha);
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
                                "values ("+clienteId+",'Invitado','del día','"+clientefecha+"',"+telefono+",'I')",con);
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int tipado = this.dsServicios.Servicio[servicioBindingSource.Position].Sv_Tipo;
            switch (tipado) //type = "Reparación de equipo";
            {
                case 0:
                    type = "Reparación de Equipo";
                    break;
                case 1:
                    type = "Venta de Producto";
                    break;
            }
            //else if (this.dsServicios.Servicio[servicioBindingSource.Position].Sv_Tipo == 1) type = "Venta de producto";
                txtSVID.Text = this.dsServicios.Servicio[servicioBindingSource.Position].Sv_Id.ToString();
            txtCltId.Text = this.dSClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Id.ToString();
            txtDescripcion.Text = this.dsServicios.Servicio[servicioBindingSource.Position].Sv_Descripcion;
            Cbox_TipoServicio.Text = type ;
            txtPrecio.Text = this.dsServicios.Servicio[servicioBindingSource.Position].Sv_Precio.ToString("0.##");
            if (this.dsServicios.Servicio[servicioBindingSource.Position].Sv_Estado == "R")
                Radbtn_Realizado.Checked = true;
            else if (this.dsServicios.Servicio[servicioBindingSource.Position].Sv_Estado == "P")
                Radbtn_Proceso.Checked = true;
            else
                Radbtn_Fin.Checked = true;
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
            Set_Data();
            clssrv.Eliminar();
            Actualiza_Datagrid();
            Consecutivo();
        }
        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = this.dSClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Nombre + "\r\n" +
                this.dSClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Ap_Paterno + "\r\n" +
                this.dSClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Ap_Materno;
            txtCltId.Text = this.dSClientesFalcon.Clientes[clientesBindingSource.Position].Clt_Id.ToString();
            txtCliente.Text = nombre;
        }
        private void Servicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Menu = new Menu_Principal();
            Menu.Show();
        }
    }
}