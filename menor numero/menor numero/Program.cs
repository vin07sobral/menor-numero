using System;

namespace menor_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, Z, resultado;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            Z = int.Parse(Console.ReadLine());

            resultado = util.menorNumero(X, Y, Z);

            Console.WriteLine("Menor =" + resultado);

            Console.ReadLine();
        }
    }
}
