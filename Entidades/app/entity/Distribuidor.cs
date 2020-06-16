using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class Distribuidor
    {
        public String RutDistruidor { get; set; }
        public String NombreDistribuidor { get; set; }
        public String Rubro { get; set; }
        public int Telefono { get; set; }
        public int CantidadSolicitada { get; set; }
        public int Precios { get; set; }

        public Distribuidor()
        {
        }

        public Distribuidor(String RutDistruidor, String NombreDistribuidor, String Rubro, int Telefono, int CantidadSolicitada, int Precios)

        {
            this.RutDistruidor = RutDistruidor;
            this.NombreDistribuidor = NombreDistribuidor;
            this.Rubro = Rubro;
            this.Telefono = Telefono;
            this.CantidadSolicitada = CantidadSolicitada;
            this.Precios = Precios;
        }
    }
}
