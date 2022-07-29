using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();

        //Expression filtreleme işlemi yapmamızı sağlar.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T model);
        void Update(T model);
        void Delete(T model);
    }
}
