using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruedas_motor
{
    public class Vehiculo
    {
        public List<Rueda> ruedas = new List<Rueda>();
        public Motor motor = new Motor();
        public CajaCambios cajacambios = new CajaCambios();
    }
}
