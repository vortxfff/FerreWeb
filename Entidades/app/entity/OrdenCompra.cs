using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class OrdenCompra
    {
        public int NumeroOC { get; set; }
        public int sumaprecio { get; set; }
        public int Iva { get; set; }
        public int Total { get; set; }

        public OrdenCompra() { }

        public OrdenCompra(int NumeroOC, int sumaprecio, int Iva, int Total)
        {

            this.NumeroOC = NumeroOC;
            this.sumaprecio = sumaprecio;
            this.Iva = Iva;
            this.Total = Total;
        }
    }
}
