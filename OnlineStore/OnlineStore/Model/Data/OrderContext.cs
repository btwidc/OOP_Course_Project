using System.Data.Entity;

namespace OnlineStore.Model.Data
{
    class OrderContext : DbContext
    {
        public OrderContext() : base("DBConnection")
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
