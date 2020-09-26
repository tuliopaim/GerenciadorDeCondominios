using GerenciadorDeCondominios.Domain.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class HistoricoRecursos : Entidade
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Dia { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TiposRecurso Tipo { get; set; }

        public int MesId { get; set; }
        public virtual Mes Mes { get; set; }

        public int Ano { get; set; }

    }
}