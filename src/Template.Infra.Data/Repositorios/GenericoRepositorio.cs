using Template.Domain.Interfaces;
using Template.Domain.Shared.Entidades;
using Template.Infra.Data.Configuracoes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Template.Infra.Data.Repositorios
{
    public class GenericoRepositorio<T> : IGenericoRepositorio<T> where T : Entidade
    {
        private readonly ContextoDatabase _db;
        protected readonly DbSet<T> DbSet;

        public GenericoRepositorio(ContextoDatabase db)
        {
            _db = db;
            DbSet = _db.Set<T>();
        }

        public virtual async Task Inserir(T obj) =>
            await DbSet.AddAsync(obj);

        public virtual async Task Inserir(ICollection<T> obj) =>
           await DbSet.AddRangeAsync(obj);

        public virtual void Alterar(T obj) =>
             DbSet.Update(obj);

        public virtual void Alterar(ICollection<T> obj) =>
             DbSet.UpdateRange(obj);

        public virtual void Remover(T obj) =>
            DbSet.Remove(obj);

        public virtual void Remover(ICollection<T> obj) =>
            DbSet.RemoveRange(obj);

        public virtual async Task<ICollection<T>> ListarTodos() =>
            await DbSet.AsNoTracking().ToListAsync();

        public async Task<ICollection<T>> Listar(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)               
                return await DbSet.AsNoTracking().Where(predicate).ToListAsync();

            return await DbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<T> BuscarPorId(int id) =>
             await DbSet.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);


        private readonly bool _disposed = false;

        ~GenericoRepositorio() =>
           Dispose();

        public void Dispose()
        {
            if (!_disposed)
                _db.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
