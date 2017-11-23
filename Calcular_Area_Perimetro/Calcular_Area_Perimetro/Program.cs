using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            Triangulo triangulo = new Triangulo();
            Circulo circulo = new Circulo();

            cuadrado.CalcularArea();
            cuadrado.CalcularPerimetro();

            triangulo.CalcularArea();
            triangulo.CalcularPerimetro();

            circulo.CalcularArea();
            circulo.CalcularPerimetro();

            Console.ReadKey();
        }

    }
}
