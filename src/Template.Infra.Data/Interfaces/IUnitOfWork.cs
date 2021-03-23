using System.Threading.Tasks;

namespace Template.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();
    }
}
