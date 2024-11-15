
using Assessment_MarianaPerezSerna.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Seeders;
public class RoleSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(

            new Role
            {
                Id = 1,
                Name = "doctor"
            },

            new Role
            {
                Id = 2,
                Name = "patient"
            }
        );
    }
}