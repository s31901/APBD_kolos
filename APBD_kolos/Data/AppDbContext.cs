using Microsoft.EntityFrameworkCore;

namespace APBD_kolos.Data;

public class AppDbContext : DbContext
{
    protected AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    //tutaj wszystkie encje, przyklad:
    //public DbSet<ComponentType> ComponentTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //tutaj jak seedowanie danych 
        /*modelBuilder.Entity<ComponentType>().HasData(
            new ComponentType { Id = 1, Abbreviation = "CPU", Name = "Central Processing Unit" },
            new ComponentType { Id = 2, Abbreviation = "GPU", Name = "Graphics Processing Unit" },
            new ComponentType { Id = 3, Abbreviation = "RAM", Name = "Random Access Memory" }
        );*/
    }
}