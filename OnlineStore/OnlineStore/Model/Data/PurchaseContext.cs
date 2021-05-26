using System.Data.Entity;

namespace OnlineStore.Model.Data
{
    class PurchaseContext : DbContext
    {
        public PurchaseContext() : base("DBConnection")
        {
        }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
