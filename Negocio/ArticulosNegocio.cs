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
        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)";
                datos.setearConsulta(consulta);
                datos.setearParametros("@Codigo", nuevo.Codigo);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@IdMarca", nuevo.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
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
        public void modificar(Articulos modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre,Descripcion=@desc," +
                    "ImagenUrl=@img,IdMarca=@idMarca,IdCategoria=@idCategoria,Precio=@precio where Id=@id");
                datos.setearParametros("@codigo", modificado.Codigo);
                datos.setearParametros("@nombre", modificado.Nombre);
                datos.setearParametros("@desc", modificado.Descripcion);
                datos.setearParametros("@img", modificado.ImagenUrl);
                datos.setearParametros("@idMarca", modificado.Marca.Id);
                datos.setearParametros("@idCategoria", modificado.Categoria.Id);
                datos.setearParametros("@precio", modificado.Precio);
                datos.setearParametros("@id", modificado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminar(int id) // uso de parametro el id del articulo
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
