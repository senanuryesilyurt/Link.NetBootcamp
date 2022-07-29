
using DataAccessLayer.Abstarct;

namespace DataAccessLayer.Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navigation property : Bir property'nin başka bir property'ye referans vermesi.
        // Tablolar arasındaki 1-n ilişkiyi belirtiyoruz.
        public List<Product> Products { get; set; }
    }
}
