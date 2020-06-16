using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class Factura
    {
        public int SumaPrecio { get; set; }
        public int Iva { get; set; }
        public int Total { get; set; }

        public Factura()
        {
        }

        public Factura(int SumaPrecio, int Iva, int Total)
        {

            this.SumaPrecio = SumaPrecio;
            this.Iva = Iva;
            this.Total = Total;

        }
    }
}
