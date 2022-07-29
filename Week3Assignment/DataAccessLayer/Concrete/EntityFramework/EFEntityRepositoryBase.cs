using DataAccessLayer.Abstarct;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.EntityFramework
{
    //Generic Repository Pattern
    public class EFEntityRepositoryBase<TModel> : IEntityRepository<TModel> 
        where TModel:class,IEntity,new()
    {
        private AppDbContext _context;

        public EFEntityRepositoryBase(AppDbContext context)
        {
            _context=context;
        }

        public void Add(TModel model)
        {
            var addedModel = _context.Entry(model);
            addedModel.State = EntityState.Added;
            
        }

        // model1 veya model2 ile ilgili işlemlerden herhangibi biri başarısız olursa tüm işlemleri geri al.
        public void CreateAll(TModel model1, TModel model2)
        {
            
            var addedModel1 = _context.Entry(model1);
            var addedModel2 = _context.Entry(model2);
            addedModel1.State = EntityState.Added;
            addedModel2.State = EntityState.Added;

        }

        public void Delete(TModel model)
        {
            var deletedEntity = _context.Entry(model);
            deletedEntity.State = EntityState.Deleted;
        }

        public List<TModel> GetAll()
        {
            return _context.Set<TModel>().ToList();
        }

        public void Update(TModel model)
        {
            var updatedModel=_context.Entry(model);
            updatedModel.State = EntityState.Modified;
        }
    }
}
