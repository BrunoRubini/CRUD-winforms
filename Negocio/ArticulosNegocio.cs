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
        public void agregar(Articulos nuevo) // Agregar un articulo a la bd
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
        public void modificar(Articulos modificado) // Modificar un articulo de la bd
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
        public void eliminar(int id) //Eliminar un articulo de la bd, uso de parametro el id del articulo
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
        public List<Articulos> filtrar(string campo, string criterio, string filtro) // Filtro de búsqueda
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id,Codigo,Nombre,A.Descripcion,ImagenUrl,Precio,M.Descripcion As Marca,C.Descripcion As Categoria,A.IdMarca,A.IdCategoria from ARTICULOS A,MARCAS M,CATEGORIAS C where A.IdMarca=M.Id And A.IdCategoria=C.Id And ";
                if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Descripción")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    consulta += "M.Descripcion = '" + criterio + "'";
                }
                else
                {
                    consulta += "C.Descripcion = '" + criterio + "'";
                }



                datos.setearConsulta(consulta);
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
        }
        public List<Articulos> filtrar(string campo, string criterio, string filtro, string campo1, string criterio1, string filtro1) // Filtro de búsqueda con 2 Campos
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id,Codigo,Nombre,A.Descripcion,ImagenUrl,Precio,M.Descripcion As Marca,C.Descripcion As Categoria,A.IdMarca,A.IdCategoria from ARTICULOS A,MARCAS M,CATEGORIAS C where A.IdMarca=M.Id And A.IdCategoria=C.Id And ";
                if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Descripción")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    consulta += "M.Descripcion = '" + criterio + "'";
                }
                else
                {
                    consulta += "C.Descripcion = '" + criterio + "'";
                }
                if (campo1 == "Nombre") // Segundo Campo
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "And Nombre like '" + filtro1 + "%' ";
                            break;
                        case "Termina con":
                            consulta += "And Nombre like '%" + filtro1 + "'";
                            break;
                        default:
                            consulta += "And Nombre like '%" + filtro1 + "%'";
                            break;
                    }
                }
                else if (campo1 == "Descripción")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "And A.Descripcion like '" + filtro1 + "%' ";
                            break;
                        case "Termina con":
                            consulta += "And A.Descripcion like '%" + filtro1 + "'";
                            break;
                        default:
                            consulta += "And A.Descripcion like '%" + filtro1 + "%'";
                            break;
                    }
                }
                else if (campo1 == "Marca")
                {
                    consulta += "And M.Descripcion = '" + criterio1 + "'";
                }
                else
                {
                    consulta += "And C.Descripcion = '" + criterio1 + "'";
                }



                datos.setearConsulta(consulta);
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
        }
        public List<Articulos> ordenar(string campo, string criterio) // Ordenar la lista de articulos segun criterio y campo
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id,Codigo,Nombre,A.Descripcion,ImagenUrl,Precio,M.Descripcion As Marca,C.Descripcion As Categoria,A.IdMarca,A.IdCategoria from ARTICULOS A,MARCAS M,CATEGORIAS C where A.IdMarca=M.Id And A.IdCategoria=C.Id ORDER BY ";

                if (campo == "Código")
                {
                    if (criterio == "Ascendente")
                        consulta += "Codigo Asc";
                    else
                        consulta += "Codigo Desc";
                }
                else if (campo == "Marca")
                {
                    if (criterio == "Ascendente")
                        consulta += "M.Descripcion Asc";
                    else
                        consulta += "M.Descripcion Desc";
                }
                else if (campo == "Precio")
                {
                    if (criterio == "Ascendente")
                        consulta += "Precio Asc";
                    else
                        consulta += "Precio Desc";
                }
                else
                {
                    if (criterio == "Ascendente")
                        consulta += "C.Descripcion Asc";
                    else
                        consulta += "C.Descripcion Desc";
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return lista;
        }
        public void modificarPrecios(string marca, string categoria, decimal nuevoPrecio, string valorOporcentaje) // Modificador de Precios por varios criterios, permite modificar varios artículos al mismo tiempo
        {
            AccesoDatos datos = new AccesoDatos();

            try
            { //Si el nuevoPrecio es negativo y valorOporcentaje = valor hago una resta
                string consulta = "UPDATE ARTICULOS SET Precio = Precio ";
                if (valorOporcentaje == "valor" && nuevoPrecio > 0)
                {
                    consulta += "+ @nuevoPrecio";
                }
                else if (valorOporcentaje == "valor" && nuevoPrecio < 0)
                {
                    consulta += "+ @nuevoPrecio"; //tambien lo sumo porque ya lo mando negativo si era un descuento
                }
                else if (valorOporcentaje == "porcentaje")
                {
                    consulta += "* @nuevoPrecio";
                }
                if (!string.IsNullOrEmpty(marca) && !string.IsNullOrEmpty(categoria))
                {
                    consulta += " WHERE IdMarca = (SELECT Id FROM MARCAS WHERE Descripcion = @marca) AND IdCategoria = (SELECT Id FROM CATEGORIAS WHERE Descripcion = @categoria)";
                }
                else if ((!string.IsNullOrEmpty(marca)))
                {
                    consulta += " WHERE IdMarca = (SELECT Id FROM MARCAS WHERE Descripcion = @marca)";
                }
                else if (!string.IsNullOrEmpty(categoria))
                {
                    consulta += " WHERE IdCategoria = (SELECT Id FROM CATEGORIAS WHERE Descripcion = @categoria)";
                }
                //consulta += " WHERE IdMarca = (SELECT Id FROM MARCAS WHERE Descripcion = @marca) AND IdCategoria = (SELECT Id FROM CATEGORIAS WHERE Descripcion = @categoria)"; // esto lo puedo modificar para analizar la marca y categoria si es que mande una o no
                datos.setearConsulta(consulta);
                datos.setearParametros("@marca", marca);
                datos.setearParametros("@categoria", categoria);
                datos.setearParametros("@nuevoPrecio", nuevoPrecio);
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

    }
}
