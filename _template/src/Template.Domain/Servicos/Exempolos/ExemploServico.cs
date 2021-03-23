using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using $safeprojectname$.Entidades;
using $safeprojectname$.Interfaces;

namespace $safeprojectname$.Servicos.Exempolos
{
    public class ExemploServico : IExemploServico
    {
        public Task<Exemplo> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Guardar(Exemplo obj)
        {
            throw new NotImplementedException();
        }

        public Task Guardar(ICollection<Exemplo> obj)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Exemplo>> Listar(Expression<Func<Exemplo, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Exemplo>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Exemplo obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(ICollection<Exemplo> obj)
        {
            throw new NotImplementedException();
        }
    }
}
