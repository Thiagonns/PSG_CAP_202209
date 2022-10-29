using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.AtacadoFrota
{
    public class CarroPoco : BasePesoCargaPoco
    {
        private string numeroPassageiros;
        public string NumeroPassageiros { get => numeroPassageiros; set => numeroPassageiros = value; }

        public CarroPoco()
        {
        }
    }
}
