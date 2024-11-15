using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment_MarianaPerezSerna.Models;

[Table("availability")]
public class Availability
{

    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("date")]
    public required DateOnly Date { get; set; }

    [Column("is_available")]
    public required bool IsAvailable { get; set; }

    [Column("hour_start")]
    public required TimeOnly HourStart { get; set; }

    [Column("hour_end")]
    public required TimeOnly HourEnd { get; set; }

    [Column("doctor_id")]
    public int DoctorId { get; set; }
    
    [ForeignKey("DoctorId")]
    public Doctor Doctor { get; set; }

}