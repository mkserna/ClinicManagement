
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Assessment_MarianaPerezSerna.Models;
using Assessment_MarianaPerezSerna.Repositories;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Appointments;

[ApiController]
[Tags("Appointments")]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
public class CreateAppoitmentController : AppoitmentController
{

    private readonly IAppoitmentRepository _appoitmentRepository;

    public CreateAppoitmentController(IAppoitmentRepository appoitmentRepository) : base(appoitmentRepository)
    {
        _appoitmentRepository = appoitmentRepository;
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create a new appo", Description = "Creates a new appointment.")]
    [SwaggerResponse(200, "Success:  created", typeof(Appointment))]
    [SwaggerResponse(400, "Invalid data provided")]
    [SwaggerResponse(500, "Internal server error")]

    public async Task<ActionResult<Appointment>> Create(Appointment appointment)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newAppointment =  new Appointment
        {
            Id = appointment.Id,
            PatientId = appointment.PatientId,
            DoctorId = appointment.DoctorId,
            Date = appointment.Date,
            StatusAppointmentId = appointment.StatusAppointmentId,

        };

        await _appoitmentRepository.Add(newAppointment);
        return Ok(newAppointment);
    }

}
