using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DoubleA.EntityModel.Entities;

namespace DoubleA.DataAccess.Contract.Repositories
{
    public interface IKeyedEntityRepository<TEntity> : IRepository where TEntity : IKeyedEntity
    {
        /// <summary>
        /// Get a single entity by matching id
        /// </summary>
        Task<TEntity?> GetAsync(Guid id);

        /// <summary>
        /// Get entities by multiple matching ids
        /// </summary>
        Task<IDictionary<Guid, TEntity>> GetAsync(ISet<Guid> ids);

        /// <summary>
        /// Get all entities
        /// </summary>
        Task<IDictionary<Guid, TEntity>> GetAsync();

        /// <summary>
        /// Get filtered entities
        /// </summary>
        Task<IDictionary<Guid, TEntity>> GetAsync(params Expression<Func<TEntity, bool>>[] filters);

        /// <summary>
        /// Create new entity
        /// </summary>
        Task<Guid> CreateAsync(TEntity newEntity);

        /// <summary>
        /// Update entity
        /// </summary>
        Task UpdateAsync(TEntity updatedEntity);

        /// <summary>
        /// Remove entity
        /// </summary>
        Task RemoveAsync(Guid id);
    }
}
