using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class PerfilamientoEntity
    {
        private Decimal id;
        private String tipo;

        public PerfilamientoEntity()
        {

        }

        public PerfilamientoEntity(decimal id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }

        public decimal Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return "ID: " + id +
                    "TIPO: " + tipo + "\n";
        }
    }
}
