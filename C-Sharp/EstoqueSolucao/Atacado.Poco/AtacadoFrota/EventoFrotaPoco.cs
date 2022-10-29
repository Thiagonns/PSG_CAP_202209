using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.AtacadoFrota
{
    public class EventoFrotaPoco : BaseCamposPoco
    {
        private string condutor;
        private DateTime dataFinal;
        private DateTime dataInicial;
        private double kmFinal;
        private double kmInicial;
        private string motivoEvento;

        public string Condutor { get => condutor; set => condutor = value; }
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }
        public DateTime DataInicial { get => dataInicial; set => dataInicial = value; }
        public double KmFinal { get => kmFinal; set => kmFinal = value; }
        public double KmInicial { get => kmInicial; set => kmInicial = value; }
        public string MotivoEvento { get => motivoEvento; set => motivoEvento = value; }

        public EventoFrotaPoco()
        {
        }
    }
}

