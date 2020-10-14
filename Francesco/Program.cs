using System;

namespace Francesco
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, ottagonale;
            string binario = "";
            Console.WriteLine("inserisci il numero da convertire");
            ottagonale = Convert.ToInt32(Console.ReadLine());
           while(ottagonale > 0)
            {
                resto = ottagonale % 8;
                ottagonale = ottagonale / 8;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"il numero binario è {binario}");
            Console.ReadLine();
   
            
            



        }
    }
}

