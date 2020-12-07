using AthleteScheduler.Data.Entities;
using Microsoft.AspNetCore.Components;
using PowerScheduler.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerScheduler.Components
{
    public class EditAthleteBase : ComponentBase
    {
        public bool ShowDialog { get; set; }
        public Athlete Athlete { get; set; } = new Athlete();
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();
        [Inject]
        public IAthleteDataService AthleteDataService { get; set; }
        [CascadingParameter(Name = "AthID")]
        public int athID { get; set; }
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }
        public async Task ShowAsync()
        {
            ShowDialog = true;
            if(athID == 0)
            {
                Athlete = new Athlete { FullName = "Person", Bench = 1, Squat = 2, Deadlift = 3, Appointments = null };
            }
            else {
                Athlete = await AthleteDataService.GetAthleteDetails(athID);

            }

            StateHasChanged();
        }
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        protected async Task HandleValidSubmit()
        {
            await AthleteDataService.UpdateAthlete(Athlete);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
         
        }
        public async Task DeleteAthleteAsync()
        {
            await AthleteDataService.DeleteAthlete(Athlete.Id);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            
        }
    }
}
