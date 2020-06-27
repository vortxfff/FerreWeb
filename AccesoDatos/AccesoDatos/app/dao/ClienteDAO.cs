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
    public class ClienteDAO
    {
        /** inserta datos a la base de datos//
         */
        public bool SetCliente(Entidades.app.entity.Cliente cliente)
        {
            string sp = "SetCliente";
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
                    oracleCom.Parameters.Add("V_nombre", OracleType.VarChar); oracleCom.Parameters[0].Value = cliente.Nombre;
                    oracleCom.Parameters.Add("V_apellido", OracleType.VarChar); oracleCom.Parameters[1].Value = cliente.Apellido;
                    oracleCom.Parameters.Add("V_direccion", OracleType.VarChar); oracleCom.Parameters[2].Value = cliente.Direccion;
                    oracleCom.Parameters.Add("V_correo", OracleType.VarChar); oracleCom.Parameters[3].Value = cliente.Correo;
                    oracleCom.Parameters.Add("V_rut", OracleType.VarChar); oracleCom.Parameters[4].Value = cliente.Rut;                     
                    oracleCom.Parameters.Add("V_telefono", OracleType.Number); oracleCom.Parameters[5].Value = cliente.Telefono;
                    oracleCom.Parameters.Add("V_empresa", OracleType.Number); oracleCom.Parameters[6].Value = cliente.Empresa;


                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //actualiza datos en la BDD*/
        public bool UpdCliente(Entidades.app.entity.Cliente cliente)
        {
            string sp = "UpdClientes";
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
                    oracleCom.Parameters.Add("v_personaid", OracleType.Number); oracleCom.Parameters[0].Value = cliente.PersonaId;
                    oracleCom.Parameters.Add("v_nombre", OracleType.VarChar); oracleCom.Parameters[1].Value = cliente.Nombre;
                    oracleCom.Parameters.Add("v_apellido", OracleType.VarChar); oracleCom.Parameters[2].Value = cliente.Apellido;
                    oracleCom.Parameters.Add("v_direccion", OracleType.VarChar); oracleCom.Parameters[3].Value = cliente.Direccion;
                    oracleCom.Parameters.Add("v_correo", OracleType.VarChar); oracleCom.Parameters[4].Value = cliente.Correo;
                    oracleCom.Parameters.Add("v_rut", OracleType.VarChar); oracleCom.Parameters[5].Value = cliente.Rut;
                    oracleCom.Parameters.Add("v_telefono", OracleType.Number); oracleCom.Parameters[6].Value = cliente.Telefono;
                    oracleCom.Parameters.Add("v_empresa", OracleType.Number); oracleCom.Parameters[7].Value = cliente.Empresa;


                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //lista los datos de la BDD */
        public List<Entidades.app.entity.Cliente> GetClientes()
        {
            List<Entidades.app.entity.Cliente> clientes = new List<Entidades.app.entity.Cliente>();
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
                    oracleCom.CommandText = "SELECT * FROM vw_Clientes";
                    //oracleCom.CommandType = CommandType.StoredProcedure;
                    //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                    OracleDataReader rs = oracleCom.ExecuteReader();

                    while (rs.Read())
                    {
                        Entidades.app.entity.Cliente cliente = new Entidades.app.entity.Cliente();
                        cliente.Rut = rs["Rut"].ToString();
                        cliente.Nombre = rs["Nombre"].ToString();
                        cliente.Apellido = rs["Apellido"].ToString();
                        cliente.Direccion = rs["Direccion"].ToString();
                        cliente.Correo = rs["Correo"].ToString();
                        int.TryParse(rs["Empresa"].ToString(), out pasoInt);
                        cliente.Empresa = pasoInt;
                        long.TryParse(rs["Telefono"].ToString(), out pasoLong);
                        cliente.Telefono = pasoLong;
                        pasoInt = 0; int.TryParse(rs["PERSONA_PERSONA_ID"].ToString(), out pasoInt);
                        cliente.PersonaId = pasoInt;
                        pasoInt = 0; int.TryParse(rs["ID"].ToString(), out pasoInt);
                        cliente.ClienteId = pasoInt;

                        clientes.Add(cliente);
                    }
                }
                return clientes;
            }
            catch (Exception) { return null; }
        }
    }
}
