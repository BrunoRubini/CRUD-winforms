using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.Id,Codigo,Nombre,A.Descripcion,ImagenUrl,Precio,M.Descripcion As Marca,C.Descripcion As Categoria,A.IdMarca,A.IdCategoria from ARTICULOS A,MARCAS M,CATEGORIAS C where A.IdMarca=M.Id And A.IdCategoria=C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)(datos.Lector["Precio"]);
                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)(datos.Lector["IdMarca"]);
                    aux.Marca.Descripcion = (string)(datos.Lector["Marca"]);
                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)(datos.Lector["IdCategoria"]);
                    aux.Categoria.Descripcion = (string)(datos.Lector["Categoria"]);

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
