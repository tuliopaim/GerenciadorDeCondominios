using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class Veiculo : Entidade
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(20, ErrorMessage = "O nome deve possuir até 20 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(20, ErrorMessage = "A marca deve possuir até 20 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(20, ErrorMessage = "A cor deve possuir até 20 caracteres")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Placa { get; set; }

        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
