using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTienda
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int insertAdmi(string user, string password);

        [OperationContract]
        int updateAdmi(string user, string password);

        [OperationContract]
        int deleteAdmi(string user);

        [OperationContract]
        int initSession(string user, string password);

    }
}
