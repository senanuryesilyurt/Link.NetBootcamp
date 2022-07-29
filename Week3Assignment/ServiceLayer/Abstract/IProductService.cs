using DataAccessLayer.Entities;
using ServiceLayer.Models.Responses;

namespace ServiceLayer.Abstract
{
    public interface IProductService
    {
        public IResult GetAll();
        public IResult Add(Product product);
        public IResult Update(Product product);
        public IResult Delete(Product product);
        public IResult AddProducts(Product product1, Product product2);
        public IResult GetAllProductDto();
    }
}
