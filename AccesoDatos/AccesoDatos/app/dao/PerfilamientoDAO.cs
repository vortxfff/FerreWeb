using AccesoDatos.DataSet1TableAdapters;
using Entidades.app.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AccesoDatos.DataSet1;

namespace AccesoDatos.app.dao
{
    public class PerfilamientoDAO
    {
        /// <summary>
        /// Método encargado de buscar todos los perfilamientos de las tablas
        /// </summary>
        /// <returns></returns>
        public List<PerfilamientoEntity> BuscarTodo() {

            // Creamos lista vacía
            List<PerfilamientoEntity> perfilamientos = new List<PerfilamientoEntity>();
            // Creamos adaptador con métodos sobre la tabla PERFILAMIENTO
            PERFILAMIENTOTableAdapter adapter = new PERFILAMIENTOTableAdapter();
            // Bloque que captura excepciones de conexión o problemas
            // Con la base de datos
            try {
                // Método GetData() Obtiene DataTable con todas las filas de la tabla
                foreach (PERFILAMIENTORow fila in adapter.GetData())
                {
                    // Creamos objeto con datos de la fila de la tabla obtenida
                    PerfilamientoEntity perfilamiento = new PerfilamientoEntity();
                    perfilamiento.Id = fila.ID;
                    perfilamiento.Tipo = fila.TIPO;
                    // Agregamo objeto perfilamiento en la lista
                    perfilamientos.Add(perfilamiento);
                }
            }
            catch (Exception ex) {

                Debug.WriteLine("ERROR PERFILAMIENTO DAO . BUSCAR TODO -> " + ex.Message);
            }

            return perfilamientos;
        }

        /// <summary>
        /// Método encargado de crear un perfilamiento
        /// </summary>
        /// <param name="perfilamiento"></param>
        /// <returns></returns>
        public bool Crear(PerfilamientoEntity perfilamiento) {
            // variable con resultado de la inserción
            bool resultado = false;
            // Creamos adaptador con métodos sobre la tabla PERFILAMIENTO
            PERFILAMIENTOTableAdapter adapter = new PERFILAMIENTOTableAdapter();
            // Bloque que captura excepciones de conexión o problemas
            // Con la base de datos
            try
            {
                int ejec = adapter.Insert(perfilamiento.Tipo, perfilamiento.Id);

                if (ejec == 1) {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine("ERROR PERFILAMIENTO DAO . CREAR -> " + ex.Message);
            }

            return resultado;
        }

        /// <summary>
        /// Método encargado de actualizar un perfilamiento
        /// </summary>
        /// <param name="perfilamiento"></param>
        /// <returns></returns>
        public bool Actualizar(PerfilamientoEntity perfilamiento)
        {
            // variable con resultado de la inserción
            bool resultado = false;
            // Creamos adaptador con métodos sobre la tabla PERFILAMIENTO
            PERFILAMIENTOTableAdapter adapter = new PERFILAMIENTOTableAdapter();
            // Bloque que captura excepciones de conexión o problemas
            // Con la base de datos
            try
            {
                int ejec = adapter.ActualizarPorId(perfilamiento.Tipo, perfilamiento.Id);

                if (ejec == 1)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine("ERROR PERFILAMIENTO DAO . ACTUALIZAR -> " + ex.Message);
            }

            return resultado;
        }

        /// <summary>
        /// Método encargado de borrar por id un perfilamiento
        /// </summary>
        /// <param name="perfilamiento"></param>
        /// <returns></returns>
        public bool BorrarPorId(Decimal id)
        {
            // variable con resultado de la inserción
            bool resultado = false;
            // Creamos adaptador con métodos sobre la tabla PERFILAMIENTO
            PERFILAMIENTOTableAdapter adapter = new PERFILAMIENTOTableAdapter();
            // Bloque que captura excepciones de conexión o problemas
            // Con la base de datos
            try
            {
                int ejec = adapter.BorrarPorId(id);

                if (ejec == 1)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine("ERROR PERFILAMIENTO DAO . BORRAR POR ID-> " + ex.Message);
            }

            return resultado;
        }
    }
}
