using Business.Abstract;
using DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.DTOs;
using Core.DataAccess.Concrete.UnitOfWork;

namespace Service.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IUnitOfWork _unitOfWork;

        public UserManager(IUserDal userDal, IUnitOfWork unitOfWork)
        {
            _userDal = userDal;
            _unitOfWork=unitOfWork;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
            _unitOfWork.Commit();
        }

        public List<UserDto> GetAllUsers()
        {
            return _userDal.GetAllUsers();
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
