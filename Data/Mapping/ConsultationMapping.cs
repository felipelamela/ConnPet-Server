using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping;


public class ConsultationMapping : IEntityTypeConfiguration<Consultation>
{
    public void Configure(EntityTypeBuilder<Consultation> builder)
    {
        builder.ToTable("Consultation");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Reason)
            .IsRequired()
            .HasColumnType("NVARCHAR(500)");

        builder.Property(x => x.Status)
            .IsRequired()
            .HasConversion<string>()
            .HasColumnType("NVARCHAR(20)");

        builder.Property(x => x.Diagnosis)
            .HasColumnType("NVARCHAR(500)");

        builder.Property(x => x.Observation)
            .HasColumnType("NVARCHAR(1000)");

        builder.Property(x => x.DateSchedule)
            .IsRequired()
            .HasColumnType("DATETIME");

        builder.HasOne(c => c.Clinic)
            .WithMany(cl => cl.Consultations)
            .HasForeignKey(c => c.ClinicId)
          .OnDelete(DeleteBehavior.Restrict);


        builder.HasOne(c => c.Vet)
            .WithMany()
            .HasForeignKey(c => c.VetId)
          .OnDelete(DeleteBehavior.Restrict);


        builder.HasOne(c => c.Pet)
            .WithMany()
            .HasForeignKey(c => c.PetId)
          .OnDelete(DeleteBehavior.Restrict);

    }

}