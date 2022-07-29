using DataAccessLayer.Abstarct;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Tablolar arası ilişki
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }

        // Foreign Key tanımlaması 
        public int CategoryId { get; set; }
    }
}
