using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.RH
{
    public abstract class BaseJuridica : BasePessoa
    {
        protected string nomefantasia;
        protected string razaoSocial;
        protected string cnpj;
        protected string inscricaoEstadual;
        protected DateTime fundacao;
        protected string emailCorporativo;

        public string Nomefantasia { get => nomefantasia; set => nomefantasia = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public DateTime Fundacao { get => fundacao; set => fundacao = value; }
        public string EmailCorporativo { get => emailCorporativo; set => emailCorporativo = value; }

        protected BaseJuridica() : base()
        {
        }
    }
}
