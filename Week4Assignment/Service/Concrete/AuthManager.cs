using Business.Abstract;
using Core.DTOs;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Service.Constans;


namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<TokenDto> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var token = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<TokenDto>(token, Messages.AccessTokenCreated);
        }

        //kullanıcının kayıtlı olma durumu kontrol edilip şifre doğrulaması yapıldı
        public IDataResult<User> Login(LoginDto loginDto)
        {
            var userToCheck = _userService.GetByMail(loginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(loginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        //Kullanıcı kaydı yapıldı
        public IDataResult<User> Register(RegisterDto registerDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = registerDto.Email,
                UserName = registerDto.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered); ;
        }

        //Kullanıcı mevcut mu?
        public IDataResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
