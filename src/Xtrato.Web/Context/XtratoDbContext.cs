using Microsoft.EntityFrameworkCore;
using Xtrato.Web.Models;

namespace Xtrato.Web.Context;

public class XtratoDbContext : DbContext
{
    public XtratoDbContext(DbContextOptions<XtratoDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Lancamento>();
    }

    public DbSet<Lancamento> Lancamentos { get; set; }
}
