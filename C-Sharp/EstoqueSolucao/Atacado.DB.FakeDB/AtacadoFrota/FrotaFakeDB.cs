using Atacado.Dominio.AtacadoFrota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class FrotaFakeDB
    {
        private static List<Frota> frotas;

        public static List<Frota> Frotas
        {
            get
            {
                if (frotas == null)
                {
                    frotas = new List<Frota>();
                    Carregar();
                }
                return frotas;
            }
        }
        private static void Carregar()
        {
            frotas.Add(new Frota(true, 1, DateTime.Now, "Transporte de equipamentos", 10));
            frotas.Add(new Frota(true, 2, DateTime.Now, "Transporte de pessoas", 12));
            frotas.Add(new Frota(true, 3, DateTime.Now, "Transporte de animais", 20));
            frotas.Add(new Frota(true, 4, DateTime.Now, "Transporte de alimentos", 5));
            frotas.Add(new Frota(true, 5, DateTime.Now, "Transporte de insumos agriculas", 15));
        }
    }
}
