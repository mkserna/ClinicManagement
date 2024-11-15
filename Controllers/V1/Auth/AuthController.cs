using Assessment_MarianaPerezSerna.Models;
using Assessment_MarianaPerezSerna.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using Assessment_MarianaPerezSerna.Config;
using Assessment_MarianaPerezSerna.Data;
using Microsoft.AspNetCore.Identity.Data;

namespace Assessment_MarianaPerezSerna.Controllers.V1.Auth;

[ApiController]
[AllowAnonymous]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly JwtConfig _utilities;

    public AuthController(ApplicationDbContext context, JwtConfig utilities)
    {
        _context = context;
        _utilities = utilities;
    }

    [HttpPost("register")]
    [SwaggerOperation(Summary = "Register a new patient", Description = "Creates a new patient account.")]
    [SwaggerResponse(200, "User registered successfully")]
    [SwaggerResponse(400, "Bad request, including validation errors")]
    [SwaggerResponse(500, "Internal server error")]

    public async Task<IActionResult> Register(PatientDTO newPatient)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (_context.Patients.Any(u => u.Email == newPatient.Email))
        {
            return BadRequest("Email already exists");
        }

        var patient = new Patient
        {
            Name = newPatient.Name,
            Lastname = newPatient.Lastname,
            Email = newPatient.Email,
            Password = newPatient.Password,
            Phone = newPatient.Phone,
            Address = newPatient.Address,
            RoleId = 2
        };

        // Agregar la entidad al contexto
        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();
        return Ok("User registered successfully");
    }

    [HttpPost("login")]
    [SwaggerOperation(Summary = "Login patient", Description = "Authenticates a patient and generates a JWT token.")]
    [SwaggerResponse(200, "JWT token returned successfully")]
    [SwaggerResponse(401, "Invalid email or password")]
    [SwaggerResponse(400, "Bad request, including validation errors")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var patient = await _context.Patients.FirstOrDefaultAsync(u => u.Email == request.Email);
        if (patient == null)
        {
            return Unauthorized("Invalid email");
        }

        // Asegúrate de que la contraseña coincida con la almacenada en la base de datos.
        var passwordIsValid = patient.Password == _utilities.EncryptSHA256(request.Password);

        if (!passwordIsValid)
        {
            return Unauthorized("Invalid password");
        }

        var token = _utilities.GenerateJwtToken(patient);
        return Ok(new
        {
            message = "Please, save this token",
            jwt = token
        });
    }
}
