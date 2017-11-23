using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Perimetro
{
    public class Cuadrado:ICalcular
    {

        public void CalcularArea()
        {
            double lado = 5;
            double area = lado * lado;
            Console.WriteLine("Area de cuadrado: " + area);
        }

        public void CalcularPerimetro()
        {
            double lado = 5;
            double perimetro = lado * 4;
            Console.WriteLine("Perimetro de cuadrado: " + perimetro);
        }
    }
}
