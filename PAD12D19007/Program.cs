using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD12D19007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para descobrir o fibonacci

            Console.WriteLine("Diga um número pra eu descobrir seu fibonacci");

            int valor = int.Parse(Console.ReadLine());
            int numero1 = 0;
            int numero2 = 1;
            int soma = 0;

            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine(numero1);
                soma = numero1 + numero2;
                numero1 = numero2;
                numero2 = soma;
            }
            Console.ReadLine();
        }
    }
}
