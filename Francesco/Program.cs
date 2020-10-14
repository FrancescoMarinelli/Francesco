using System;
using System.Dynamic;

namespace Francesco
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1024, resto;
            string binario = "";
            while (Num > 0)
            {
                resto = Num % 2;
                Num /= 2;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"il numero è {binario}");
            Console.ReadLine();



        }
    }
}

