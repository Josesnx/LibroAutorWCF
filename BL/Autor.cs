using ML;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Autor
    {
        public static ML.Result Add(ML.Autor autor)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    var query = context.AutorAdd(autor.Nombre,autor.ApellidoPaterno,autor.ApellidoMaterno);
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

        public static ML.Result Update(ML.Autor autor)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    int query = context.AutorUpdate(autor.IdAutor,autor.Nombre, autor.ApellidoPaterno, autor.ApellidoMaterno);
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

        public static ML.Result Delete(int IdAutor)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    int query = context.AutorDelete(IdAutor);
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
                    var query = context.AutorGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Autor autor = new ML.Autor();

                            autor.IdAutor = obj.IdAutor;
                            autor.Nombre = obj.Nombre;
                            autor.ApellidoPaterno = obj.ApellidoPaterno;
                            autor.ApellidoMaterno = obj.ApellidoMaterno;
                            result.Objects.Add(autor);
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

        public static ML.Result GetById(int IdAutor)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JSanchezLibroEntities context = new DL.JSanchezLibroEntities())
                {
                    var query = context.AutorGetById(IdAutor).AsEnumerable().FirstOrDefault();

                    if (query != null)
                    {
                        result.Object = new List<object>();
                        var obj = query;

                        ML.Autor autor = new ML.Autor();

                        autor.IdAutor = obj.IdAutor;
                        autor.Nombre = obj.Nombre;
                        autor.ApellidoPaterno = obj.ApellidoPaterno;
                        autor.ApellidoMaterno = obj.ApellidoMaterno;
                        result.Object = autor;
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
