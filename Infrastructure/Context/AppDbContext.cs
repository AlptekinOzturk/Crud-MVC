using CRUD_Mvc.Entities.Concrete;
using CRUD_Mvc.Infrastructure.EntitytypeConfiguration.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Mvc.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
