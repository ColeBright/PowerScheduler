using AthleteScheduler.Data.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using PowerScheduler.Services;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerScheduler.Components
{
    public class EditAppointmentBase : ComponentBase
    { 
        [Inject]
        public IAppointmentDataService AppointmentDataService { get; set; }
        public Appointment Appointment { get; set; } = new Appointment();
        [Inject]
        public IAthleteDataService AthleteDataService { get; set; }
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();
        protected string athID = string.Empty;

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        protected bool Saved;
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        [CascadingParameter]
        public string AthName { get; set; }
        [CascadingParameter(Name = "ApptID")]
        public int ApptID { get; set; }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        public bool ShowDialog { get; set; }
        public RadzenDatePicker<DateTime> aptstart { get; set; }
        public RadzenDatePicker<DateTime> aptend { get; set; }
        protected override void OnInitialized()
        {
            base.StateHasChanged();
            athID = Appointment.AthleteId.ToString();
        }

        //protected async override Task OnInitializedAsync()
        //{
        //    //Appointments = (await AppointmentDataService.GetAllAppointments()).ToList();
        //    //Saved = false;
        //    //if(ApptID == 0)
        //    //{
        //    //    Appointment = new Appointment { Start = DateTime.Now, End = DateTime.Now, AthleteId = 1};
        //    //}
        //    //else
        //    //{
        //    //    Appointment = await AppointmentDataService.GetAppointmentDetails(ApptID);
        //    //}
        //    athID = Appointment.AthleteId.ToString();
        //}
        protected async Task HandleValidSubmit()
        {
            Saved = false;

            foreach (Appointment appts in Appointments)
            {
                TimeZoneInfo currenttimezone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id);
                DateTime localtime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, currenttimezone);
                if (Appointment.Start < TimeZoneInfo.ConvertTimeFromUtc(appts.End, currenttimezone)
                    && Appointment.End > TimeZoneInfo.ConvertTimeFromUtc(appts.Start, currenttimezone))
                {
                    StatusClass = "alert-danger";
                    Message = "Can't have overlapping appointment times! Try another time, please.";
                    Saved = false;
                    return;
                }
            }
            if (ApptID == 0)
            {
                var addedAppointment = await AppointmentDataService.AddAppointment(Appointment);
                if(addedAppointment != null)
                {
                    StatusClass = "alert-success";
                    Message = "New appointment added.";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went amiss. Try again, please.";
                    Saved = false;
                }

            }
            else
            {
                Appointment.Id = ApptID;
                await AppointmentDataService.UpdateAppointment(Appointment);
                StatusClass = "alert-success";
                Message = "Appointment updated.";
                Saved = true;
            }
            await CloseEventCallback.InvokeAsync(true);
            Close();

        }
        public async Task DeleteAppointmentAsync()
        {
            await AppointmentDataService.DeleteAppointment(Appointment.Id);
            Saved = true;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
        public async Task ShowAsync()
        {
            if (ApptID == 0)
            {
                Appointment = new Appointment { Start = DateTime.Now, End = DateTime.Now, AthleteId = 1 };
            }
            else
            {
                Appointment = await AppointmentDataService.GetAppointmentDetails(ApptID);
            }
            athID = Appointment.AthleteId.ToString();
            ShowDialog = true;
            //athID = Appointment.AthleteId.ToString();
            //Appointment = await AppointmentDataService.GetAppointmentDetails(ApptID);
            //Task.Delay(1000);
            Saved = false;

            
            

        }
        public async Task Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
    }

}
