using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class SinStockMateriaPrimaException:Exception
    {
        public SinStockMateriaPrimaException():base("No hay stock de materia prima")
        {
                
        }
    }
}
