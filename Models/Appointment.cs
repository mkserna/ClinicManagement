
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment_MarianaPerezSerna.Models;

[Table("appointments")]
public class Appointment
{

    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("date")]
    public required DateOnly Date { get; set; }

    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [Column("patient_id")]
    public int PatientId { get; set; }

    [Column("status_appointment_id")]
    public int StatusAppointmentId { get; set; }



    [ForeignKey("DoctorId")]
    public Doctor Doctor { get; set; }  

    [ForeignKey("PatientId")]
    public Patient Patient { get; set; }

    [ForeignKey("StatusAppointmentId")]
    public StatusAppointment StatusAppointment { get; set; }
}
