using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_SuperficieDeUnTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 0;

            Console.WriteLine("Ingresar base y altura del triangulo: ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = (a * b) / 2;

            Console.WriteLine("La superficie es de: " + c);

            Console.ReadKey();
        }
    }
}
