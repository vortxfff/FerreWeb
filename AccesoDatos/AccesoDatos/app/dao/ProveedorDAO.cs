using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.app.impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Configuration;
    using System.Data;
    using System.Data.OracleClient;


    namespace AccesoDatos.app.dao
    {
        public class ProveedorDAO
        {
            /** inserta datos a la base de datos//
             */
            public bool SetProveedor(Entidades.app.entity.Proveedor proveedor)
            {
                string sp = "SetProveedor";
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
                        oracleCom.Parameters.Add("V_NombreProveedor", OracleType.VarChar); oracleCom.Parameters[1].Value = proveedor.NombreProveedor;
                        oracleCom.Parameters.Add("V_Rubro", OracleType.VarChar); oracleCom.Parameters[2].Value = proveedor.Rubro;
                        oracleCom.Parameters.Add("V_Telefono", OracleType.Number); oracleCom.Parameters[3].Value = proveedor.Telefono;
                        
                        
                        oracleCon.Open();
                        oracleCom.ExecuteNonQuery();

                    }
                    return true;
                }
                catch (Exception ex) { return false; }

            }
            //actualiza datos en la BDD*/
            public bool UpdProveedor(Entidades.app.entity.Proveedor proveedor)
            {
                string sp = "UpdDistribuidor";
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
                        oracleCom.Parameters.Add("V_IDProveedor", OracleType.VarChar); oracleCom.Parameters[0].Value = proveedor.IDProveedor;
                        oracleCom.Parameters.Add("V_NombreProveedor", OracleType.VarChar); oracleCom.Parameters[1].Value = proveedor.NombreProveedor;
                        oracleCom.Parameters.Add("V_Rubro", OracleType.VarChar); oracleCom.Parameters[2].Value = proveedor.Rubro;
                        oracleCom.Parameters.Add("V_Telefono", OracleType.Number); oracleCom.Parameters[3].Value = proveedor.Telefono;
                       

                        oracleCon.Open();
                        oracleCom.ExecuteNonQuery();

                    }
                    return true;
                }
                catch (Exception ex) { return false; }

            }
            //lista los datos de la BDD */
            public List<Entidades.app.entity.Proveedor> GetProveedor()
            {
                List<Entidades.app.entity.Proveedor> proveedores = new List<Entidades.app.entity.Proveedor>();
                string oradb = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=45.236.129.230)(PORT=1521)))"
     + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
     + "User Id=ferne;Password=ferne;";
                
                int pasoInt;
                try
                {
                    using (OracleConnection oracleCon = new OracleConnection(oradb))
                    {
                        oracleCon.Open();
                        OracleCommand oracleCom = new OracleCommand();
                        oracleCom.Connection = oracleCon;
                        oracleCom.CommandText = "SELECT * FROM vw_";
                        //oracleCom.CommandType = CommandType.StoredProcedure;
                        //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                        OracleDataReader rs = oracleCom.ExecuteReader();

                        while (rs.Read())
                        {
                            Entidades.app.entity.Proveedor proveedor = new Entidades.app.entity.Proveedor();
                            proveedor.IDProveedor = rs["ID"].ToString();
                            proveedor.NombreProveedor = rs["Nombre"].ToString();
                            proveedor.Rubro = rs["Rubro"].ToString();
                            int.TryParse(rs["Telefono"].ToString(), out pasoInt);
                            proveedor.Telefono = pasoInt;
           
                           

                            proveedores.Add(proveedor);
                        }
                    }
                    return proveedores;
                }
                catch (Exception) { return null; }
            }
        }
    }
}
