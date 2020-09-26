using GerenciadorDeCondominios.Domain.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class Pagamento : Entidade
    {
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int AluguelId { get; set; }
        public virtual Aluguel Aluguel { get; set; }

        public DateTime? Data { get; set; }
        public StatusPagamento Status { get; set; }

    }
}
