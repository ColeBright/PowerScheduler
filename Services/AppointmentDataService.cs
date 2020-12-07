using AthleteScheduler.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PowerScheduler.Services
{
    public class AppointmentDataService : IAppointmentDataService
    {
        private readonly HttpClient _httpClient;

        public AppointmentDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Appointment> AddAppointment(Appointment newAppointment)
        {
            var appointmentJson = new StringContent(JsonSerializer.Serialize(newAppointment), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/appointment", appointmentJson);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Appointment>(await response.Content.ReadAsStreamAsync());
            }
            return null; 
        }

        public async Task DeleteAppointment(int appointmentId)
        {
            await _httpClient.DeleteAsync($"api/appointment/{appointmentId}");
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointments()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Appointment>>
                (await _httpClient.GetStreamAsync($"api/appointment"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Appointment> GetAppointmentDetails(int apptID)
        {
            return await JsonSerializer.DeserializeAsync<Appointment>(await _httpClient.GetStreamAsync($"api/appointment/{apptID}"),
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateAppointment(Appointment appointment)
        {
            var appointmentJson = new StringContent(JsonSerializer.Serialize(appointment), Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/appointment", appointmentJson);
        }
    }
}
