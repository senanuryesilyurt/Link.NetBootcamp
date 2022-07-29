using Core.DTOs;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(RegisterDto registerDto, string password);
        IDataResult<User> Login(LoginDto loginDto);
        IDataResult UserExists(string email);
        IDataResult<TokenDto> CreateAccessToken(User user);
    }
}
