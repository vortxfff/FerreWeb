using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class Boleta
    {
        public int IDBoleta { get; set; }
        public int IDproducto { get; set; }
        public String NombreProducto { get; set; }
        public int SumaPrecio { get; set; }
        public int Total { get; set; }

        public Boleta()
        {
        }

        public Boleta( int IDBoleta, int IDproducto, String NombreProducto, int SumaPrecio, int Total)
        {
            this.IDBoleta = IDBoleta;
            this.IDproducto = IDproducto;
            this.NombreProducto = NombreProducto;
            this.SumaPrecio = SumaPrecio;
            this.Total = Total;

        }
    }

}
