using AndroidAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AndroidAPI.Data;

public class AndroidDbContext : DbContext
{
    public AndroidDbContext(DbContextOptions<AndroidDbContext> options) : base(options)
    {
        
    }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Technique> Techniques { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);
        modelBuilder.Entity<Technique>()
            .HasKey(t => t.Id);
        modelBuilder.Entity<Pizza>()
            .HasKey(p => p.Id);
    }
}