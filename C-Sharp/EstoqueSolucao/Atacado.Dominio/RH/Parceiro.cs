using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.RH
{
    public class Parceiro : BaseJuridica
    {
        private double desempenho;
        private double comissao;
        private string setor;

        public double Desempenho { get => desempenho; set => desempenho = value; }
        public double Comissao { get => comissao; set => comissao = value; }
        public string Setor { get => setor; set => setor = value; }

        public Parceiro()
        {
        }

        public Parceiro(int id, string nomefantasia, string razaoSocial, string cnpj, string inscricaoEstadual, DateTime fundacao, string emailCorporativo, double desempenho, double comissao, string setor) : base(id, nomefantasia, razaoSocial, cnpj, inscricaoEstadual, fundacao, emailCorporativo)
        {
            this.desempenho = desempenho;
            this.comissao = comissao;
            this.setor = setor;
        }
    }
}
