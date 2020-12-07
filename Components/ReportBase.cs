using AthleteScheduler.Data.Entities;
using Microsoft.AspNetCore.Components;
using PowerScheduler.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerScheduler.Components
{
    public class ReportBase : ComponentBase
    {
        [Inject]
        public IAppointmentDataService AppointmentDataService { get; set; }
        [Inject]
        public IAthleteDataService AthleteDataService { get; set; }
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public bool ShowDialog { get; set; } = false;
        protected async override Task OnInitializedAsync()
        {
            Athletes = (await AthleteDataService.GetAllAthletes()).ToList();
            Appointments = (await AppointmentDataService.GetAllAppointments()).ToList();
            fillEvents(); 
        }

            public async Task ShowAsync()
        {
            Athletes = (await AthleteDataService.GetAllAthletes()).ToList();
            Appointments = (await AppointmentDataService.GetAllAppointments()).ToList();
            fillEvents();
            ShowDialog = true;
            StateHasChanged();
            
        }
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        public void fillEvents()
        {
            foreach (Athlete Athappts in Athletes)
            {
                Athappts.Appointments = new List<Appointment>();
                foreach (Appointment appts in Appointments)
                {
                    if (Athappts.Id == appts.AthleteId)
                    {
                        Athappts.Appointments.Add(appts);
                    }
                }

            }
        }
    }
}
