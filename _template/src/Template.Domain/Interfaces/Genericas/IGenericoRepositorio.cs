using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace $safeprojectname$.Interfaces
{
    public interface IGenericoRepositorio<T>
    {
        Task Inserir(T obj);
        Task Inserir(ICollection<T> obj);
        void Alterar(T obj);
        void Alterar(ICollection<T> obj);
        void Remover(T obj);
        void Remover(ICollection<T> obj);
        Task<ICollection<T>> ListarTodos();
        Task<ICollection<T>> Listar(Expression<Func<T, bool>> predicate = null);
        Task<T> BuscarPorId(int id);
      
    }
}
