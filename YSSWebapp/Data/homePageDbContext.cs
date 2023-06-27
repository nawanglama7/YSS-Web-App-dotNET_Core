namespace YSSWebapp.Data
{
    public class homePageDbContext: DbContext
    {
        public homePageDbContext(DbContextOptions<homePageDbContext> options) : base(options)
        {
        }
        public DbSet<homePage> HomePage { get; set; }
        public DbSet<news> News { get; set; }
        public DbSet<members> Members { get; set; }

    }
}
