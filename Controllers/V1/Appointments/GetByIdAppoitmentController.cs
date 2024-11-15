using Assessment_MarianaPerezSerna.Models;
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Appointments;

[ApiController]
[Tags("Appointments")]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]

public class GetByIdAppoitmentController : AppoitmentController
{
    private readonly IAppoitmentRepository _appoitmentRepository;
    public GetByIdAppoitmentController(IAppoitmentRepository appoitmentRepository) : base(appoitmentRepository)
    {
        _appoitmentRepository = appoitmentRepository;
    }

    [HttpGet("{id}")]
    [SwaggerOperation(Summary = "Get a appoitment by ID", Description = "Retrieves the details of a appoitment by its unique ID.")]
    [SwaggerResponse(200, "Success: appoitment details returned", typeof(Appointment))]
    [SwaggerResponse(404, "appoitment not found")]
    [SwaggerResponse(500, "Internal server error")]

    public async Task<ActionResult<Appointment>> GetById(int id)
    {
        var appoitment = await _appoitmentRepository.GetById(id);
        if (appoitment == null)
        {
            return NotFound();
        }
        return Ok(appoitment);
    }
}
