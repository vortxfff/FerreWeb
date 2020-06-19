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
    public class EmpleadosDAO
    {
        /** inserta datos a la base de datos//
         */
        public bool SetEmpleado(Entidades.app.entity.Empleado empleados)
        {
            string sp = "set empleados";
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
                    oracleCom.Parameters.Add("nombre", OracleType.VarChar); oracleCom.Parameters[0].Value = empleados.Nombre;
                    oracleCom.Parameters.Add("apellido", OracleType.VarChar); oracleCom.Parameters[1].Value = empleados.Apellido;
                    oracleCom.Parameters.Add("direccion", OracleType.VarChar); oracleCom.Parameters[2].Value = empleados.Direccion;
                    oracleCom.Parameters.Add("correo", OracleType.VarChar); oracleCom.Parameters[3].Value = empleados.Correo;
                    oracleCom.Parameters.Add("rut", OracleType.VarChar); oracleCom.Parameters[4].Value = empleados.Rut;
                    oracleCom.Parameters.Add("telefono", OracleType.Number); oracleCom.Parameters[5].Value = empleados.Telefono;
                    oracleCom.Parameters.Add("cargo", OracleType.VarChar); oracleCom.Parameters[6].Value = empleados.Cargo;


                    oracleCon.Open();
                    oracleCom.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex) { return false; }

        }

        //actualiza datos en la BDD*/
        public bool UpdEmpleados(Entidades.app.entity.Empleado empleados)
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
                    oracleCom.Parameters.Add("v_personaid", OracleType.Number); oracleCom.Parameters[0].Value = empleados.Persona_ID;
                    oracleCom.Parameters.Add("v_nombre", OracleType.VarChar); oracleCom.Parameters[1].Value = empleados.Nombre;
                    oracleCom.Parameters.Add("v_apellido", OracleType.VarChar); oracleCom.Parameters[2].Value = empleados.Apellido;
                    oracleCom.Parameters.Add("v_direccion", OracleType.VarChar); oracleCom.Parameters[3].Value = empleados.Direccion;
                    oracleCom.Parameters.Add("v_correo", OracleType.VarChar); oracleCom.Parameters[4].Value = empleados.Correo;
                    oracleCom.Parameters.Add("v_rut", OracleType.VarChar); oracleCom.Parameters[5].Value = empleados.Rut;
                    oracleCom.Parameters.Add("v_telefono", OracleType.Number); oracleCom.Parameters[6].Value = empleados.Telefono;
                   


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
                        oracleCom.CommandText = "SELECT * FROM vw_empleados crear";
                        //oracleCom.CommandType = CommandType.StoredProcedure;
                        //oracleCom.Parameters.Add("@Rut", OracleType.VarChar); oracleCom.Parameters[0].Value = Rut;
                        OracleDataReader rs = oracleCom.ExecuteReader();

                        while (rs.Read())
                        {
                            Entidades.app.entity.Empleado empleado = new Entidades.app.entity.Empleado();
                            empleado.Rut = rs["Rut"].ToString();
                            empleado.Nombre = rs["Nombre"].ToString();
                            empleado.Apellido = rs["Apellido"].ToString();
                            empleado.Direccion = rs["Direccion"].ToString();
                            empleado.Correo = rs["Correo"].ToString();
                            long.TryParse(rs["Telefono"].ToString(), out pasoLong);
                            empleado.Telefono = pasoLong;
                            pasoInt = 0; int.TryParse(rs["PERSONA_PERSONA_ID"].ToString(), out pasoInt);
                            empleado.Persona_ID = pasoInt;


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
