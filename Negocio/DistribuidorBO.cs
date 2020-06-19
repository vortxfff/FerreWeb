using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.app.impl.AccesoDatos.impl;
using AccesoDatos.impl;
using Entidades.app.entity;

namespace Negocio
{
    public class DistribuidorBO 

    {
        public void InsertaDistribuidor(Distribuidor distribuidor)
        {
            try
            {
                new DistribidorDAO().SetCliente(distribuidor);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Distribuidor> RescataDistribuidor()
        {
            try
            {
                return new DistribidorDAO().GetDistribuidor();
            }
            catch (Exception ex) { throw ex; }
        }
        public void Actualizadistribuidor(Distribuidor distribuidor)
        {
            try
            {
                new DistribidorDAO().UpdDistribuidor(distribuidor);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}