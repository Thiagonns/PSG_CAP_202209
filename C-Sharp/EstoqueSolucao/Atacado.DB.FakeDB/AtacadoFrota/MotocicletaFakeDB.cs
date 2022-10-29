using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Atacado.Dominio.AtacadoFrota;


namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class MotocicletaFakeDB
    {
        private static List<Motocicleta> motocicletas;

        public static List<Motocicleta> Motocicletas
        {
            get
            {
                if (motocicletas == null)
                {
                    motocicletas = new List<Motocicleta>();
                    Carregar();
                }
                return motocicletas;
            }
        }
        private static void Carregar()
        {
            motocicletas.Add(new Motocicleta(true, 1, DateTime.Now, "ExemploNumChassi1", "Preto", "Honda", "Naked", "NRT8F35", 130, 110, 130));
            motocicletas.Add(new Motocicleta(true, 2, DateTime.Now, "ExemploNumChassi2", "Branco", "Honda", "City", "NRT8F68", 110, 100, 110));
            motocicletas.Add(new Motocicleta(true, 3, DateTime.Now, "ExemploNumChassi3", "Cinza", "Honda", "Speed", "NRT8F78", 190, 170, 190));
            motocicletas.Add(new Motocicleta(true, 4, DateTime.Now, "ExemploNumChassi4", "Prata", "Honda", "Naked", "NRT8F21", 130, 110, 130));
            motocicletas.Add(new Motocicleta(true, 5, DateTime.Now, "ExemploNumChassi5", "Vermelho", "Honda", "Scooter", "NRT8F95", 100, 90, 100));           
        }
    }
}
