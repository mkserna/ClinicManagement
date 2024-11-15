using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_MarianaPerezSerna.Models;
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Appointments;

[ApiController]
[Tags("Appointments")]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
public class UpdateAppoitmentController : AppoitmentController
{
    private readonly IAppoitmentRepository _appoitmentRepository;
    public UpdateAppoitmentController(IAppoitmentRepository appoitmentRepository) : base(appoitmentRepository)
    {
        _appoitmentRepository = appoitmentRepository;
    }

    [HttpPut("{id}")]
    [SwaggerOperation(Summary = "Update a appoitment", Description = "Updates the details of a appoitment by its unique ID.")]
    [SwaggerResponse(204, "No content: Update successful")]
    [SwaggerResponse(400, "Bad request: Invalid model state")]
    [SwaggerResponse(404, "appoitment not found")]
    [SwaggerResponse(500, "Internal server error")]

    public async Task<IActionResult> Update(int id, Appointment appoitment)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var appoitmentToUpdate = await _appoitmentRepository.CheckExistence(id);

        if (!appoitmentToUpdate)
        {
            return NotFound();
        }

        var appointment = await _appoitmentRepository.GetById(id);

        if (appointment == null)
        {
            return NotFound();
        }

        appoitment.PatientId = appoitment.PatientId;
        appoitment.DoctorId = appoitment.DoctorId;
        appoitment.StatusAppointmentId = appoitment.StatusAppointmentId;
        appoitment.Date = appoitment.Date;

        await _appoitmentRepository.Update(appoitment);
        return NoContent();
    }
}
