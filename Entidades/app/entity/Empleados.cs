using Entidadesapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class Empleados
    {


        public String Rut { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Correo { get; set; }
        public long Telefono { get; set; }
        public Cargo Cargo { get; set; }
        public String Usuario { get; set; }
        public String Direccion { get; set; }
        public String Clave { get; set; }
        public int Persona_ID { get; set; }

        public Empleados()
        { }

        public Empleados(string rut, string nombre, string apellido, Cargo cargo, string usuario, string clave)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Cargo = cargo;
            Usuario = usuario;
            Clave = clave;
        }




    }
}
