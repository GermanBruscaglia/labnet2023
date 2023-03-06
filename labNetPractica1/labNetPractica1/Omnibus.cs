using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class Omnibus : TransportePublico
    {

        public Omnibus(int pasajeros) : base(pasajeros)
        {
        }

        public override string Avanzar()
        {
            return $"Avanzando con {pasajeros} pasajeros";
        }

        public override string Detenerse()
        {
            return $"Deteniendome con {pasajeros} pasajeros";
        }

    }
}
