using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio10
    {
        public static void Executar()
        {
            Console.Write("Informe o preço do produto (R$): ");
            double preco = Double.Parse(Console.ReadLine());
            double desconto = (preco * 0.05);
            Console.WriteLine();
            Console.WriteLine("Novo valor com 5% de desconto: R${0}", (preco - desconto));
        }
    }
}
