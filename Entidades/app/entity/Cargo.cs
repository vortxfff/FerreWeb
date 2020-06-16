using System;
using System.Collections.Generic;
using System.Text;

namespace Entidadesapp.entity
{
    public class Cargo
    {
        public int ID { get; set; }
        public String Descripcion { get; set; }


        public Cargo()
        {

        }
        public Cargo(int ID, String Descripcion, bool Estado)
        {
            this.ID = ID;
            this.Descripcion = Descripcion;

        }
    }
}
