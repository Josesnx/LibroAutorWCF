using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Autor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Autor.svc o Autor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Autor : IAutor
    {
        public ML.Result Add(ML.Autor autor)
        {
            ML.Result result = BL.Autor.Add(autor);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ML.Result Update(ML.Autor autor)
        {
            ML.Result result = BL.Autor.Update(autor);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ML.Result Delete(int IdAutor)
        {
            ML.Result result = BL.Autor.Delete(IdAutor);
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
            ML.Result result = BL.Autor.GetAll();
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ML.Result GetById(int IdAutor)
        {
            ML.Result result = BL.Autor.GetById(IdAutor);
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
