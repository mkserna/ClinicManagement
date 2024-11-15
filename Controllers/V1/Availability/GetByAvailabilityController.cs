
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Assessment_MarianaPerezSerna.Models;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Availability;

[ApiController]
[Tags("Appointments")]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
public class GetByAvailabilityController : AvailabilityDoctorController
{
    private readonly IAvailabilityRepository _availabilityRepository;
    public GetByAvailabilityController(IAvailabilityRepository availabilityRepository) : base(availabilityRepository)
    {
        _availabilityRepository = availabilityRepository;
    }

    [HttpGet("identification/{identificationNumber}")]
    [SwaggerOperation(Summary = "Get a doctor by availability", Description = "Retrieves the details of a doctor by the customer's identification number.")]
    [SwaggerResponse(200, "Success: doctor details returned", typeof(Models.Availability))]
    [SwaggerResponse(404, "doctor not found")]
    [SwaggerResponse(500, "Internal server error")]

    public async Task<ActionResult<Models.Availability>> GetByAvailability(string availability)
    {
        var doctor = await _availabilityRepository.GetAvailabilityAsync(availability);
        if (doctor == null)
        {
            return NotFound();
        }
        return Ok(doctor);
    }
}
