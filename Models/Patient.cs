
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment_MarianaPerezSerna.Models;

[Table("patients")]
public class Patient
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }   
    
    [Column("lastname")]
    public string Lastname { get; set; }
    
    [Column("email")]
    public string Email { get; set; }

    [Column("password")]
    public string Password { get; set; }
    
    [Column("phone")]
    public string Phone { get; set; }
    
    [Column("address")]
    public string Address { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; }

}
