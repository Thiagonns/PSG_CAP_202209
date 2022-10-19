using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio02v2
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine();
            DateTime data = new DateTime(ano, mes, dia);

            if (data > DateTime.Now)
            {
                Console.WriteLine("ERRO!!! A data de nascimento informada é maior que a dara atual.");
            }
            else
            {
                Console.Write("Sua data de nascimento é: ");
                Console.WriteLine(data.ToString(" dd/MM/yyyy"));
            }
        }
    }
}
