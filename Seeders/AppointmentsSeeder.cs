
using Assessment_MarianaPerezSerna.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_MarianaPerezSerna.Seeders;
public class AppointmentsSeeder
{

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>().HasData(

            new Appointment
            {
                Id = 1,
                Date = new DateOnly(2024, 12, 25),
                DoctorId = 1,
                PatientId = 1,
                StatusAppointmentId = 1,
            },
            new Appointment
            {
                Id = 2,
                Date = new DateOnly(2024, 12, 26),
                DoctorId = 2,
                PatientId = 2,
                StatusAppointmentId = 2,
            },
            new Appointment
            {
                Id = 3,
                Date = new DateOnly(2024, 12, 25),
                DoctorId = 3,
                PatientId = 3,
                StatusAppointmentId = 1,
            },
            new Appointment
            {
                Id = 4,
                Date = new DateOnly(2024, 12, 27),
                DoctorId = 4,
                PatientId = 4,
                StatusAppointmentId = 3,
            },
            new Appointment
            {
                Id = 5,
                Date = new DateOnly(2024, 12, 24),
                DoctorId = 5,
                PatientId = 3,
                StatusAppointmentId = 1,
            },
            new Appointment
            {
                Id = 6,
                Date = new DateOnly(2024, 12, 25),
                DoctorId = 1,
                PatientId = 2,
                StatusAppointmentId = 2,
            },
            new Appointment
            {
                Id = 7,
                Date = new DateOnly(2024, 12, 26),
                DoctorId = 2,
                PatientId = 3,
                StatusAppointmentId = 3,
            },
            new Appointment
            {
                Id = 8,
                Date = new DateOnly(2024, 12, 27),
                DoctorId = 3,
                PatientId = 1,
                StatusAppointmentId = 1,
            },
            new Appointment
            {
                Id = 9,
                Date = new DateOnly(2024, 12, 28),
                DoctorId = 4,
                PatientId = 9,
                StatusAppointmentId = 2,
            },
            new Appointment
            {
                Id = 10,
                Date = new DateOnly(2024, 12, 29),
                DoctorId = 5,
                PatientId = 5,
                StatusAppointmentId = 3,
            }

        );
    }

}
