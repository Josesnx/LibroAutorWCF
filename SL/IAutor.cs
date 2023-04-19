using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAutor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAutor
    {
        [OperationContract]
        ML.Result Add(ML.Autor autor);
        [OperationContract]
        ML.Result Update(ML.Autor autor);
        [OperationContract]
        ML.Result Delete(int IdAutor);
        [OperationContract]
        [ServiceKnownType(typeof(ML.Autor))]
        ML.Result GetAll();
        [OperationContract]
        [ServiceKnownType(typeof(ML.Autor))]
        ML.Result GetById(int IdAutor);
    }
}
