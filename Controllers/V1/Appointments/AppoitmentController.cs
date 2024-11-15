using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Appointments
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AppoitmentController(IAppoitmentRepository appoitmentRepository) : ControllerBase
    {
        protected readonly IAppoitmentRepository _appoitmentRepository = appoitmentRepository;
    }
}