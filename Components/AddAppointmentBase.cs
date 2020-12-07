using AthleteScheduler.Data.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PowerScheduler.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerScheduler.Components
{
    public class AddAppointmentBase : ComponentBase
    {
        public IJSRuntime JSRuntime;
        public Athlete Athlete { get; set; } = new Athlete();
        public bool ShowDialog { get; set; }
        public Appointment Appointment { get; set; } = new Appointment { Start = DateTime.Now, End = DateTime.Now.AddMinutes(30) };
        [Inject]
        public IAppointmentDataService AppointmentDataService { get; set; }
        [Inject]
        public IAthleteDataService AthleteDataService { get; set; }
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();
        public List<Appointment> Appointments { get; set; }
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        public async Task ShowAsync()
        {
            Athletes = (await AthleteDataService.GetAllAthletes()).ToList();
            Appointments = (await AppointmentDataService.GetAllAppointments()).ToList();
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();

        }
        private void ResetDialog()
        {
            Appointment = new Appointment { Start = DateTime.Now, End = DateTime.Now.AddMinutes(30) };
        }
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        string message = "Cannot save overlapping appointments!";

        public async Task ShowAlert()
        {
            await JSRuntime.InvokeVoidAsync("ShowAlert", message);
        }
        protected async Task HandleSubmit()
        {
            foreach (Appointment appts in Appointments)
            {
                TimeZoneInfo currenttimezone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id);
                DateTime localtime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, currenttimezone);
                if (Appointment.Start < TimeZoneInfo.ConvertTimeFromUtc(appts.End, currenttimezone) 
                    && Appointment.End > TimeZoneInfo.ConvertTimeFromUtc(appts.Start, currenttimezone))
                {
                    StatusClass = "alert-danger";
                    Message = "Can't have overlapping appointment times! Try another time, please.";
                    return;
                }
            }
            await AppointmentDataService.AddAppointment(Appointment);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
