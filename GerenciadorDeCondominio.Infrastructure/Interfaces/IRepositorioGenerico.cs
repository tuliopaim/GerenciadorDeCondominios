using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCondominios.Infrastructure.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> ObterTodos();

        Task<TEntity> PegarPorId(int id);
        Task<TEntity> PegarPorId(string id);

        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Excluir(TEntity entity);
        Task Excluir(int id);
        Task Excluir(string id);

    }
}
