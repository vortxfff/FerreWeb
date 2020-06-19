using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;


namespace AccesoDatos.impl
{
    public class ProductoDAO
    {
        /** inserta datos a la base de datos//
         */
        public bool SetProducto(Entidades.app.entity.Producto producto)
        {
            string sp = "Set";
            string oradb = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=45.236.129.230)(PORT=1521)))"
 + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
 + "User Id=ferne;Password=ferne;";
            try
            {
                //using (OracleConnection oracleCon = new OracleConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                using (OracleConnection oracleCon = new OracleConnection(oradb))
                {

                    OracleCommand oracleCom = new OracleCommand(sp, oracleCon);
                    oracleCom.CommandType = CommandType.StoredProcedure;
                    oracleCom.Parameters.Add("V_FechaVencimiento", OracleType.DateTime); oracleCom.Parameters[0].Value = producto.FechaVencimiento;
                    oracleCom.Parameters.Add("V_IDTipo", OracleType.Number); oracleCom.Parameters[1].Value = producto.IDTipo;
                    oracleCom.Parameters.Add("V_Precio", OracleType.Number); oracleCom.Parameters[2].Value = producto.Precio;
                    oracleCom.Parameters.Add("V_Stock", OracleType.Number); oracleCom.Parameters[3].Value = producto.Stock;
                    oracleCom.Parameters.Add("V_StockCritico", OracleType.Number); oracleCom.Parameters[4].Value = producto.StockCritico;
                    oracleCom.Parameters.Add("V_Descripcion", OracleType.VarChar); oracleCom.Parameters[5].Value = producto.Descripcion;
                    


                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //actualiza datos en la BDD*/
        public bool UpdProducto(Entidades.app.entity.Producto producto)
        {
            string sp = "UpdProducto";
            string oradb = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=45.236.129.230)(PORT=1521)))"
 + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
 + "User Id=ferne;Password=ferne;";
            try
            {
                //using (OracleConnection oracleCon = new OracleConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                using (OracleConnection oracleCon = new OracleConnection(oradb))
                {

                    OracleCommand oracleCom = new OracleCommand(sp, oracleCon);
                    oracleCom.CommandType = CommandType.StoredProcedure;
                    oracleCom.Parameters.Add("V_FechaVencimiento", OracleType.DateTime); oracleCom.Parameters[0].Value = producto.FechaVencimiento;
                    oracleCom.Parameters.Add("V_IDTipo", OracleType.Number); oracleCom.Parameters[1].Value = producto.IDTipo;
                    oracleCom.Parameters.Add("V_Precio", OracleType.Number); oracleCom.Parameters[2].Value = producto.Precio;
                    oracleCom.Parameters.Add("V_Stock", OracleType.Number); oracleCom.Parameters[3].Value = producto.Stock;
                    oracleCom.Parameters.Add("V_StockCritico", OracleType.Number); oracleCom.Parameters[4].Value = producto.StockCritico;
                    oracleCom.Parameters.Add("V_Descripcion", OracleType.VarChar); oracleCom.Parameters[5].Value = producto.Descripcion;
                    

                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //lista los datos de la BDD */
        public List<Entidades.app.entity.Producto> GetProducto()
        {
            List<Entidades.app.entity.Producto> producto = new List<Entidades.app.entity.Producto>();
            string oradb = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=45.236.129.230)(PORT=1521)))"
 + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
 + "User Id=ferne;Password=ferne;";
            long pasoLong;
            int pasoInt;
            
            try
            {
                using (OracleConnection oracleCon = new OracleConnection(oradb))
                {
                    oracleCon.Open();
                    OracleCommand oracleCom = new OracleCommand();
                    oracleCom.Connection = oracleCon;
                    oracleCom.CommandText = "SELECT * FROM vw_Producto";
                    //oracleCom.CommandType = CommandType.StoredProcedure;
                    //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                    OracleDataReader rs = oracleCom.ExecuteReader();

                    while (rs.Read())
                    {
                        Entidades.app.entity.Producto productos = new Entidades.app.entity.Producto();
                        productos.FechaVencimiento = Convert.ToDateTime(rs["FechaVencimiento"]);
                        long.TryParse(rs["IDTipo"].ToString(), out pasoLong);
                        productos.IDTipo = pasoLong;
                        int.TryParse(rs["Precio"].ToString(), out pasoInt);
                        productos.Precio = pasoInt;
                        int.TryParse(rs["Stock"].ToString(), out pasoInt);
                        productos.Stock = pasoInt;
                        int.TryParse(rs["StockCritico"].ToString(), out pasoInt);
                        productos.StockCritico = pasoInt;
                        productos.Descripcion = rs["Descripcion"].ToString();
                        
                        

                        producto.Add(productos);
                    }
                }
                return producto;
            }
            catch (Exception) { return null; }
        }
    }
}
