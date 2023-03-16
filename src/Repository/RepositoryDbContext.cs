using DockerBasics.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace DockerBasics.Repository
{
    public sealed class RepositoryDbContext : DbContext
    {
        public DbSet<DockerImage> DockerImages { get; set; }


        public RepositoryDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
