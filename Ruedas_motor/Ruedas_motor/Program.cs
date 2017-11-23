using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruedas_motor
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehiculos = new List<Vehiculo>() { new Vehiculo() { ruedas }{ Cilindrada = 4 } }, new Vehiculo() { Lado = 25 }, new Vehiculo() { Lado = 10 };

            //var mayor_a_1_lamb = vehiculos.Where(x => x.Lado == 25).ToList();

            foreach (var Lado in mayor_a_1_lamb)
            {
                Console.WriteLine(Lado.Lado);
            }

    Console.ReadLine();
        }
    }
}
