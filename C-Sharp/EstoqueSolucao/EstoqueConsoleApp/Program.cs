namespace EstudoConsoleApp;

using System;

public class Program
{
    public static void Main(string[] args)
    {
       
    }

    private static void ExecutarOperacoesMatematicas()
    {
        Console.WriteLine("Informe o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Somar {0}", Aulas.OperacoesMatematicas.Somar(n1, n2));
        Console.WriteLine("Subitrair {0}", OperacoesMatematicas.Subitrair(n1, n2));
        Console.WriteLine("Multiplicar {0}", OperacoesMatematicas.Multiplicar(n1, n2));
        Console.WriteLine("Dividir {0}", OperacoesMatematicas.Dividir(n1, n2));

        Console.Readline();
    }
}
