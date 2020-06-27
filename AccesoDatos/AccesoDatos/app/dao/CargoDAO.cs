using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using Entidades.app.entity;

namespace AccesoDatos.app.dao
{
    public class CargoDAO
    {
        /** inserta datos a la base de datos//
         */
        public bool SetCargo(Entidades.app.entity.Cargo cargo)
        {
            string sp = "SetCargo";
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
                    oracleCom.Parameters.Add("V_ID", OracleType.VarChar); oracleCom.Parameters[0].Value = cargo.ID;
                    oracleCom.Parameters.Add("V_Descripcion", OracleType.VarChar); oracleCom.Parameters[1].Value = cargo.Descripcion;
                   
                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //actualiza datos en la BDD*/
        public bool UpdCargo(Entidades.app.entity.Cargo cargo)
        {
            string sp = "UpdCargo";
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
                    oracleCom.Parameters.Add("V_ID", OracleType.VarChar); oracleCom.Parameters[0].Value = cargo.ID;
                    oracleCom.Parameters.Add("V_Descripcion", OracleType.VarChar); oracleCom.Parameters[1].Value = cargo.Descripcion;

                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //lista los datos de la BDD */
        public List<Entidades.app.entity.Cargo> GetCargo()
        {
            List<Entidades.app.entity.Cargo> cargos = new List<Entidades.app.entity.Cargo>();
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
                    oracleCom.CommandText = "SELECT * FROM vw_Clientes";
                    //oracleCom.CommandType = CommandType.StoredProcedure;
                    //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                    OracleDataReader rs = oracleCom.ExecuteReader();

                    while (rs.Read())
                    {
                        Entidades.app.entity.Cargo cargo = new Entidades.app.entity.Cargo();
                        pasoInt = 0; int.TryParse(rs["ID"].ToString(), out pasoInt);
                        cargo.ID = pasoInt;
                        cargo.Descripcion = rs["Descripcion"].ToString();
                        
                       

                        cargos.Add(cargo);
                    }
                }
                return cargos;
            }
            catch (Exception) { return null; }
        }
    }
}

