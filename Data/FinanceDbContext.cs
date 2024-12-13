using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FinanceApp.Data;

public class FinanceAppDbContext : DbContext
{
    public DbSet<UserRegister> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
        .SetBasePath(AppContext.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .Build();

        optionsBuilder = optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnetion"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserRegister>().ToTable("Users");
        modelBuilder.Entity<Transaction>().ToTable("Transactions");

        modelBuilder.Entity<Transaction>()
        .Property(t => t.Amount)
        .HasColumnType("decimal(18,2)");
    }
}