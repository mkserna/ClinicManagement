
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Availability;

[ApiController]
[Route("api/[controller]")]
public class AvailabilityDoctorController(IAvailabilityRepository availabilityRepository) : ControllerBase
{
        protected readonly IAvailabilityRepository _availabilityRepository = availabilityRepository;

}
