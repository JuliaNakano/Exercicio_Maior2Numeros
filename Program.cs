using System;

namespace Exercicio_Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiro, segundo; 

            Console.WriteLine("Esse programa tem por finalidade alisar qual dos números digitados é maior");
            Console.WriteLine("Para iniciá-lo digite:.....");
            
            Console.Write("\nDigite o primeiro número:... ");
            primeiro = Convert.ToDouble(Console.ReadLine()); 
            
            Console.Write("Digite o segundo número:.... ");
            segundo = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (primeiro > segundo )
            {
                Console.WriteLine($"O maior número é {primeiro}");
                Console.ResetColor();
            
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"O maior número é {segundo}");
                Console.ResetColor();
            }


        }
    }
}
