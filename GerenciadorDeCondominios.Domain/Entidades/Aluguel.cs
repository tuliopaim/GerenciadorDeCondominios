using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class Aluguel : Entidade
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(2020, 2030, ErrorMessage = "O ano deve ser entre 2020 e 2030")]
        public int Ano { get; set; }

        [Display(Name = "Mês")]
        public int MesId { get; set; }
        public Mes Mes { get; set; }

        public virtual ICollection<Pagamento> Pagamentos { get; set; }

    }
}
