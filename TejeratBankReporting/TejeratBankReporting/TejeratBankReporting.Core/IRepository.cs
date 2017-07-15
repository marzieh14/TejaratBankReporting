namespace TejeratBankReporting.Core
{
    using System.Linq;
    /// <summary>
    /// This interface must be implemented by all repositories to ensure UnitOfWork to work.
    /// Implement by generic version instead of this one.
    /// </summary>
    public interface IRepository
    {

    }

 
    public interface IRepository<TEntity, TPrimaryKey> : IRepository where TEntity : Entity<TPrimaryKey>
    {
    
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Gets an entity.
        /// </summary>
        /// <param name="key">Primary key of the entity to get</param>
        /// <returns>Entity</returns>
        TEntity Get(TPrimaryKey key);

        /// <summary>
        /// Inserts a new entity.
        /// </summary>
        /// <param name="entity">Entity</param>
        void Insert(TEntity entity);

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="entity">Entity</param>
        void Update(TEntity entity);

        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="id">Id of the entity</param>
        void Delete(TPrimaryKey id);
    }
}