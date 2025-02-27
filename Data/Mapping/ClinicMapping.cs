using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;

public class ClinicMapping : IEntityTypeConfiguration<Clinic>
{
  public void Configure(EntityTypeBuilder<Clinic> builder)
  {
    builder.ToTable("Clinic");

    builder.HasKey(x => x.Id);

    builder.Property(x => x.CorporateName)
        .IsRequired()
        .HasColumnType("NVARCHAR(255)");

    builder.Property(x => x.TradingName)
        .IsRequired()
        .HasColumnType("NVARCHAR(255)");

    builder.Property(x => x.CNPJ)
        .IsRequired()
        .HasColumnType("NVARCHAR(14)");

    builder.Property(x => x.StateRegistration)
        .IsRequired()
        .HasColumnType("NVARCHAR(50)");

    builder.Property(x => x.MunicipalRegistration)
        .IsRequired()
        .HasColumnType("NVARCHAR(50)");

    builder.Property(x => x.Contact)
        .HasColumnType("NVARCHAR(100)");

    builder.Property(x => x.Email)
        .IsRequired(true)
        .HasColumnType("NVARCHAR(255)");

    builder.Property(x => x.DigitalCertification)
        .HasColumnType("NVARCHAR(255)");

    builder.Property(x => x.Document)
        .HasColumnType("NVARCHAR(50)");

    builder.Property(x => x.UserAdmin)
        .IsRequired(true)
        .HasColumnType("BIGINT");

    builder.HasOne(x => x.UserAdmin)
        .WithOne()
        .HasForeignKey<Clinic>(x => x.UserAdmin);

    builder.HasOne(x => x.Address)
        .WithOne()
        .HasForeignKey<Clinic>(x => x.AddressId)
        .OnDelete(DeleteBehavior.Restrict);

    builder.HasMany(x => x.Users)
        .WithOne()
        .HasForeignKey(x => x.ClinicId);
  }
}
