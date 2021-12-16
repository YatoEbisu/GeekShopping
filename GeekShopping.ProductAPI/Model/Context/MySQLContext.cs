using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> opt) : base(opt)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
