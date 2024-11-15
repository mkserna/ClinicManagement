
using Microsoft.EntityFrameworkCore;
using Assessment_MarianaPerezSerna.Models;

namespace Assessment_MarianaPerezSerna.Seeders;
public class PatientsSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>().HasData(

            new Patient
            {
                Id = 1,
                Name = "juan",
                Lastname = "perez",
                Email = "juanperez@gmail.com",
                Password = "741258963",
                Phone = "1234567890",
                Address = "calle falsa 123, ciudad x",
                RoleId = 2,
            },
            new Patient
            {
                Id = 2,
                Name = "ana",
                Lastname = "garcia",
                Email = "anagarcia@yahoo.com",
                Password = "741258963",
                Phone = "0987654321",
                Address = "avenida del sol 456, ciudad y",
                RoleId = 2,
            },
            new Patient
            {
                Id = 3,
                Name = "luis",
                Lastname = "martinez",
                Email = "luismartinez@outlook.com",
                Password = "741258963",
                Phone = "5678901234",
                Address = "barrio norte 789, ciudad z",
                RoleId = 2,
            },
            new Patient
            {
                Id = 4,
                Name = "maria",
                Lastname = "rodriguez",
                Email = "mariarodriguez@hotmail.com",
                Password = "741258963",
                Phone = "1234509876",
                Address = "calle nueva 101, ciudad w",
                RoleId = 2,
            },
            new Patient
            {
                Id = 5,
                Name = "pedro",
                Lastname = "lopez",
                Email = "pedrolopez@correo.com",
                Password = "741258963",
                Phone = "1122334455",
                Address = "plaza central 202, ciudad v",
                RoleId = 2,
            }

        );
    }

}
