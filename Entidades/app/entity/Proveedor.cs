using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class Proveedor
    {
        public String IDProveedor { get; set; }
        public String NombreProveedor { get; set; }
        public String Rubro { get; set; }
        public int Telefono { get; set; }
     

        public Proveedor()
        {
        }

        public Proveedor(String RutProveedor, String NombreProveedor, String Rubro, int Telefono)

        {
            this.IDProveedor = IDProveedor;
            this.NombreProveedor = NombreProveedor;
            this.Rubro = Rubro;
            this.Telefono = Telefono;
           
        }
    }
}
