using DataAccessLayer.Abstarct;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccessLayer.Concrete
{
    public class unitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public unitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
