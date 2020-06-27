using Entidades.app.entity;
using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.app.dao;

namespace Negocio
{
    public class EmpleadoBO
    {
        public void InsertaEmpleado(Empleado empleados)
        {
            try
            {
                new EmpleadosDAO().SetEmpleado(empleados);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Empleado> RescataEmpleados()
        {
            try
            {
                return new EmpleadosDAO().GetEmpleados();
            }
            catch (Exception ex) { throw ex; }
        }
        public void ActualizaEmpleados(Empleado empleados)
        {
            try
            {
                new EmpleadosDAO().UpdEmpleados(empleados);
            }
            catch (Exception ex) { throw ex; }
        }
    }

}