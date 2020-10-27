using System.Threading;
using System.Threading.Tasks;
using DoubleA.DataAccess.Contract.Repositories;

namespace DoubleA.DataAccess.Contract.UnitOfWork
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Get an instance of a repository
        /// </summary>
        TRepository GetRepository<TRepository>() where TRepository : class, IRepository;

        /// <summary>
        /// Save current changes
        /// </summary>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
