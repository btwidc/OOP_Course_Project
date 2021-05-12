using System.Data.Entity;

namespace OnlineStore.Model.Data
{
    class ProductContext : DbContext
    {
        public ProductContext() : base("DBConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
