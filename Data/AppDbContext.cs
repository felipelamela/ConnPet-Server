using System.Reflection;
using Api.models;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<Address> Addresses { get; set; } = null!;
  public DbSet<Clinic> Clinics { get; set; } = null!;
  public DbSet<Consultation> Consultations { get; set; } = null!;
  public DbSet<LoginAuth> LoginAuths { get; set; } = null!;
  public DbSet<Pet> Pets { get; set; } = null!;
  public DbSet<Tutor> Tutors { get; set; } = null!;
  public DbSet<User> Users { get; set; } = null!;

  protected override void OnModelCreating(ModelBuilder model)
  {
    model.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}