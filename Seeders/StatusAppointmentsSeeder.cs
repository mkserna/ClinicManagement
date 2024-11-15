
using Assessment_MarianaPerezSerna.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Seeders;
public class StatusAppointmentsSeeder
{

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StatusAppointment>().HasData(

            new StatusAppointment
            {
                Id = 1,
                Name = "available",
            },
            new StatusAppointment
            {
                Id = 2,
                Name = "booked",
            },
            new StatusAppointment
            {
                Id = 3,
                Name = "canceled",
            }

        );
    }

}
