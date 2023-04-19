using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class AutorController : Controller
    {
        // GET: Autor
        public ActionResult GetAll()
        {
            ML.Autor autor = new ML.Autor();
            AutorService.AutorClient autorClient = new AutorService.AutorClient();
            ML.Result result = autorClient.GetAll();

            if (result.Correct)
            {
                autor.Autores = result.Objects;
                return View(autor);
            }
            else
            {
                return View(autor);
            }
        }
        [HttpGet]
        public ActionResult Form(int? IdAutor)
        {
            ML.Autor autor = new ML.Autor();
            if (IdAutor == null)
            {
                return View(autor);
            }
            else
            {
                AutorService.AutorClient autorClient = new AutorService.AutorClient();
                ML.Result result = autorClient.GetById(IdAutor.Value);
                if (result.Correct)
                {
                    autor = (ML.Autor)result.Object;
                    return View(autor);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar la informacion";
                    return View("Modal");
                }
            }
        }

        [HttpPost]
        public ActionResult Form(ML.Autor autor)
        {
            ML.Result result = new ML.Result();
            if (autor.IdAutor == 0)
            {
                AutorService.AutorClient autorClient = new AutorService.AutorClient();
                result = autorClient.Add(autor);
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
                AutorService.AutorClient autorClient = new AutorService.AutorClient();
                result = autorClient.Update(autor);
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
        public ActionResult Delete(int IdAutor)
        {
            AutorService.AutorClient autorClient = new AutorService.AutorClient();
            ML.Result result = autorClient.Delete(IdAutor);

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