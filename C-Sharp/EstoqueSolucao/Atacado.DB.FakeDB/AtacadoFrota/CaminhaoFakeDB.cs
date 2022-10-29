using Atacado.Dominio.Estoque;
using Atacado.Dominio.AtacadoFrota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class CaminhaoFakeDB
    {
        private static List<Caminhao> caminhoes;

        public static List<Caminhao> Caminhoes
        {
            {
                if (caminhoes == null)
                {
                    caminhoes = new List<Caminhao>();
                    Carregar();
                }
                return caminhoes;
            }
        }

        private static void Carregar()
        {
            caminhoes.Add(new Caminhao(true, 1, DateTime.Now, "ExemploNumChassi1", "Preto", "Volvo", "Volvo FH", "CaminhaoPlaca1", 56.000, 17.000, 56.000));
            caminhoes.Add(new Caminhao(true, 2, DateTime.Now, "ExemploNumChassi2", "Branco", "Mercedes", "Atron.", "CaminhaoPlaca2", 52.000, 12.000, 52.000));
            caminhoes.Add(new Caminhao(true, 3, DateTime.Now, "ExemploNumChassi3", "Cinza", "Scania", "R 620", "CaminhaoPlaca3", 54.000, 16.000, 54.000));
            caminhoes.Add(new Caminhao(true, 4, DateTime.Now, "ExemploNumChassi4", "Prata", "Scania", "R 440", "CaminhaoPlaca4", 54.000, 16.000, 54.000));
            caminhoes.Add(new Caminhao(true, 5, DateTime.Now, "ExemploNumChassi5", "Vermelho", "Volvo", "Volvo FMX", "CaminhaoPlaca5", 56.000, 17.000, 56.000));
        }
    }
}
