﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Complement")
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Neighborhood")
                        .HasMaxLength(180)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("Api.Models.Clinic", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("BIGINT");

                    b.Property<long?>("AddressId1")
                        .HasColumnType("bigint");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(14)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("CorporateName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DigitalCertification")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("MunicipalRegistration")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("StateRegistration")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("TradingName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserAdminId")
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("AddressId1");

                    b.HasIndex("UserAdminId")
                        .IsUnique();

                    b.ToTable("Clinic", (string)null);
                });

            modelBuilder.Entity("Api.Models.Consultation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ClinicId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSchedule")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<long>("PetId")
                        .HasColumnType("bigint");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("VetId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("PetId");

                    b.HasIndex("VetId");

                    b.ToTable("Consultation", (string)null);
                });

            modelBuilder.Entity("Api.Models.Pet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(8)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("CHAR(1)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<long>("TutorId")
                        .HasColumnType("BIGINT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("Api.Models.Tutor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(14)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(300)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Tutor", (string)null);
                });

            modelBuilder.Entity("Api.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("BIGINT");

                    b.Property<long?>("AddressId1")
                        .HasColumnType("bigint");

                    b.Property<string>("CRMV")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<long>("ClinicId")
                        .HasColumnType("BIGINT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(14)");

                    b.Property<long>("LoginAuthId")
                        .HasColumnType("BIGINT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("StatusWorker")
                        .IsRequired()
                        .HasColumnType("CHAR(1)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("CHAR(1)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AddressId1");

                    b.HasIndex("ClinicId");

                    b.HasIndex("LoginAuthId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Api.models.LoginAuth", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(300)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(300)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("LoginAuth", (string)null);
                });

            modelBuilder.Entity("Api.Models.Clinic", b =>
                {
                    b.HasOne("Api.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("Api.Models.Clinic", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Api.Models.Address", null)
                        .WithMany("Clinics")
                        .HasForeignKey("AddressId1");

                    b.HasOne("Api.Models.User", "UserAdmin")
                        .WithOne()
                        .HasForeignKey("Api.Models.Clinic", "UserAdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("UserAdmin");
                });

            modelBuilder.Entity("Api.Models.Consultation", b =>
                {
                    b.HasOne("Api.Models.Clinic", "Clinic")
                        .WithMany("Consultations")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Api.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Api.Models.User", "Vet")
                        .WithMany()
                        .HasForeignKey("VetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Pet");

                    b.Navigation("Vet");
                });

            modelBuilder.Entity("Api.Models.Pet", b =>
                {
                    b.HasOne("Api.Models.Tutor", "Tutor")
                        .WithMany("Pets")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("Api.Models.Tutor", b =>
                {
                    b.HasOne("Api.Models.Address", "Address")
                        .WithMany("Tutors")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Api.Models.User", b =>
                {
                    b.HasOne("Api.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Api.Models.Address", null)
                        .WithMany("Users")
                        .HasForeignKey("AddressId1");

                    b.HasOne("Api.Models.Clinic", "Clinic")
                        .WithMany("Users")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Api.models.LoginAuth", "LoginAuth")
                        .WithMany()
                        .HasForeignKey("LoginAuthId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Clinic");

                    b.Navigation("LoginAuth");
                });

            modelBuilder.Entity("Api.Models.Address", b =>
                {
                    b.Navigation("Clinics");

                    b.Navigation("Tutors");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Api.Models.Clinic", b =>
                {
                    b.Navigation("Consultations");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Api.Models.Tutor", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
