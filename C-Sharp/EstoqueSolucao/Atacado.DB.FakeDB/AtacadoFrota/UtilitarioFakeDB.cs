using Atacado.Dominio.AtacadoFrota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class UtilitarioFakeDB
    {
        private static List<Utilitario> utilitarios;

        public static List<Utilitario> Utilitarios
        {
            get
            {
                if (utilitarios == null)
                {
                    utilitarios = new List<Utilitario>();
                    Carregar();
                }
                return utilitarios;
            }
        }
        private static void Carregar()
        {
            utilitarios.Add(new Utilitario(true, 1, DateTime.Now, "ExemploNumChassi1", "Preto", "Fiat", "Estrada", "UtilitarioPlaca1", 1084, 900, 1084));
            utilitarios.Add(new Utilitario(true, 2, DateTime.Now, "ExemploNumChassi2", "Branco", "Renaut", "Kangoo ZE", "UtilitarioPlaca2", 1505, 100, 1505));
            utilitarios.Add(new Utilitario(true, 3, DateTime.Now, "ExemploNumChassi3", "Cinza", "Fiat", "Fiorino", "UtilitarioPlaca3", 190, 170, 190));
            utilitarios.Add(new Utilitario(true, 4, DateTime.Now, "ExemploNumChassi4", "Prata", "Renaut", "Duster Oroch", "UtilitarioPlaca4", 1250, 1000, 1250));
            utilitarios.Add(new Utilitario(true, 5, DateTime.Now, "ExemploNumChassi5", "Vermelho", "Fiat", "Toro", "UtilitarioPlaca5", 1.300, 1050, 1300));
        }
    }
}
