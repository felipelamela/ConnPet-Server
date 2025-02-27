using System.Reflection;
using Api.models;
using Api.Models; // Corrigido para o namespace correto
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
  public class AppDbContext : DbContext // Corrigido para herdar de DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) // Construtor correto
    {
    }

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
}
