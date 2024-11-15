
using Assessment_MarianaPerezSerna.Models;

namespace Assessment_MarianaPerezSerna.Repositories;
public interface IAppoitmentRepository
{

    Task<IEnumerable<Appointment>> GetAll();


    Task<Appointment> GetById(int id);

    Task<bool> CheckExistence(int id);

    Task Add(Appointment appointment);

    Task Update(Appointment appointment);
    
    Task Delete(Appointment appointment);


}
