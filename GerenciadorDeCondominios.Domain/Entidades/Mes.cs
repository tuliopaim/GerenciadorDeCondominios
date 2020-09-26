using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class Mes : Entidade
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(20, ErrorMessage = "O nome deve possuir até 20 caracteres")]
        public string Nome { get; set; }

        public virtual ICollection<Aluguel> Alugueis { get; set; }
        public virtual ICollection<HistoricoRecursos> HistoricoRecurso { get; set; }

    }
}
