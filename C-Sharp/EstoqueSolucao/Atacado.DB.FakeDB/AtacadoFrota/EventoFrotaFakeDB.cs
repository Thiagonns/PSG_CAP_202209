using Atacado.Dominio.AtacadoFrota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class EventoFrotaFakeDB
    {
        private static List<EventoFrota> eventosFrota;

        public static List<EventoFrota> EventosFrota
        {
            get
            {
                if (eventosFrota == null)
                {
                    eventosFrota = new List<EventoFrota>();
                    Carregar();
                }
                return eventosFrota;
            }
        }
        private static void Carregar()
        {
            eventosFrota.Add(new EventoFrota(true, 1, DateTime.Now, "Thiago", new DateTime(2023,5,22), new DateTime(2022,6,22), 2200, 2000, "Transporte de equipamentos"));
            eventosFrota.Add(new EventoFrota(true, 1, DateTime.Now, "Rafael", new DateTime(2023,6,22), new DateTime(2022,6,22), 2500, 2000, "Transporte de pessoas"));
            eventosFrota.Add(new EventoFrota(true, 1, DateTime.Now, "Akira", new DateTime(2023,3,22), new DateTime(2022,6,22), 2300, 2000, "Transporte de animais"));
            eventosFrota.Add(new EventoFrota(true, 1, DateTime.Now, "Luiz", new DateTime(2023,8,22), new DateTime(2022,6,22), 2100, 2000, "Transporte de pessoas"));
            eventosFrota.Add(new EventoFrota(true, 1, DateTime.Now, "Marlon", new DateTime(2023,9,22), new DateTime(2022,6,22), 2200, 2000, "Transporte de alimentos"));
            
        }
    }
}
