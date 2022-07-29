using DataAccessLayer.Abstarct;
using DataAccessLayer.Entities;
using ServiceLayer.Abstract;
using ServiceLayer.Models.Responses;

namespace ServiceLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private IUnitOfWork _unitOfWork;
        public CategoryManager(ICategoryDal categoryDal, IUnitOfWork unitOfWork)
        {
            _categoryDal = categoryDal;
            _unitOfWork = unitOfWork;
        }

        public IResult Add(Category category)
        {
            if(category is null)
            {
                return new ErrorResult();
            }
            _categoryDal.Add(category);
            _unitOfWork.Commit();
            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
            if (category is null)
            {
                return new ErrorResult();
            }

            _categoryDal.Delete(category);
            _unitOfWork.Commit();
            return new SuccessResult();
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IResult Update(Category category)
        {

            if (category is null)
            {
                return new ErrorResult();
            }

            _categoryDal.Update(category);
            _unitOfWork.Commit();
            return new SuccessResult();
        }
    }
}
