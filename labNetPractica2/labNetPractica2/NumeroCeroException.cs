using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    internal class NumeroCeroException:Exception
    {
        public NumeroCeroException() : base("No se puede dividir un numero por cero")
        {
        }
    }
}
