using Core.DTOs;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        TokenDto CreateToken(User user, List<OperationClaim> operationClaims);
        string CreateRefreshToken(User user);
    }
}
