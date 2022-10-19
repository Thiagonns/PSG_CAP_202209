using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio12
    {
        public static void Executar()
        {
            Console.WriteLine("Qual a temperatura em graus Celsius: ");
            double TempCelsius = float.Parse(Console.ReadLine());
            double TempFa = (TempCelsius * 1.8 + 32);
        }
       
    }
}
