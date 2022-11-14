using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tecnoservice.Class
{
    public class BD_Conex
    {
        static string servidor = "FALCON-DELL\\FALCON_SQL";
        public static string conectar()
        {
               string conex = @"Data Source="+servidor+";Initial Catalog=TecnoService;Integrated Security=True";
               return conex;
        }

    }
}
