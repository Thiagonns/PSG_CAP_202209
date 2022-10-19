using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    internal class Desafio03v2
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa realiza soma entre dois números");
            Console.Write("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            
            if (n1 == null || n2 == null)
            {
                Console.WriteLine("Insira os numeros que você deseja somar!");
            }
            else
            {
                Console.WriteLine("A soma entre {0} e {1} é igual a {2}.", n1, n2, soma);
            }
        }
    }
}
