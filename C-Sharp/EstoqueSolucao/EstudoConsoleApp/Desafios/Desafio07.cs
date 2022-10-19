using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio07
    {
        public static void Executar()
        {
            Console.Write("Informe um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} X 1 = {1}", num, num * 1);
            Console.WriteLine("{0} X 2 = {1}", num, num * 2);
            Console.WriteLine("{0} X 3 = {1}", num, num * 3);
            Console.WriteLine("{0} X 4 = {1}", num, num * 4);
            Console.WriteLine("{0} X 5 = {1}", num, num * 5);
            Console.WriteLine("{0} X 6 = {1}", num, num * 6);
            Console.WriteLine("{0} X 7 = {1}", num, num * 7);
            Console.WriteLine("{0} X 8 = {1}", num, num * 8);
            Console.WriteLine("{0} X 9 = {1}", num, num * 9);
            Console.WriteLine("{0} X 10 = {1}", num, num * 10);
        }
    }
}
