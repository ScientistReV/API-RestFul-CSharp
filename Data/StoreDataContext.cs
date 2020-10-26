using Microsoft.EntityFrameworkCore;
using Loja.Data.Maps;
using Loja.Models;

namespace Loja.Data
{
  public class StoreDataContext : DbContext
  {
    public DbSet<Bicicleta> Bicicletas{get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=DESKTOP-62AED54\SQLDEVELOPER;Database=lojadebicicleta;User ID=SA;Password=mega826748");
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.ApplyConfiguration(new BicicletaMap());
    }

  }

}