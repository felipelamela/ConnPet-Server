using Api.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
  public class LoginAuthMapping : IEntityTypeConfiguration<LoginAuth>
  {
    public void Configure(EntityTypeBuilder<LoginAuth> builder)
    {
      builder.ToTable("LoginAuth");

      builder.HasKey(x => x.Id);

      builder.Property(x => x.Login)
          .IsRequired(true)
          .HasColumnType("NVARCHAR(300)");

      builder.Property(x => x.Password)
          .IsRequired(true)
          .HasColumnType("NVARCHAR(300)");

      builder.Property(x => x.CreatedAt)
          .IsRequired(true)
          .HasColumnType("DATETIME");

      builder.Property(x => x.UpdatedAt)
          .IsRequired(false)
          .HasColumnType("DATETIME");
    }
  }
}