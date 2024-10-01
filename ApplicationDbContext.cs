// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models; // Замените на ваше пространство имен

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<YourEntity> YourEntities { get; set; } // Замените YourEntity на вашу модель
}

