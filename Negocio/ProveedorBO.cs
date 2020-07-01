using Entidades.app.entity;
using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.app.dao;
using AccesoDatos.app.impl.AccesoDatos.app.dao;

namespace Negocio
{
    public class ProveedorBO 

    {
        public void InsertaProveedor(Proveedor proveedor)
        {
            try
            {
                new ProveedorDAO().SetProveedor(proveedor);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Proveedor> RescataDistribuidor()
        {
            try
            {
                return new ProveedorDAO().GetProveedor();
            }
            catch (Exception ex) { throw ex; }
        }
        public void ActualizaProveedor(Proveedor distribuidor)
        {
            try
            {
                new ProveedorDAO().UpdProveedor(distribuidor);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}