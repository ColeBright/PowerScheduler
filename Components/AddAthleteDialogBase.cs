using AthleteScheduler.Data.Entities;
using Microsoft.AspNetCore.Components;
using PowerScheduler.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerScheduler.Components
{
    public class AddAthleteDialogBase : ComponentBase
    {

        public bool ShowDialog { get; set; }
        public Athlete Athlete { get; set; } = new Athlete { FullName = "Person", Bench = 1, Squat = 2, Deadlift = 3, Appointments = null };
        [Inject]
        public IAthleteDataService AthleteDataService { get; set; }
        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }
        private void ResetDialog()
        {
            Athlete = new Athlete { FullName = "Person", Bench = 1, Squat = 2, Deadlift = 3, Appointments = null };
        }
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        protected async Task HandleValidSubmit()
        {
            await AthleteDataService.AddAthlete(Athlete);
            ShowDialog = false;
            //await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
