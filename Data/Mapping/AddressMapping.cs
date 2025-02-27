using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;

public class AddressMapping : IEntityTypeConfiguration<Address>
{
  public void Configure(EntityTypeBuilder<Address> builder)
  {
    builder.ToTable("Address");

    builder.HasKey(x => x.Id);

    builder.Property(x => x.PostalCode)
      .IsRequired(true)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(8);

    builder.Property(x => x.Street)
      .IsRequired(true)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(255);

    builder.Property(x => x.Number)
      .IsRequired(true)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(30);

    builder.Property(x => x.Neighborhood)
      .IsRequired(false)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(180);

    builder.Property(x => x.City)
      .IsRequired(true)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(180);

    builder.Property(x => x.State)
      .IsRequired(true)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(50);

    builder.Property(x => x.Country)
      .IsRequired(true)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(30);

    builder.Property(x => x.Complement)
      .IsRequired(false)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(255);

    builder.Property(x => x.CreatedAt)
      .IsRequired(true)
      .HasColumnType("DATETIME");

    builder.Property(x => x.UpdatedAt)
      .IsRequired(false)
      .HasColumnType("DATETIME");
  }
}