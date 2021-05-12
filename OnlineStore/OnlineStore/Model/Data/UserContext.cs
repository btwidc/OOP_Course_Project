using System.Data.Entity;

namespace OnlineStore.Model.Data
{
    class UserContext : DbContext
    {
        public UserContext() : base("DBConnection")
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
