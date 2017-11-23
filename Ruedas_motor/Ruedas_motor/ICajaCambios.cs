using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruedas_motor
{
    interface ICajaCambios
    {
        string Tipo { get; set; }
        int Cant_cambios { get; set; }
    }
}
