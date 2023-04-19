using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
        public static ML.Result Add(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    int query = context.LibroAdd(libro.Nombre,libro.FechaPublicacion,libro.NumeroPaginas,libro.Autor.IdAutor);
                    if (result.Correct)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al insertar";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result Update(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    int query = context.LibroUpdate(libro.IdLibro,libro.Nombre,libro.FechaPublicacion, libro.NumeroPaginas, libro.Autor.IdAutor);
                    if (result.Correct)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al Actualizar";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result Delete(int IdLibro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    int query = context.LibroDelete(IdLibro);
                    if (result.Correct)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al insertar";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    var query = context.LibroGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Libro libro = new ML.Libro();

                            libro.IdLibro = obj.IdLibro;
                            libro.Nombre = obj.Nombre;
                            libro.FechaPublicacion = obj.FechaPublicacion.ToString();
                            libro.NumeroPaginas = obj.NumeroPaginas.Value;

                            libro.Autor = new ML.Autor();
                            libro.Autor.IdAutor = obj.IdAutor;
                            libro.Autor.Nombre = obj.Autor;

                            result.Objects.Add(libro);
                        }
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetById(int IdLibro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    var query = context.LibroGetById(IdLibro).AsEnumerable().FirstOrDefault();

                    if (query != null)
                    {
                        result.Object = new List<object>();
                        var obj = query;

                        ML.Libro libro = new ML.Libro();

                        libro.IdLibro = obj.IdLibro;
                        libro.Nombre = obj.Nombre;
                        libro.FechaPublicacion = obj.FechaPublicacion.ToString();
                        libro.NumeroPaginas = obj.NumeroPaginas.Value;

                        libro.Autor = new ML.Autor();
                        libro.Autor.IdAutor = obj.IdAutor;
                        libro.Autor.Nombre = obj.Autor;

                        result.Object = libro;
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
