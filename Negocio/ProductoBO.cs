using Entidades.app.entity;
using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.app.dao;


namespace Negocio
{
    public class ProductoBO
    {
        public void InsertaProducto(Producto producto)
        {
            try
            {
                new ProductoDAO().SetProducto(producto);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Producto> RescataProductos()
        {
            try
            {
                return new ProductoDAO().GetProducto();
            }
            catch (Exception ex) { throw ex; }
        }
        public void ActualizaProductos(Producto producto)
        {
            try
            {
                new ProductoDAO().UpdProducto(producto);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

