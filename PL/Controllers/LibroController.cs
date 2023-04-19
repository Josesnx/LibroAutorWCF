using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class LibroController : Controller
    {
        // GET: Libro
        public ActionResult GetAll()
        {
            ML.Libro libro = new ML.Libro();
            LibroService.LibroClient libroClient = new LibroService.LibroClient();
            ML.Result result = libroClient.GetAll();

            if (result.Correct)
            {
                libro.Libros = result.Objects;
                return View(libro);
            }
            else
            {
                return View(libro);
            }
        }

        [HttpGet]
        public ActionResult Form(int? IdLibro)
        {
            ML.Result resultAutor = BL.Autor.GetAll();

            //ML.Autor autor = new ML.Autor();
            ML.Libro libro = new ML.Libro();

            if (resultAutor.Correct)
            {
                libro.Autor = new ML.Autor();
                libro.Autor.Autores = resultAutor.Objects;
            }
            if (IdLibro == null)
            {
                return View(libro);
            }
            else
            {
                LibroService.LibroClient libroClient = new LibroService.LibroClient();
                ML.Result result = libroClient.GetById(IdLibro.Value);
                if (result.Correct)
                {
                    libro = (ML.Libro)result.Object;
                    libro.Autor.Autores = resultAutor.Objects;
                    return View(libro);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar la informacion";
                    return View("Modal");
                }
            }
        }

        [HttpPost]
        public ActionResult Form(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            if (libro.IdLibro == 0)
            {
                LibroService.LibroClient libroClient = new LibroService.LibroClient();
                result = libroClient.Add(libro);
                if (result.Correct)
                {
                    ViewBag.Message = "Se inserto el registro";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al insertar el registro";
                }
                return View("Modal");
            }
            else
            {
                LibroService.LibroClient libroClient = new LibroService.LibroClient();
                result = libroClient.Update(libro);
                if (result.Correct)
                {
                    ViewBag.Message = "Se Actualizo el registro";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al actualizar el registro";
                }
                return View("Modal");
            }
        }

        [HttpGet]
        public ActionResult Delete(int IdLibro)
        {
            LibroService.LibroClient libroClient = new LibroService.LibroClient();
            ML.Result result = libroClient.Delete(IdLibro);

            if (result.Correct)
            {
                ViewBag.Message = "Se Elimino el registro";
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al eliminar el registro";
            }
            return View("Modal");
        }
    }
}