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
        public class DistribidorDAO
        {
            /** inserta datos a la base de datos//
             */
            public bool SetDistribuidor(Entidades.app.entity.Distribuidor distribuidor)
            {
                string sp = "SetDistribuidor";
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
                        oracleCom.Parameters.Add("V_RutDistribuidor", OracleType.VarChar); oracleCom.Parameters[0].Value = distribuidor.RutDistruidor;
                        oracleCom.Parameters.Add("V_NombreDistribuidor", OracleType.VarChar); oracleCom.Parameters[1].Value = distribuidor.NombreDistribuidor;
                        oracleCom.Parameters.Add("V_Rubro", OracleType.VarChar); oracleCom.Parameters[2].Value = distribuidor.Rubro;
                        oracleCom.Parameters.Add("V_Telefono", OracleType.Number); oracleCom.Parameters[3].Value = distribuidor.Telefono;
                        oracleCom.Parameters.Add("V_CantidadSolicitada", OracleType.Number); oracleCom.Parameters[4].Value = distribuidor.CantidadSolicitada;
                        oracleCom.Parameters.Add("V_Precio", OracleType.Number); oracleCom.Parameters[5].Value = distribuidor.Precios;
                        
                        oracleCon.Open();
                        oracleCom.ExecuteNonQuery();

                    }
                    return true;
                }
                catch (Exception ex) { return false; }

            }
            //actualiza datos en la BDD*/
            public bool UpdDistribuidor(Entidades.app.entity.Distribuidor distribuidor)
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
                        oracleCom.Parameters.Add("V_RutDistribuidor", OracleType.VarChar); oracleCom.Parameters[0].Value = distribuidor.RutDistruidor;
                        oracleCom.Parameters.Add("V_NombreDistribuidor", OracleType.VarChar); oracleCom.Parameters[1].Value = distribuidor.NombreDistribuidor;
                        oracleCom.Parameters.Add("V_Rubro", OracleType.VarChar); oracleCom.Parameters[2].Value = distribuidor.Rubro;
                        oracleCom.Parameters.Add("V_Telefono", OracleType.Number); oracleCom.Parameters[3].Value = distribuidor.Telefono;
                        oracleCom.Parameters.Add("V_CantidadSolicitada", OracleType.Number); oracleCom.Parameters[4].Value = distribuidor.CantidadSolicitada;
                        oracleCom.Parameters.Add("V_Precio", OracleType.Number); oracleCom.Parameters[5].Value = distribuidor.Precios;

                        oracleCon.Open();
                        oracleCom.ExecuteNonQuery();

                    }
                    return true;
                }
                catch (Exception ex) { return false; }

            }
            //lista los datos de la BDD */
            public List<Entidades.app.entity.Distribuidor> GetDistribuidor()
            {
                List<Entidades.app.entity.Distribuidor> distribuidores = new List<Entidades.app.entity.Distribuidor>();
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
                        oracleCom.CommandText = "SELECT * FROM vw_";
                        //oracleCom.CommandType = CommandType.StoredProcedure;
                        //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                        OracleDataReader rs = oracleCom.ExecuteReader();

                        while (rs.Read())
                        {
                            Entidades.app.entity.Distribuidor distribuidor = new Entidades.app.entity.Distribuidor();
                            distribuidor.RutDistruidor = rs["Rutdistribuidor"].ToString();
                            distribuidor.NombreDistribuidor = rs["NombreDistribuidor"].ToString();
                            distribuidor.Rubro = rs["Rubro"].ToString();
                            int.TryParse(rs["Telefono"].ToString(), out pasoInt);
                            distribuidor.Telefono = pasoInt;
           
                            pasoInt = 0; int.TryParse(rs["CantidadSolicitada"].ToString(), out pasoInt);
                            distribuidor.CantidadSolicitada = pasoInt;
                            pasoInt = 0; int.TryParse(rs["Precios"].ToString(), out pasoInt);
                            distribuidor.Precios = pasoInt;

                            distribuidores.Add(distribuidor);
                        }
                    }
                    return distribuidores;
                }
                catch (Exception) { return null; }
            }
        }
    }
}
