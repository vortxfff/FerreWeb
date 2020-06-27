using Entidades.app.entity;
using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.app.dao;

namespace Negocio
{
    public class BoletaBO
    {
        public void InsertaBoleta(Boleta boleta)
        {
            try
            {
                new BoletaDAO().SetBoleta(boleta);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Boleta> RescataClientes()
        {
            try
            {
                return new BoletaDAO().GetBoletas();
            }
            catch (Exception ex) { throw ex; }
        }
        public void ActualizaBoleta(Boleta boleta)
        {
            try
            {
                new BoletaDAO().UpdBoleta(boleta);
            }
            catch (Exception ex) { throw ex; }
        }
    }

}