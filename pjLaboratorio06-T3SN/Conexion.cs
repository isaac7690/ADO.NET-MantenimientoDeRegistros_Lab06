using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias necesarias para la clase
using System.Configuration;
using System.Data.SqlClient;

namespace pjLaboratorio06_T3SN
{
    public class Conexion
    {
        //Metodo de conexion 
        public SqlConnection getConecta()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return cn;
        }

    }
}
