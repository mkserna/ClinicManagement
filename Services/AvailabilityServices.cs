
using Assessment_MarianaPerezSerna.Data;
using Assessment_MarianaPerezSerna.Models;
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Services;
public class AvailabilityServices : IAvailabilityRepository
{
    private readonly ApplicationDbContext _context;

    public AvailabilityServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Availability> GetAvailabilityAsync(string availability)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAvailabilityAsync(int doctorId, Availability model)
    {
        throw new NotImplementedException();
    }
}
