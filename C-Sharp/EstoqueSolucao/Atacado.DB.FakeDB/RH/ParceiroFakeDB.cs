using Atacado.Dominio.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.RH
{
    public static class ParceiroFakeDB
    {

        private static List<Parceiro> parceiros;
        public static List<Parceiro> Parceiros
        {
            get
            {
                if (parceiros == null)
                {
                    parceiros = new List<Parceiro>();
                    Carregar();
                }
                return parceiros;
            }
        }
        private static void Carregar()
        {
            parceiros.Add(new Parceiro(1, "fantasia1", "razao1", "57846468483", "inscriçãoTeste1", new DateTime(2013, 2, 7), "email@teste11", 8600, 9000, "TI"));
            parceiros.Add(new Parceiro(1, "fantasia2", "razao2", "36438468483", "inscriçãoTeste2", new DateTime(2017, 2, 7), "email@teste12", 6430, 6400, "TI"));
            parceiros.Add(new Parceiro(1, "fantasia3", "razao3", "36438468483", "inscriçãoTeste3", new DateTime(2022, 4, 12), "email@teste13", 3465, 3500, "TI"));
            parceiros.Add(new Parceiro(1, "fantasia4", "razao4", "36432348483", "inscriçãoTeste4", new DateTime(2018, 8, 15), "email@teste14", 9876, 4200, "TI"));
            parceiros.Add(new Parceiro(1, "fantasia5", "razao5", "36439764483", "inscriçãoTeste5", new DateTime(2018, 3, 9), "email@teste15", 5746, 2000, "TI"));
        }
    }
}
