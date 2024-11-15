using Assessment_MarianaPerezSerna.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Seeders;
public class SpecialtySeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Specialty>().HasData(

            new Specialty
            {
                Id = 1,
                Name = "neurology",
            },
                        
            new Specialty
            {
                Id = 2,
                Name = "cardiology",
            },

            new Specialty
            {
                Id = 3,
                Name = "dermatology",
            },
            
            new Specialty
            {
                Id = 4,
                Name = "pediatrics",
            },
            
            new Specialty
            {
                Id = 5,
                Name = "gynecology",
            },
            
            new Specialty
            {
                Id = 6,
                Name = "orthopedics",
            },
            
            new Specialty
            {
                Id = 7,
                Name = "psychology",
            },
            
            new Specialty
            {
                Id = 8,
                Name = "dentistry",
            },
            
            new Specialty
            {
                Id = 9,
                Name = "rheumatology",
            },
            
            new Specialty
            {
                Id = 10,
                Name = "oncology",
            }
        );
    }
}
