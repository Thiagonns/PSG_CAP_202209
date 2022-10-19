using System;
using EstudoConsoleApp.Aulas;
using EstudoConsoleApp.Desafios;

namespace EstudoConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Executarexemplo01();
            //Executarexemplo02();
            //Executarexemplo03();
            //Executarexemplo04();
            //Executarexemplo05();

            Desafio10.Executar();
            //Desafio01v2.Executar();
        }

        private static void Executarexemplo01()
        {
            Console.Write("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Somar {0}", OperacoesMatematicas.Somar(n1, n2));
            Console.WriteLine("Subitrair {0}", OperacoesMatematicas.Subtrair(n1, n2));
            Console.WriteLine("Multiplicar {0}", OperacoesMatematicas.Multiplicar(n1, n2));
            Console.WriteLine("Dividir {0}", OperacoesMatematicas.Dividir(n1, n2));

            Console.ReadLine();
        }
        private static void Executarexemplo02()
        {
            Console.Write("Comparações lógicas: ");

            Console.Write("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            ComparacoesLogicas.MaiorQue(n1, n2);
            ComparacoesLogicas.MenorQue(n1, n2);
        }
        private static void Executarexemplo03()
        {
            Console.Write("Comparações lógicas: ");

            Console.Write("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            ComparacoesLogicasV2.MaiorQue(n1, n2);
            ComparacoesLogicasV2.MenorQue(n1, n2);
        }
        private static void Executarexemplo04()
        {
            TrabalhandoComDatas.ExibirDataAtual();
            Console.WriteLine();
            TrabalhandoComDatas.ExibirDataAtualFormatada();
        }

        private static void Executarexemplo05()
        {
            Console.Write("Operação matemáticas V2 ");

            Console.Write("Informe o Primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Somar {0}", OperacoesMatematicas.Somar(n1, n2));
            Console.WriteLine();
            Console.WriteLine("Subitrair {0}", OperacoesMatematicas.Subtrair(n1, n2));
            Console.WriteLine();
            Console.WriteLine("Multiplicar {0}", OperacoesMatematicas.Multiplicar(n1, n2));
            Console.WriteLine();
            Console.WriteLine("Dividir {0}", OperacoesMatematicas.Dividir(n1, n2));
            Console.WriteLine();
            Console.WriteLine("Potenciacao x ^ y {0}", OperacoesMatematicasV2.Potenciacao(n1, n2));
            Console.WriteLine();
            Console.WriteLine("Potenciacao y ^ x {0}", OperacoesMatematicasV2.Potenciacao(n2, n1));
            Console.WriteLine();
            Console.WriteLine("Radiciacao (RAZ QUADRADA DE N1):  {0}", OperacoesMatematicasV2.Radiciacao(n1));
            Console.WriteLine();
            Console.WriteLine("Radiciacao (RAZ QUADRADA DE N2):  {0}", OperacoesMatematicasV2.Radiciacao(n2));
        }
    }
}