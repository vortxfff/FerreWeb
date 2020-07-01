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
    public class EmpleadosDAO
    {
        /** inserta datos a la base de datos//
         */
        public bool SetEmpleado(Entidades.app.entity.Empleado empleados)
        {
            string sp = "setEmpleados";
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
                    oracleCom.Parameters.Add("V_nombre", OracleType.VarChar); oracleCom.Parameters[0].Value = empleados.Nombre;
                    oracleCom.Parameters.Add("V_apellido", OracleType.VarChar); oracleCom.Parameters[1].Value = empleados.Apellido;
                    oracleCom.Parameters.Add("V_direccion", OracleType.VarChar); oracleCom.Parameters[2].Value = empleados.Direccion;
                    oracleCom.Parameters.Add("V_correo", OracleType.VarChar); oracleCom.Parameters[3].Value = empleados.Correo;
                    oracleCom.Parameters.Add("V_rut", OracleType.VarChar); oracleCom.Parameters[4].Value = empleados.Rut;
                    oracleCom.Parameters.Add("V_telefono", OracleType.Number); oracleCom.Parameters[5].Value = empleados.Telefono;
                    oracleCom.Parameters.Add("V_cargo", OracleType.VarChar); oracleCom.Parameters[6].Value = empleados.Cargo;


                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }

        //actualiza datos en la BDD*/
        public bool UpdEmpleados(Entidades.app.entity.Empleado empleado)
        {
            string sp = "UpdEmpleados";
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
                    oracleCom.Parameters.Add("V_personaid", OracleType.Number); oracleCom.Parameters[0].Value = empleado.Persona_ID;
                    oracleCom.Parameters.Add("V_nombre", OracleType.VarChar); oracleCom.Parameters[1].Value = empleado.Nombre;
                    oracleCom.Parameters.Add("V_apellido", OracleType.VarChar); oracleCom.Parameters[2].Value = empleado.Apellido;
                    oracleCom.Parameters.Add("V_direccion", OracleType.VarChar); oracleCom.Parameters[3].Value = empleado.Direccion;
                    oracleCom.Parameters.Add("V_correo", OracleType.VarChar); oracleCom.Parameters[4].Value = empleado.Correo;
                    oracleCom.Parameters.Add("V_rut", OracleType.VarChar); oracleCom.Parameters[5].Value = empleado.Rut;
                    oracleCom.Parameters.Add("V_telefono", OracleType.Number); oracleCom.Parameters[6].Value = empleado.Telefono;
                    oracleCom.Parameters.Add("V_cargo", OracleType.VarChar); oracleCom.Parameters[7].Value = empleado.Cargo;



                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }
        //lista los datos de la BDD */
        public List<Entidades.app.entity.Empleado> GetEmpleados()
        {
           
            {
                List<Entidades.app.entity.Empleado> empleados = new List<Entidades.app.entity.Empleado>();
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
                        oracleCom.CommandText = "SELECT * FROM vw_empleados";
                        //oracleCom.CommandType = CommandType.StoredProcedure;
                        //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                        OracleDataReader rs = oracleCom.ExecuteReader();

                        while (rs.Read())
                        {
                            Entidades.app.entity.Empleado empleado = new Entidades.app.entity.Empleado();
                            pasoInt = 0; int.TryParse(rs["PERSONA_PERSONA_ID"].ToString(), out pasoInt);
                            empleado.Persona_ID = pasoInt;
                            empleado.Rut = rs["Rut"].ToString();
                            empleado.Nombre = rs["Nombre"].ToString();
                            empleado.Apellido = rs["Apellido"].ToString();
                            empleado.Direccion = rs["Direccion"].ToString();
                            empleado.Correo = rs["Correo"].ToString();
                            long.TryParse(rs["Telefono"].ToString(), out pasoLong);
                            empleado.Telefono = pasoLong;
                            


                            empleados.Add(empleado);
                        }
                    }
                    return empleados;
                }
                catch (Exception) { return null; }
            }
        }
    }
}
