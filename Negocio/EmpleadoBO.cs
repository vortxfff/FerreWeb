using Entidades.app.entity;
using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.impl;

namespace Negocio
{
    public class EmpleadoBO
    {
        public void InsertaEmpleado(Empleados empleados)
        {
            try
            {
                new EmpleadosDAO().SetEmpleado(empleados);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Empleados> RescataEmpleados()
        {
            try
            {
                return new EmpleadosDAO().GetEmpleados();
            }
            catch (Exception ex) { throw ex; }
        }
        public void ActualizaEmpleados(Empleados empleados)
        {
            try
            {
                new EmpleadosDAO().UpdEmpleados(empleados);
            }
            catch (Exception ex) { throw ex; }
        }
    }

}