using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruedas_motor
{
    interface IRueda
    {
        double Diametro { get; set; }
        void iniciarRueda();
        void frenarRueda();
    }
}
