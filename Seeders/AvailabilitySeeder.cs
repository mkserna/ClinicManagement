

using Assessment_MarianaPerezSerna.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Seeders;
public class AvailabilitySeeder
{

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Availability>().HasData(

            new Availability
            {
                Id = 1,
                Date = new DateOnly(2024, 11, 20),  // Fecha de ejemplo
                IsAvailable = true,
                HourStart = new TimeOnly(8, 0),   // 08:00 AM
                HourEnd = new TimeOnly(12, 0),     // 12:00 PM
                DoctorId = 1,                      // Id del doctor correspondiente
            },
            new Availability
            {
                Id = 2,
                Date = new DateOnly(2024, 11, 20),
                IsAvailable = true,
                HourStart = new TimeOnly(14, 0),  // 02:00 PM
                HourEnd = new TimeOnly(18, 0),    // 06:00 PM
                DoctorId = 2,
            },
            new Availability
            {
                Id = 3,
                Date = new DateOnly(2024, 11, 21),
                IsAvailable = false,  // Médico no disponible
                HourStart = new TimeOnly(8, 0),
                HourEnd = new TimeOnly(12, 0),
                DoctorId = 3,
            },
            new Availability
            {
                Id = 4,
                Date = new DateOnly(2024, 11, 21),
                IsAvailable = true,
                HourStart = new TimeOnly(9, 0),  // 09:00 AM
                HourEnd = new TimeOnly(13, 0),   // 01:00 PM
                DoctorId = 4,
            },
            new Availability
            {
                Id = 5,
                Date = new DateOnly(2024, 11, 22),
                IsAvailable = true,
                HourStart = new TimeOnly(10, 0),  // 10:00 AM
                HourEnd = new TimeOnly(14, 0),    // 02:00 PM
                DoctorId = 5,
            },
            new Availability
            {
                Id = 6,
                Date = new DateOnly(2024, 11, 22),
                IsAvailable = false,  // Médico no disponible
                HourStart = new TimeOnly(15, 0),
                HourEnd = new TimeOnly(19, 0),
                DoctorId = 6,
            },
            new Availability
            {
                Id = 7,
                Date = new DateOnly(2024, 11, 23),
                IsAvailable = true,
                HourStart = new TimeOnly(8, 30),  // 08:30 AM
                HourEnd = new TimeOnly(12, 30),   // 12:30 PM
                DoctorId = 1,
            },
            new Availability
            {
                Id = 8,
                Date = new DateOnly(2024, 11, 23),
                IsAvailable = true,
                HourStart = new TimeOnly(14, 30),  // 02:30 PM
                HourEnd = new TimeOnly(18, 30),    // 06:30 PM
                DoctorId = 2,
            },
            new Availability
            {
                Id = 9,
                Date = new DateOnly(2024, 11, 24),
                IsAvailable = true,
                HourStart = new TimeOnly(7, 0),   // 07:00 AM
                HourEnd = new TimeOnly(11, 0),     // 11:00 AM
                DoctorId = 3,
            },
            new Availability
            {
                Id = 10,
                Date = new DateOnly(2024, 11, 24),
                IsAvailable = true,
                HourStart = new TimeOnly(12, 0),  // 12:00 PM
                HourEnd = new TimeOnly(16, 0),    // 04:00 PM
                DoctorId = 4,
            }
        );
    }

}
