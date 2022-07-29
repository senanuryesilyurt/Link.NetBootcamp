using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstarct
{
    public interface IProductDal:IEntityRepository<Product>
    {
        public List<ProductDto> GetAllProductDto();
    }
}
