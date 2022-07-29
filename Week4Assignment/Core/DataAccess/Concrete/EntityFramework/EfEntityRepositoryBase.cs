using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    //Generic Repository Pattern
    public class EFEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private DbContext _context;

        public EFEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity model)
        {
            var addedModel = _context.Entry(model);
            addedModel.State = EntityState.Added;
            _context.SaveChanges();

        }

        public void Delete(TEntity model)
        {
            var deletedEntity = _context.Entry(model);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity model)
        {
            var updatedModel = _context.Entry(model);
            updatedModel.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
