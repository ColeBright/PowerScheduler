using AthleteScheduler.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PowerScheduler.Services
{
    public class AthleteDataService : IAthleteDataService
    {
        private readonly HttpClient _httpClient;

        public AthleteDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Athlete> AddAthlete(Athlete athlete)
        {
            var athleteJson = new StringContent(JsonSerializer.Serialize(athlete), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/athlete", athleteJson);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Athlete>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteAthlete(int athleteId)
        {
            await _httpClient.DeleteAsync($"api/athlete/{athleteId}");
        }

        public async Task<IEnumerable<Athlete>> GetAllAthletes()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Athlete>>
                (await _httpClient.GetStreamAsync($"api/athlete"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Athlete> GetAthleteDetails(int athleteId)
        {
            return await JsonSerializer.DeserializeAsync<Athlete>(await _httpClient.GetStreamAsync($"api/athlete/{athleteId}"), 
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateAthlete(Athlete athlete)
        {
            var athleteJson = new StringContent(JsonSerializer.Serialize(athlete), Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/athlete", athleteJson);
        }
    }
}
