

namespace Sales_1.Domain.Models
{
    using System.Data.Entity;
    using Sales_1.Common.Models;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
