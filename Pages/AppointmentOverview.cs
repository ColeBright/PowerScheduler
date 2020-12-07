using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AthleteScheduler.Data.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using PowerScheduler.Components;
using PowerScheduler.Services;
using Radzen;
using Radzen.Blazor;

namespace PowerScheduler.Pages
{
    public partial class AppointmentOverview
    {
        public IList<Athlete> Athletes = new List<Athlete>();
        public IList<Appointment> Appointments = new List<Appointment>();

        [Inject]
        public IAthleteDataService AthleteDataService { get; set; }
        [Inject]
        public IAppointmentDataService AppointmentDataService { get; set; }

        protected AddAthleteDialog AddAthleteDialog { get; set; }
        protected EditAthleteDialog EditAthleteDialog { get; set; }
        protected EditAppointment EditAppointmentDialog { get; set; }
        protected AddAppointment AddAppointmentDialog { get; set; }
        protected Report ReportDialog { get; set; } 
        RadzenChart barChart = new RadzenChart(); 

        public List<Athlete> makeBarGraphHappy = new List<Athlete>();
        ColorScheme colorScheme = ColorScheme.Palette;

        RadzenScheduler<EventAppt> scheduler = new RadzenScheduler<EventAppt>();
        public string SearchTerm { get; set; } = "   ";
        List<Athlete> FilteredAthletes => Athletes.Where(i => i.FullName.ToLower().Contains(SearchTerm.ToLower())).ToList();
        private int? _boundId = null;
        private int? boundAthId
        {
            get
            {
                return _boundId;
            }
            set
            {
                _boundId = value;
                foreach (Athlete ath in Athletes)
                {
                    if (_boundId == ath.Id)
                    {
                        currentAth = ath;
                        currentAthleteName = currentAth.FullName;
                        refreshBarChart();
                    }
                }
            }
        }
        public class EventAppt
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
            public string Text { get; set; }
            public int ApptId { get; set; }
        }

        public List<EventAppt> evnts = new List<EventAppt>();

       
        public Athlete currentAth = new Athlete();
        
        public string currentAthleteName = string.Empty;
        public int currentAptId { get; set; } = 1;
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
                foreach (Appointment appt in Athappts.Appointments)
                {
                    evnts.Add(new EventAppt
                    {
                        Start = appt.Start,
                        End = appt.End,
                        Text = Athappts.FullName,
                        ApptId = appt.Id
                    }); ;
                }
            }
        }
        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();
            currentAth.Appointments = new List<Appointment>();
            Athletes = (await AthleteDataService.GetAllAthletes()).ToList();
            Appointments = (await AppointmentDataService.GetAllAppointments()).ToList();
            fillEvents();
            await scheduler.Reload();
            currentAth = Athletes[0];
            makeBarGraphHappy.Add(currentAth);
            barChart.Reload();
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            fillEvents();
        }
        async Task OnAppointmentSelect(Radzen.SchedulerAppointmentSelectEventArgs<EventAppt> args)
        {
            var thing = args.Data.Text;
            foreach (Athlete ath in Athletes)
            {
                if (thing == ath.FullName)
                {
                    currentAth = ath;
                    currentAthleteName = currentAth.FullName;
                    currentAptId = args.Data.ApptId;
                }
            }
            refreshBarChart();
            
            //currentAthleteName = args.Data.Text;
            currentAptId = args.Data.ApptId;
            EditAppointmentDialog.ApptID = currentAptId;
            
            await EditAppointmentAsync();


        }

        protected void AddAthlete()
        {
            AddAthleteDialog.Show();
            scheduler.Reload();
        }
        protected async void EditAthlete()
        {
            await EditAthleteDialog.ShowAsync();
            refreshBarChart();
        }
        protected async Task AddAppointmentAsync()
        {
            await AddAppointmentDialog.ShowAsync();
        }
        protected async Task EditAppointmentAsync()
        {
            await EditAppointmentDialog.ShowAsync();
        }
        protected async Task GenerateReport()
        {
            await ReportDialog.ShowAsync();
        }
        protected async Task OnSlotSelectAsync()
        {
            await AddAppointmentAsync();
        }
        public async void AddAppointmentDialog_OnDialogClose()
        {
            scheduler.Dispose();
            Appointments = (await AppointmentDataService.GetAllAppointments()).ToList();
            evnts.Clear();
            fillEvents();
            await scheduler.Reload();
            StateHasChanged();
            EditAppointmentDialog.Close();
        }
        public async void AthleteDialog_OnDialogClose()
        {
            Athletes = (await AthleteDataService.GetAllAthletes()).ToList();
            evnts.Clear();
            fillEvents();
            await scheduler.Reload();
            currentAth = Athletes[0];
            refreshBarChart();
            
            StateHasChanged();
        }
        public async void Change_Athlete(ModifiedOption<Athlete> args)
        {
            currentAth = args.Value;
        }
        protected async Task athleteButtonClicked(Athlete args)
        {
            currentAth = args;
        }
        public void refreshBarChart()
        {
            makeBarGraphHappy.Clear();
            makeBarGraphHappy.Add(currentAth);
            barChart.Reload();
        }
        public void selectedAthlete(object args)
        {
            var thing = args.ToString();
            foreach (Athlete ath in Athletes)
            {
                if (thing == ath.FullName)
                {
                    currentAth = ath;
                    currentAthleteName = currentAth.FullName;
                }
            }
        }
    }
}
