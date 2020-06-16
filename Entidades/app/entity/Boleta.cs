using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class Boleta
    {
        public int SumaPrecio { get; set; }
        public int Total { get; set; }

        public Boleta()
        {
        }

        public Boleta(int SumaPrecio, int Total)
        {

            this.SumaPrecio = SumaPrecio;
            this.Total = Total;

        }
    }

}
