using DataAccessLayer.Abstarct;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EFProductDal : EFEntityRepositoryBase<Product>, IProductDal
    {
        AppDbContext _context;
        public EFProductDal(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<ProductDto> GetAllProductDto()
        {

            var fullProductList = "sp_full_products";
            var result = _context.ProductDtos.FromSqlRaw($"exec {fullProductList}").ToList();

            return result.ToList();

        }
    }
}
