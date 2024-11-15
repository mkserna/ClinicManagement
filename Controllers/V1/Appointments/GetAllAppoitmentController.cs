using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_MarianaPerezSerna.Models;
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Appointments;

[ApiController]
[Tags("Appointments")]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Authorize(Policy = "DoctorPolicy")]
public class GetAllAppoitmentController : AppoitmentController
{
    private readonly IAppoitmentRepository _appoitmentRepository;

    public GetAllAppoitmentController(IAppoitmentRepository appoitmentRepository) : base(appoitmentRepository)
    {
        _appoitmentRepository = appoitmentRepository;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get all appoitment", Description = "Retrieves a list of all appoitment in the system.")]
    [SwaggerResponse(200, "Success: List of appoitment returned", typeof(IEnumerable<Appointment>))]
    [SwaggerResponse(404, "No appoitment found")]
    [SwaggerResponse(500, "Internal server error")]

    public async Task<ActionResult<IEnumerable<Appointment>>> GetAll()
    {
        var appoitments = await _appoitmentRepository.GetAll();
        if (appoitments == null || appoitments.Count() == 0)
        {
            return NotFound();
        }
        return Ok(appoitments);
    }
}
