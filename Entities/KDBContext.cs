using Microsoft.EntityFrameworkCore;

namespace Product_Kolmeo.Entities
{
    public class KDBContext: DbContext
    {
        private readonly DbContextOptions _options;
        public KDBContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
