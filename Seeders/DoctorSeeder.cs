
using Microsoft.EntityFrameworkCore;
using Assessment_MarianaPerezSerna.Models;

namespace Assessment_MarianaPerezSerna.Seeders;
public class DoctorSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasData(

            new Doctor
            {
                Id = 1,
                Name = "mariana",
                Lastname = "perez serna",
                Email = "marianaperezserna@gmail.com",
                Password = "123654789",
                RoleId = 1,
                SpecialtyId = 1,
            },

            new Doctor
            {
                Id = 2,
                Name = "juan",
                Lastname = "gómez lópez",
                Email = "juangomez@gmail.com",
                Password = "123654789",
                RoleId = 1,
                SpecialtyId = 2,
            },

            new Doctor
            {
                Id = 3,
                Name = "ana",
                Lastname = "ramírez torres",
                Email = "anaramirez@gmail.com",
                Password = "123654789",
                RoleId = 1,
                SpecialtyId = 3,
            },

            new Doctor
            {
                Id = 4,
                Name = "luis",
                Lastname = "martínez rivera",
                Email = "luismartinez@gmail.com",
                Password = "123654789",
                RoleId = 1,
                SpecialtyId = 4,
            },

            new Doctor
            {
                Id = 5,
                Name = "carla",
                Lastname = "fernández pérez",
                Email = "carlafernandez@gmail.com",
                Password = "123654789",
                RoleId = 1,
                SpecialtyId = 5,
            },

            new Doctor
            {
                Id = 6,
                Name = "pedro",
                Lastname = "hernández núñez",
                Email = "pedrohernandez@gmail.com",
                Password = "123654789",
                RoleId = 1,
                SpecialtyId = 6,
            }
        );
    }

}
