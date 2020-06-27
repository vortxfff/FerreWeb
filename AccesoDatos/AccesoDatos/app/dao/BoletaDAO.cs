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
    public class BoletaDAO
    {
        /** inserta datos a la base de datos//
         */
        public bool SetEmpleado(Entidades.app.entity.Boleta boleta)
        {
            string sp = "setBoleta";
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
                    oracleCom.Parameters.Add("V_IDBoleta", OracleType.Number); oracleCom.Parameters[0].Value = boleta.IDBoleta;
                    oracleCom.Parameters.Add("V_IDProducto", OracleType.Number); oracleCom.Parameters[1].Value = boleta.IDproducto;
                    oracleCom.Parameters.Add("V_NombreProducto", OracleType.VarChar); oracleCom.Parameters[2].Value = boleta.NombreProducto;
                    oracleCom.Parameters.Add("V_SumaPrecio", OracleType.Number); oracleCom.Parameters[3].Value = boleta.SumaPrecio;
                    oracleCom.Parameters.Add("V_Total", OracleType.Number); oracleCom.Parameters[4].Value = boleta.Total;
                    
                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }

        //actualiza datos en la BDD*/
        public bool UpdEmpleados(Entidades.app.entity.Boleta boleta)
        {
            string sp = "UpdBoleta";
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
                    oracleCom.Parameters.Add("V_IDBoleta", OracleType.Number); oracleCom.Parameters[0].Value = boleta.IDBoleta;
                    oracleCom.Parameters.Add("V_IDProducto", OracleType.Number); oracleCom.Parameters[1].Value = boleta.IDproducto;
                    oracleCom.Parameters.Add("V_NombreProducto", OracleType.VarChar); oracleCom.Parameters[2].Value = boleta.NombreProducto;
                    oracleCom.Parameters.Add("V_SumaPrecio", OracleType.Number); oracleCom.Parameters[3].Value = boleta.SumaPrecio;
                    oracleCom.Parameters.Add("V_Total", OracleType.Number); oracleCom.Parameters[4].Value = boleta.Total;

                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //lista los datos de la BDD */
        public List<Entidades.app.entity.Boleta> GetBoletas()
        {

            {
                List<Entidades.app.entity.Boleta> boletas = new List<Entidades.app.entity.Boleta>();
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
                        oracleCom.CommandText = "SELECT * FROM vw_boletas crear";
                        //oracleCom.CommandType = CommandType.StoredProcedure;
                        //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                        OracleDataReader rs = oracleCom.ExecuteReader();

                        while (rs.Read())
                        {
                            Entidades.app.entity.Boleta boleta = new Entidades.app.entity.Boleta();
                            pasoInt = 0; int.TryParse(rs["IDBoleta"].ToString(), out pasoInt);
                            boleta.IDBoleta = pasoInt;
                            pasoInt = 0; int.TryParse(rs["IDProducto"].ToString(), out pasoInt);
                            boleta.IDproducto = pasoInt;
                            boleta.NombreProducto = rs["NobreProducto"].ToString();
                            pasoInt = 0; int.TryParse(rs["SumaPrecio"].ToString(), out pasoInt);
                            boleta.SumaPrecio = pasoInt;
                            pasoInt = 0; int.TryParse(rs["Total"].ToString(), out pasoInt);
                            boleta.Total = pasoInt;
                           
                          
                            boletas.Add(boleta);
                        }
                    }
                    return boletas;
                }
                catch (Exception) { return null; }
            }
        }
    }
}
