using Atacado.Dominio.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.RH
{
    public static class PrestadorFakeDB
    {
        private static List<Prestador> prestadores;
        public static List<Prestador> Prestadores
        {
            get
            {
                if (prestadores == null)
                {
                    prestadores = new List<Prestador>();
                    Carregar();
                }
                return prestadores;
            }
        }
        private static void Carregar()
        {
            prestadores.Add(new Prestador(1, "TNTech", "Nunes&Cross", "36438468483", "6842688", new DateTime(2018, 6, 17), "email@teste6", new DateOnly(2022, 9, 1), new DateOnly(2026, 9, 30)));
            prestadores.Add(new Prestador(1, "LavaTech", "Tnc", "36438468483", "7352688", new DateTime(2017, 2, 7), "email@teste7", new DateOnly(2028, 7, 12), new DateOnly(2028, 9, 14)));
            prestadores.Add(new Prestador(1, "CTech", "Nunes&Oliveira", "36438468483", "2342688", new DateTime(2022, 4, 12), "email@teste8", new DateOnly(2023, 3, 5), new DateOnly(2029, 9, 7)));
            prestadores.Add(new Prestador(1, "ProTech", "Ortiz&Ortiz", "36432348483", "6462688", new DateTime(2018, 8, 15), "email@teste9", new DateOnly(2025, 6, 14), new DateOnly(2023, 9, 16)));
            prestadores.Add(new Prestador(1, "ITech", "cazela&cazela", "36439764483", "6842874", new DateTime(2018, 3, 9), "email@teste10", new DateOnly(2022, 8, 18), new DateOnly(2025, 9, 5)));
        }
    }
}
