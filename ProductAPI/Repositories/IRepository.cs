using System.Linq.Expressions;

namespace ProductAPI.Repositories
{
    public interface IRepository<TEntity>
    {
        //CREATE
        Task<int> Add(TEntity product);
        // READ
        Task<TEntity?> GetById(int id);
        Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);
        // UPDATE
        Task<bool> Update(TEntity product);
        // DELETE
        Task<bool> Delete(int id);
    }
}
