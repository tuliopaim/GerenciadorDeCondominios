using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.Domain.Entidades
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }

    }
}
