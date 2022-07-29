using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.CachingWithRedis;
using Core.DataAccess.Concrete.UnitOfWork;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Service.Abstract;
using Service.Constans;
using StackExchange.Redis;

namespace Service.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private IUnitOfWork _unitOfWork;
        private ICacheService _cacheService;

        public ProductManager(IProductDal productDal, IUnitOfWork unitOfwork, ICacheService cacheService)
        {
            _productDal = productDal;
            _unitOfWork=unitOfwork;
            _cacheService = cacheService;
        }

        private List<Product> GetProductsFromCache()
        {
            List<Product> products = _productDal.GetAll();
            return _cacheService.GetOrAdd("allProducts", () => { return products; });
        }

        //[SecuredOperation("manager")]
        //IProductService içinde get olan tüm keyleri sil.
        [CacheRemoveAspect("IProductService.Get")]
        public IDataResult Add(Product product)
        {
            if (product is null)
            {
                return new ErrorResult(Messages.NullProductAdded);
            }
            _productDal.Add(product);
            _unitOfWork.Commit();
            return new SuccessResult(Messages.ProductAdded);
        }

        //[SecuredOperation("manager")]
        public IDataResult Delete(Product product)
        {
            if (product is null)
            {
                return new ErrorResult(Messages.NullProduct);
            }

            _productDal.Delete(product);
            _unitOfWork.Commit();
            return new SuccessResult(Messages.DeletedProduct);
        }

        //[SecuredOperation("user")]
        [CacheAspect]
        public IDataResult<List<Product>> GetAllProduct()
        {
            return new SuccessDataResult<List<Product>>(GetProductsFromCache(), Messages.ProductsListed);
            //return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        //[SecuredOperation("manager")]
        [CacheRemoveAspect("IProductService.Get")]
        public IDataResult Update(Product product)
        {
            if (product is null)
            {
                return new ErrorResult(Messages.NullProduct);
            }

            _productDal.Update(product);
            _unitOfWork.Commit();
            return new SuccessResult(Messages.UpdatedProduct);
        }
    }
}
