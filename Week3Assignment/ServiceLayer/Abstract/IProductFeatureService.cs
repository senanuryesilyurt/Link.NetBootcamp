using DataAccessLayer.Entities;
using ServiceLayer.Models.Responses;

namespace ServiceLayer.Abstract
{
    public interface IProductFeatureService
    {
        public IResult GetAll();
        public IResult Add(ProductFeature productFeature);
        public IResult Update(ProductFeature productFeature);
        public IResult Delete(ProductFeature productFeature);
    }
}
