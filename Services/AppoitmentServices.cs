
using Assessment_MarianaPerezSerna.Data;
using Assessment_MarianaPerezSerna.Models;
using Assessment_MarianaPerezSerna.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Services;
public class AppoitmentServices : IAppoitmentRepository
{

    private readonly ApplicationDbContext _context;

    public AppoitmentServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Add(Appointment appointment)
    {
        if (appointment == null)
        {
            throw new ArgumentNullException(nameof(appointment), "Appointment cannot be null and void");
        }

        try
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error adding appointment.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("An unexpected error occurred while adding the appointment.", ex);
        }
    }

    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Appointments.AnyAsync(a => a.Id == id);
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error checking existence of appointment.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("An unexpected error occurred while checking the existence of the appointment.", ex);
        }
    }

    public async Task Delete(Appointment appointment)
    {
        var appointmentToDelete = await _context.Appointments.FindAsync(appointment.Id);
        if (appointmentToDelete == null)
        {
            throw new Exception("Appointment not found.");
        }

        _context.Appointments.Remove(appointmentToDelete);
        await _context.SaveChangesAsync();
    }
    
    public async Task<IEnumerable<Appointment>> GetAll()
    {
        return await _context.Appointments.ToListAsync();
    }

    public async Task<Appointment> GetById(int id)
    {
        return await _context.Appointments.FindAsync(id);
    }

    public async Task Update(Appointment appointment)
    {
        if(appointment == null)
        {
            throw new ArgumentNullException(nameof(appointment), "Appointment cannot be null and void");
        }
        
        try
        {
            _context.Entry(appointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException dbEx)
        {
            throw new Exception("Error updating appointment.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("An unexpected error occurred while updating the appointment.", ex);
        }
    }
}
