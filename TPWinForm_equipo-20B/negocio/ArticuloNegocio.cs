using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Nombre, Descripcion, IdCategoria, IdMarca, Precio from ARTICULOS;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.idArticulo = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Marca = new Marca();
                    aux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Precio = (decimal)datos.Lector["Precio"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
                "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                "VALUES ('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " +
                nuevo.Marca.IdMarca + ", " + nuevo.Categoria.IdCategoria + ", " + nuevo.Precio + ")"
                  );
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.CerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
