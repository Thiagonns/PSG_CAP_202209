using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio16
    {
        public static void Executar()
        {
            List<string> nomes = new List<string>();
            bool sair = false;
            //Wile para que haja a opção de encerrar a inserção de nomes na lista
            while (sair == false)
            {
                Console.WriteLine("Numero de alunos na lista {0}.", nomes.Count);
                Console.WriteLine("______________________________");
                Console.WriteLine();
                //Teste para validação do nome informado
                bool teste = true;
                while (teste == true)
                {
                    Console.Write("Informe o nome do aluno: ");
                    string aluno = Console.ReadLine();

                    if (string.IsNullOrEmpty(aluno.Trim()) == true)
                    {
                        Console.WriteLine("O Nome é obrigatório!");
                        teste = true;
                    }
                    else
                    {
                        nomes.Add(aluno);
                        teste = false;
                    }
                }
                Console.Write("Deseja sair <S/N>:");
                string esc = Console.ReadLine();
                if (esc.ToUpper() == "S")
                {
                    sair = true;
                }
                else
                {
                    Console.Clear();
                    sair = false;
                }
            }

            // Ordenando a lista (Alfabética)
            nomes.Sort();

            Random rd = new Random();
            int rand_num = rd.Next(0, nomes.Count);

            //Imprimindo a lista no console 
            Console.Clear();
            Console.WriteLine("Lista de alunos: ");
            foreach (string aluno in nomes)
            {
                Console.WriteLine("\t Nome: {0}", aluno);
            }
            Console.WriteLine();
            Console.WriteLine($"Aluno escolhido: {nomes[rand_num]}");
        }
    }
}
