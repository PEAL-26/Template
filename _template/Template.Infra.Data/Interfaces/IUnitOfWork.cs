using System.Threading.Tasks;

namespace $safeprojectname$.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();
    }
}
