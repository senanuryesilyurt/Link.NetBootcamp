
using System.Linq.Expressions;

namespace DataAccessLayer.Abstarct
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        void Add(T model);
        void Update(T model);
        void Delete(T model);
        void CreateAll(T model1, T model2);
    }
}
