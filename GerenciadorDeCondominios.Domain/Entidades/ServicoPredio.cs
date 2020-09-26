using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class ServicoPredio : Entidade
    {
        public DateTime DataExecucao { get; set; }

        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
