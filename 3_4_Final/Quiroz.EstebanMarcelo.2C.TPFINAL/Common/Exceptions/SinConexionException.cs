using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class SinConexionException:Exception
    {
        public SinConexionException():base("Trabajando sin conexion con la base de datos")
        {
                
        }
    }
}
