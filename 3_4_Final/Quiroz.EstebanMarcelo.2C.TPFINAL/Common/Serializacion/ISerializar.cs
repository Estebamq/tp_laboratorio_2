using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Serializacion
{
    public interface ISerializar <T>
    {
        string LeerArchivo(string path);
        void EscribirArchivo(T obj,string path);
    }
}
