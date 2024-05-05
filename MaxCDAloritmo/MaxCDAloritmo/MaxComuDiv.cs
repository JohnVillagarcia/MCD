using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCDAloritmo
{
    public static class MaxComuDiv
    {
        public static int mcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo para calcular el MCD de cuatro números");

            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            int num4 = int.Parse(Console.ReadLine());

            int mcd12 = mcd(num1, num2);
            int mcd123 = mcd(mcd12, num3);
            int Total = mcd(mcd123, num4);

            Console.WriteLine("El MCD de los cuatro números es: " + Total);
        }
    }
}
