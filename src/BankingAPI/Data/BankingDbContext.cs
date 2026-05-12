using System.Transactions;
using BankingAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankingAPI.Data;

public class BankingDbContext: IdentityDbContext
{
    public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options)
    {}

    public DbSet<Account> Accounts => Set<Account>();
    //public DbSet<Transaction> Transactions => Set<Transaction>();

     protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Account configuration
        builder.Entity<Account>(entity =>
        {
            entity.Property(a => a.Balance).HasPrecision(18, 2);
            entity.Property(a => a.AccountNumber).HasMaxLength(20);
            entity.HasIndex(a => a.AccountNumber).IsUnique();
        });
    }

}