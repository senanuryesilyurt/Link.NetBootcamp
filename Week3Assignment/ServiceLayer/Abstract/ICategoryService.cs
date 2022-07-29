using DataAccessLayer.Entities;
using ServiceLayer.Models;
using ServiceLayer.Models.Responses;

namespace ServiceLayer.Abstract
{
    public interface ICategoryService
    {
        public IResult GetAll();
        public IResult Add(Category category);
        public IResult Update(Category category);
        public IResult Delete(Category category);
    }
}
