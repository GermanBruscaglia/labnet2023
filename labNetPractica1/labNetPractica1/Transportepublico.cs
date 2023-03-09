using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public abstract class TransportePublico
    {
        public int pasajeros;
        public string nombreVehiculo;

        public TransportePublico(int pasajeros, string nombreVehiculo)
        {
            this.pasajeros = pasajeros;
            this.nombreVehiculo = nombreVehiculo;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

        public abstract string Listarvehivulos();

    }
}