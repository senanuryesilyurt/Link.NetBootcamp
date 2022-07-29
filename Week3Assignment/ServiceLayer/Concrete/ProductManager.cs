using DataAccessLayer;
using DataAccessLayer.Abstarct;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using ServiceLayer.Abstract;
using ServiceLayer.Constans;
using ServiceLayer.Models.Responses;

namespace ServiceLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product is null)
            {
                return new ErrorResult(Messages.NullProductAdded);
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult AddProducts(Product product1, Product product2)
        {
            if (product1 is null) { return new ErrorResult(); }
            if (product2 is null) { return new ErrorResult(); }

            _productDal.CreateAll(product1, product2);
            return new SuccessResult();
        }

        public IResult Delete(Product product)
        {
            if(product is null)
            {
                return new ErrorResult(Messages.NullProduct);
            }

            _productDal.Delete(product);
            return new SuccessResult(Messages.DeletedProduct);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IResult Update(Product product)
        {
            
            if (product is null)
            {
                return new ErrorResult(Messages.NullProduct);
            }

            _productDal.Update(product);
            return new SuccessResult(Messages.UpdatedProduct);
        }

        public IResult GetAllProductDto()
        {
            return new SuccessDataResult<List<ProductDto>>(_productDal.GetAllProductDto());
        }
    }
}
