

using Assessment_MarianaPerezSerna.Models;

namespace Assessment_MarianaPerezSerna.Repositories;

public interface IAvailabilityRepository
{

    Task<Availability> GetAvailabilityAsync(string availability);
    Task<bool> UpdateAvailabilityAsync(int doctorId, Availability model);

}
