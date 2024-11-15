using Microsoft.EntityFrameworkCore;
using Assessment_MarianaPerezSerna.Seeders;
using Assessment_MarianaPerezSerna.Models;

namespace Assessment_MarianaPerezSerna.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Availability> Availabilities { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<StatusAppointment> StatusAppointments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
        AppointmentsSeeder.Seed(modelBuilder);
        AvailabilitySeeder.Seed(modelBuilder);
        DoctorSeeder.Seed(modelBuilder);
        PatientsSeeder.Seed(modelBuilder);
        RoleSeeder.Seed(modelBuilder);
        SpecialtySeeder.Seed(modelBuilder);
        StatusAppointmentsSeeder.Seed(modelBuilder);
    }
}
