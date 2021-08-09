using System;

namespace Ejercicio_6_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo(10, 10);
        }
        public static void Rectangulo(int altura, int anchura)
        {
            for (int i = 0; i <= (altura - 1); i++)
            {
                for (int f = 0; f <= (anchura - 1); f++)
                {
                    Console.Write("***");
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }
        }
    }
}
