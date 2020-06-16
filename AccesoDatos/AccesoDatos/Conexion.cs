using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Conexion
    {
        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            //conexion.ConnectionString;
            return conexion;
        }

    }
}
