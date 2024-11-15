
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Appointments;

[ApiController]
[Tags("Appointments")]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
public class DeleteAppoitmentController : AppoitmentController
{
    private readonly IAppoitmentRepository _appoitmentRepository;

    public DeleteAppoitmentController(IAppoitmentRepository appoitmentRepository) : base(appoitmentRepository)
    {
        _appoitmentRepository = appoitmentRepository;
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "Delete a appoitment by ID", Description = "Deletes a appoitment by its unique ID.")]
    [SwaggerResponse(204, "Success: appoitment deleted")]
    [SwaggerResponse(404, "appoitment not found")]
    [SwaggerResponse(500, "Internal server error")]

    public async Task<ActionResult> Delete(int id)
    {
        var appointment = await _appoitmentRepository.GetById(id);
        if (appointment == null)
        {
            return NotFound();
        }

        await _appoitmentRepository.Delete(appointment);
        return NoContent();
    }
}
