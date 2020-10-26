using System;
using Microsoft.EntityFrameworkCore;
using Loja.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Data.Maps
{
  public class BicicletaMap: IEntityTypeConfiguration<Bicicleta>
  {
    public void Configure(EntityTypeBuilder<Bicicleta> builder){
      builder.ToTable("Bicicleta");
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Modelo).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
      builder.Property(x => x.Preco).IsRequired().HasColumnType("money");
      builder.Property(x => x.QtdEstoque).IsRequired();
      builder.Property(x => x.DataCriacao).IsRequired();
    }
  }
}