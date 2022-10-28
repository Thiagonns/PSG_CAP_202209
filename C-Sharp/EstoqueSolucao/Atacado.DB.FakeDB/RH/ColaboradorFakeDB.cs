using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public static class ColaboradorFakeDB
    {
        private static List<Colaborador> colaboradores;

        public static List<Colaborador> Colaboradores
        {
            get
            {
                if (colaboradores == null)
                {
                    colaboradores = new List<Colaborador>();
                    Carregar();
                }
                return colaboradores;
            }
        }
        private static void Carregar()
        {
            colaboradores.Add(new Colaborador(1, "Thiago", "123.123.123-12", "2114340", "Masculino", new DateTime(1997,9,19), "colab@teste1.com", "135135", "157484", "55578684", true, "Solteiro", 1, true, "Desenvolvimento", "Júnior", 9000, "1234-1234", "4589-4321"));
            colaboradores.Add(new Colaborador(2, "Nunes", "321.321.321-32", "2145860", "Masculino", new DateTime(1998, 10, 20), "colab@teste2.com", "162435", "158584", "55548784", true, "Casado", 2, true, "Desenvolvimento", "Júnior", 9250, "4321-4321", "4326-4371"));
            colaboradores.Add(new Colaborador(3, "Cruz", "213.213.213-21", "2755860", "Masculino", new DateTime(1999, 11, 21), "colab@teste3.com", "134965", "157644", "55547384", true, "Solteiro", 1, true, "Desenvolvimento", "Júnior", 9820, "3214-3214", "4331-4821"));
            colaboradores.Add(new Colaborador(4, "Lucas", "225.213.213-21", "2759560", "Masculino", new DateTime(1997, 10, 16), "colab@teste4.com", "139635", "159464", "55486384", true, "Solteiro", 3, true, "Analista", "Pleno", 8460, "5814-3214", "3631-7621"));
            colaboradores.Add(new Colaborador(5, "Allan", "213.267.853-21", "2747860", "Masculino", new DateTime(1998, 4, 8), "colab@teste5.com", "137635", "154384", "55354384", true, "Solteiro", 2, true, "Vendedor", "Espec", 27890, "3214-2514", "4331-9721"));
        }
    }
}
