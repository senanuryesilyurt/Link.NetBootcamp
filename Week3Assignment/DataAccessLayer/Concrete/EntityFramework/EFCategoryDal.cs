using DataAccessLayer.Abstarct;
using DataAccessLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryDal : EFEntityRepositoryBase<Category>, ICategoryDal
    {
        //public EFCategoryDal(IUnitOfWork unitOfWork)
        //{
        //}
        public EFCategoryDal(AppDbContext context) : base(context)
        {
        }
    }
}
