using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.app.entity
{
    public class Cliente
    {
        public String Rut { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public int Empresa { get; set; }
        public String Usuario { get; set; }
        public long Telefono { get; set; }
        public int PersonaId { get; set; }
        public int ClienteId { get; set; }



        /*
        public Cliente()
        {
        }
        public Cliente(String Rut, String Nombre, String Apellido, String Email, String Clave, String Direccion, int Empresa, String RutEmpresa,
            String Usuario, int Telefono, int PersonaId, int ClienteId)
        {
            this.Rut = Rut;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Clave = Clave;
            this.Direccion = Direccion;
            this.Empresa = Empresa;
            this.Usuario = Usuario;
            this.RutEmpresa = RutEmpresa;
            this.Usuario = Usuario;
            this.Telefono = Telefono;
            this.PersonaId = PersonaId;
            this.ClienteId = ClienteId;

        }*/
    }
}
