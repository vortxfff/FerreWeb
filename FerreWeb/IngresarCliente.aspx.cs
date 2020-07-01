using Entidades.app.entity;
using Oracle.ManagedDataAccess.Client;
using System;


namespace FerreWeb
{
    public partial class IngresarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();
            {
                cliente.Nombre = TextNombre.Text;
                cliente.Apellido = TextApellido.Text;
                cliente.Direccion = TextDireccion.Text;
                cliente.Correo = TextEmail.Text;
                cliente.Rut = txtRut.Text;
                long telefono = int.Parse(TextTelefono.Text);
                cliente.Telefono = telefono;
                int empresa = int.Parse(txtEmpresa.Text);
                cliente.Empresa = empresa;
                //cliente.Empresa = txtEmpresa.Checked;
                
            };


            new Negocio.ClienteBO().InsertaCliente(cliente);

        }
    }
}
