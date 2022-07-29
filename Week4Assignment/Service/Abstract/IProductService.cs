using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Service.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAllProduct();
       // IDataResult<List<ProductDto>> GetProductDto();
        IDataResult Add(Product product);
        IDataResult Update(Product product);
        IDataResult Delete(Product product);
    }
}
