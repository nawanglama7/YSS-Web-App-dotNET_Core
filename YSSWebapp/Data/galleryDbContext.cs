namespace YSSWebapp.Data
{
    public class galleryDbContext: DbContext
    {
        public galleryDbContext(DbContextOptions<galleryDbContext> options) : base(options)
        {
        }
        public DbSet<Gallery> gallery { get; set; }
    }
}
