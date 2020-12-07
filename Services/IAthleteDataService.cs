using AthleteScheduler.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerScheduler.Services
{
    public interface IAthleteDataService
    {
        Task<IEnumerable<Athlete>> GetAllAthletes();
        Task<Athlete> GetAthleteDetails(int athleteId);
        Task<Athlete> AddAthlete(Athlete athlete);
        Task UpdateAthlete(Athlete athlete);
        Task DeleteAthlete(int athleteId);
    }
}
