using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Perimetro
{
    public class Triangulo:ICalcular
    {
        public void CalcularArea()
        {
            double b = 5;
            double alt = 3;
            double area = (b * alt) / 2;
            Console.WriteLine("Area de triangulo: " + area);
        }

        public void CalcularPerimetro()
        {
            double lado1 = 3;
            double lado2 = 3;
            double lado3 = 3;
            double perimetro = lado1 + lado2 + lado3;
            Console.WriteLine("Perimetro de triangulo: " + perimetro);
        }

    }
}
