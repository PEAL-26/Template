using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Template.Application.Interfaces
{
    public interface IGenericaApp<T> where T : class
    {     
        Task Guardar(T obj);
        Task Guardar(ICollection<T> obj); 
        void Remover(T obj);
        void Remover(ICollection<T> obj);
        Task<ICollection<T>> ListarTodos();
        Task<T> BuscarPorId(int id);
    }
}
