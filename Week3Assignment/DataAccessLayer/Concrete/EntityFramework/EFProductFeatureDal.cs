using DataAccessLayer.Abstarct;
using DataAccessLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EFProductFeatureDal : EFEntityRepositoryBase<ProductFeature>, IProductFeatureDal
    {
        //public EFProductFeatureDal(IUnitOfWork unitOfWork) : base(unitOfWork)
        //{
        //}
        public EFProductFeatureDal(AppDbContext context) : base(context)
        {
        }
    }
}
