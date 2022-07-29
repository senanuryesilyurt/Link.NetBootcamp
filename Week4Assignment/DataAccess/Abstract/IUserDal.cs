using Core.DataAccess.Abstract;
using Core.DTOs;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserDto> GetAllUsers();
        List<OperationClaim> GetClaims(User user);
    }
}
