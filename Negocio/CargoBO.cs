using Entidades.app.entity;
using System;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.app.dao;

namespace Negocio
{
    public class CargoBO
    {
        public void InsertaCargo(Cargo cargo)
        {
            try
            {
                new CargoDAO().SetCargo(cargo);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Cargo> RescataCargos()
        {
            try
            {
                return new CargoDAO().GetCargo();
            }
            catch (Exception ex) { throw ex; }
        }
        public void ActualizaCargo(Cargo cargo)
        {
            try
            {
                new CargoDAO().UpdCargo(cargo);
            }
            catch (Exception ex) { throw ex; }
        }
    }

}
