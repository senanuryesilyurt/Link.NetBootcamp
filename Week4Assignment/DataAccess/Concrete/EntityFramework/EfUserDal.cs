using Core.DTOs;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EFEntityRepositoryBase<User>, IUserDal
    {
        AppDbContext _context;
        public EfUserDal(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<UserDto> GetAllUsers()
        {
            var sp = "sp_GetAllUsers";
            var getAllUsers = _context.Set<UserDto>().FromSqlRaw($"exec {sp}").ToList();
            return getAllUsers;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            var sp = "sp_GetClaims";
            var getClaims = _context.Set<OperationClaim>().FromSqlRaw($"exec {sp}").ToList();
            return getClaims;
        }
    }
}
