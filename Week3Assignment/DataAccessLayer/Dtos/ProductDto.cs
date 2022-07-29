using ServiceLayer.Abstract;

namespace DataAccessLayer.Dtos
{
    public class ProductDto:IDto
    {
        public string CategoryName { get; private set; }
        public string ProductName { get; private set; }
        public string FeatureName { get; private set; }
        public decimal Price { get; private set; }
    }
}
