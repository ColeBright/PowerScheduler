using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Radzen;
using PowerScheduler.Services;

namespace PowerScheduler
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            //builder.Services.AddOidcAuthentication(options =>
            //{
            //    builder.Configuration.Bind("OidcConfiguration", options.ProviderOptions);
            //});
            //https://localhost:44320/

            builder.Services.AddHttpClient<IAthleteDataService, AthleteDataService>(client => client.BaseAddress = new Uri("https://powerschedulerapi20201205200548.azurewebsites.net/"));
            builder.Services.AddHttpClient<IAppointmentDataService, AppointmentDataService>(client => client.BaseAddress = new Uri("https://powerschedulerapi20201205200548.azurewebsites.net/"));
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<TooltipService>();
            builder.Services.AddScoped<ContextMenuService>();

            await builder.Build().RunAsync();
        }
    }
}
