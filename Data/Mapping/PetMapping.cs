using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;

public class PetMapping : IEntityTypeConfiguration<Pet>
{
  public void Configure(EntityTypeBuilder<Pet> builder)
  {
    builder.ToTable("Pet");

    builder.HasKey(x => x.Id);

    builder.Property(x => x.TutorId)
      .HasColumnType("BIGINT");

    builder.Property(x => x.Name)
      .IsRequired(true)
      .HasColumnType("NVARCHAR(8)");

    builder.Property(x => x.BirthDate)
      .IsRequired(true)
      .HasColumnType("DATETIME");

    builder.Property(x => x.Species)
      .IsRequired(true)
      .HasColumnType("NVARCHAR(20)");

    builder.Property(x => x.Breed)
      .IsRequired(true)
      .HasColumnType("NVARCHAR(30)");

    builder.Property(x => x.Sex)
        .IsRequired(true)
        .HasColumnType("CHAR(1)");

    builder.Property(x => x.CreatedAt)
      .IsRequired(true)
      .HasColumnType("DATETIME");

    builder.Property(x => x.UpdatedAt)
      .IsRequired(false)
      .HasColumnType("DATETIME");

    builder.HasOne(p => p.Tutor)
        .WithMany(u => u.Pets)
        .HasForeignKey(p => p.TutorId);
  }
}