using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Tecnoservice.Class
{
    internal class Cls_Dispositivo
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        bool band;
        public int Dis_Id { get; set; }
        public int Dis_CltId { get; set; }
        public string Dis_Marca { get; set; }
        public string Dis_Modelo { get; set; }
        public string Dis_Imei { get; set; }
        public string Dis_Detalles { get; set; }
        public char Dis_Estado { get; set; }

        public bool Guardar()
        {
            cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Dispositivo";
            return band;
        }
    }
}
