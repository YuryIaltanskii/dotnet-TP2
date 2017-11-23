using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruedas_motor
{
    interface IMotor
    {
        double Cilindrada { get; set; }
        void iniciarMotor();
        void frenarMotor();
    }
}
