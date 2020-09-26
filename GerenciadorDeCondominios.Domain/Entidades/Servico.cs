﻿using GerenciadorDeCondominios.Domain.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class Servico : Entidade
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome deve possuir até 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }
        public StatusServico Status { get; set; }

        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<ServicoPredio> ServicosPredio { get; set; }

    }
}
