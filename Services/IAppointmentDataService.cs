using AthleteScheduler.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerScheduler.Services
{
    public interface IAppointmentDataService
    {
        Task<IEnumerable<Appointment>> GetAllAppointments();
        Task<Appointment> GetAppointmentDetails(int appointmentId);
        Task<Appointment> AddAppointment(Appointment newAppointment);
        Task UpdateAppointment(Appointment appointment);
        Task DeleteAppointment(int appointmentId);
    }
}
