using Microsoft.EntityFrameworkCore;
using Models;

namespace EntetyDB
{
    public class DataDBContex : DbContext
    {
        public DataDBContex(DbContextOptions<DataDBContex> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
