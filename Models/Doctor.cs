
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Models;

[Table("doctors")]
public class Doctor
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("name")]
    public required string Name { get; set; }

    [Column("lastname")]
    public required string Lastname { get; set; }

    [Column("email")]
    public required string Email { get; set; }

    [Column("password")]
    public required string Password { get; set; }


    [Column("specialty_id")]
    public int SpecialtyId { get; set; }    


    [Column("role_id")]
    public int RoleId { get; set; }


    [ForeignKey("RoleId")]
    public Role Role { get; set; }

    [ForeignKey("SpecialtyId")]
    public Specialty Specialty { get; set; }

    internal static void Seed(ModelBuilder modelBuilder)
    {
        throw new NotImplementedException();
    }
}
