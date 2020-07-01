using Entidades.app.entity;
using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.app.dao;

namespace Negocio
{
    public class ClienteBO
    {
        public void InsertaCliente(Cliente cliente)
        {
            try
            {
                new ClienteDAO().SetCliente(cliente);
            }
            catch(Exception ex) { throw ex; }            
        }

     

     
        public List<Cliente> RescataClientes()
        {
            try
            {
                return new ClienteDAO().GetClientes();
            }
            catch(Exception ex) { throw ex; }
        }
       
        
        
        public void ActualizaCliente(Cliente cliente)
        {
            try
            {
                new ClienteDAO().UpdCliente(cliente);
            }
            catch (Exception ex) { throw ex; }
        }
    }
    
}
