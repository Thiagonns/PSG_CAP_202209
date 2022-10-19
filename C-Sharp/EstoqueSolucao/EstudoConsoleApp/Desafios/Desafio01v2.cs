using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio01v2
    {
        public static void Executar()
        {
            string nome;
            Console.Write("Digite seu nome (Não insira números ou cacteres especiais): ");
            nome = Console.ReadLine();
            if (nome == string.Empty || nome == null)
            {
                Console.WriteLine("Foram encontrados caracteres inválidos no nome informado!");
            }
            else if (Regex.IsMatch(nome, "^[a-z]+$") == false)
            {
                Console.WriteLine("Erro");
            }
            else { 
                Console.WriteLine();
                Console.WriteLine($"Seja bem vindo, {nome}.");
            }
        }
    }
}
