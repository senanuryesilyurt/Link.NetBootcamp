
using Core.Entities.Abstract;

namespace Core.DTOs
{
    public class ProductDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
