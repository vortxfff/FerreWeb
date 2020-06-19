using System;              
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{ 
    public class Producto
    {
        public DateTime FechaVencimiento { get; set; }
        public long IDTipo { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public int StockCritico { get; set; }
        public String Descripcion { get; set; }

        public Producto()
        { }            

    }
}
