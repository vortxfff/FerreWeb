using AccesoDatos.app.dao;
using Entidades.app.entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.app.persistencia
{
    [TestClass]
    public class PerfilamientoDAOTesting
    {

        [TestMethod]
        public void TestCrear()
        {
            PerfilamientoDAO perfilamientoDAO = new PerfilamientoDAO();

            int id = perfilamientoDAO.BuscarTodo().Count() + 1;
            PerfilamientoEntity perfil = new PerfilamientoEntity();
            perfil.Id = id;
            perfil.Tipo = "TEST " + id;

            bool resultado = perfilamientoDAO.Crear(perfil);
            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void TestBuscarTodo()
        {
            PerfilamientoDAO perfilamientoDAO = new PerfilamientoDAO();

            List<PerfilamientoEntity> perfilamientos = perfilamientoDAO.BuscarTodo();

            foreach (PerfilamientoEntity perfilamiento in perfilamientos)
            {                Debug.WriteLine(perfilamiento);
            }

            Assert.IsTrue(perfilamientos.Count() > 0);
        }

        [TestMethod]
        public void TestBorrar()
        {
            PerfilamientoDAO perfilamientoDAO = new PerfilamientoDAO();
            int id = perfilamientoDAO.BuscarTodo().Count() + 1;

            bool resultado = perfilamientoDAO.BorrarPorId(0);
            Assert.IsTrue(resultado);
        }
        [TestMethod]

        public void TestInsertarClient()
        {
            Cliente cliente = new Cliente()
            {
                Nombre = "Jonathan",
                Apellido = "Hernandez",
                Telefono =45545465,
                Rut = "12345678-8",
                Direccion = "csmahsaljs 1254",
                Empresa = 0,
                Correo = "algoa@algo.cl"
            };

            new Negocio.ClienteBO().InsertaCliente(cliente);
        }
        [TestMethod]
        public void TestRescataCliente()
        {
            List<Cliente> clientes = new Negocio.ClienteBO().RescataClientes();

            Cliente cliente = clientes.FirstOrDefault(o => o.Rut == "12345678-8");

            cliente.Nombre = "Jona";

            new Negocio.ClienteBO().ActualizaCliente(cliente);

            clientes = new Negocio.ClienteBO().RescataClientes();

            cliente = clientes.FirstOrDefault(o => o.Rut == "12345678-8");

        }
    }
}
