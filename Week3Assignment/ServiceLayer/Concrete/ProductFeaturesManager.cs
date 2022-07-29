using DataAccessLayer.Abstarct;
using DataAccessLayer.Entities;
using ServiceLayer.Abstract;
using ServiceLayer.Constans;
using ServiceLayer.Models.Responses;

namespace ServiceLayer.Concrete
{
    public class ProductFeaturesManager : IProductFeatureService
    {
        private readonly IProductFeatureDal _productFeatureDal;

        public ProductFeaturesManager(IProductFeatureDal productFeatureDal)
        {
            _productFeatureDal = productFeatureDal;
        }

        public IResult Add(ProductFeature productFeature)
        {
            if(productFeature is null)
            {
                return new ErrorResult();
            }
            _productFeatureDal.Add(productFeature);
            return new SuccessResult(Messages.AddedProductFeature);
        }

        public IResult Delete(ProductFeature productFeature)
        {
           
            if(productFeature is null)
            {
                return new ErrorResult();
            }

            _productFeatureDal.Delete(productFeature);
            return new SuccessResult();
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<ProductFeature>>(_productFeatureDal.GetAll());
        }

        public IResult Update(ProductFeature productFeature)
        {
            if(productFeature is null)
            {
                return new ErrorResult();
            }

            _productFeatureDal.Update(productFeature);
            return new SuccessResult();
        }
    }
}
