using Core.DTOs;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<UserDto> GetAllUsers();
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        void Add(User user);
    }
}
