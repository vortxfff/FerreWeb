using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.data.sqlclient;
using System.Data.SqlTypes;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region Patron singleton
        private static Conexion conexion = null;
        private Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            
        }
    }

    
}
