using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Abstarct;

namespace DataAccessLayer.Entities
{
    public class ProductFeature:IEntity
    {
        // Primary Key
        [Key]
        // Product tablosundaki id değerini alacak
        [ForeignKey("Product")]
        public int Id { get; set; }

        public string Name { get; set; }

        // Tablolar arası 1-1 ilişki
        public Product Product { get; set; }

    }
}
