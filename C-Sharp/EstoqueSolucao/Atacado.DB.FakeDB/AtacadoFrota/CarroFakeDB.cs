using Atacado.Dominio.AtacadoFrota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class CarroFakeDB
    {
        private static List<Carro> carros;

        public static List<Carro> Carros
        {
            get
            {
                if (carros == null)
                {
                    carros = new List<Carro>();
                    Carregar();
                }
                return carros;
            }
        }
        private static void Carregar()
        {
            carros.Add(new Carro(true, 1, DateTime.Now, "ExemploNumChassi1", "Preto", "Fiat", "Argo", "CarroPlaca1", 1084, 900, 1084));
            carros.Add(new Carro(true, 2, DateTime.Now, "ExemploNumChassi2", "Branco", "Volkswagen", "Jetta", "CarroPlaca2", 1505, 100, 1505));
            carros.Add(new Carro(true, 3, DateTime.Now, "ExemploNumChassi3", "Cinza", "BMW", "320", "CarroPlaca3", 1200, 1090, 1200));
            carros.Add(new Carro(true, 4, DateTime.Now, "ExemploNumChassi4", "Prata", "Renaut", "Kwid", "CarroPlaca4", 1000, 900, 1000));
            carros.Add(new Carro(true, 5, DateTime.Now, "ExemploNumChassi5", "Vermelho", "Mercedes", "C180", "CarroPlaca5", 1100, 1050, 1100));
        }
    }
}
