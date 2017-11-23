using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Perimetro
{
    class Circulo:ICalcular
    {
        public void CalcularArea()
        {
            double radio = 10;
            double pi = 3.14;
            double area = pi * (radio * radio);
            Console.WriteLine("Area de circulo: " + area);
        }

        public void CalcularPerimetro()
        {
            double radio = 10;
            double pi = 3.14;
            double perimetro = 2 * pi * radio;
            Console.WriteLine("Perimetro de circulo: " + perimetro);
        }

    }
}
