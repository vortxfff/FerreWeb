using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class InformeEstadistica
    {
        public String TipoDocumento { get; set; }
        public String Formato { get; set; }

        public InformeEstadistica()
        {
        }

        public InformeEstadistica(String TipoDocumento, String Formato)
        {

            this.TipoDocumento = TipoDocumento;
            this.Formato = Formato;

        }
    }
}
