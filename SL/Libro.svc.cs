using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Libro" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Libro.svc o Libro.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Libro : ILibro
    {
        public ML.Result Add(ML.Libro libro)
        {
            ML.Result result = BL.Libro.Add(libro);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ML.Result Update(ML.Libro libro)
        {
            ML.Result result = BL.Libro.Update(libro);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ML.Result Delete(int IdLibro)
        {
            ML.Result result = BL.Libro.Delete(IdLibro);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ML.Result GetAll()
        {
            ML.Result result = BL.Libro.GetAll();
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ML.Result GetById(int IdLibro)
        {
            ML.Result result = BL.Libro.GetById(IdLibro);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
