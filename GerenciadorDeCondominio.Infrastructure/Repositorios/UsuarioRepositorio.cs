using GerenciadorDeCondominios.Domain.Entidades;
using GerenciadorDeCondominios.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCondominios.Infrastructure.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<Usuario> _gerenciadorUsuarios;
        private readonly SignInManager<Usuario> _gerenciadorDeLogin;

        public UsuarioRepositorio(Contexto contexto, 
            UserManager<Usuario> gerenciadorUsuarios,
            SignInManager<Usuario> gerenciadorDeLogin) 
            : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorUsuarios = gerenciadorUsuarios;
            this._gerenciadorDeLogin = gerenciadorDeLogin;
        }

        public async Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            try
            {
                return await _gerenciadorUsuarios.CreateAsync(usuario, senha);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao)
        {
            try
            {
                await _gerenciadorUsuarios.AddToRoleAsync(usuario, funcao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task LogarUsuario(Usuario usuario, bool lembrarDados)
        {
            try
            {
                await _gerenciadorDeLogin.SignInAsync(usuario, lembrarDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> VerificarSeExisteRegistro()
        {
            try
            {
                return await _contexto.Usuarios.CountAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
