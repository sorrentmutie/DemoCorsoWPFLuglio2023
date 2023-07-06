using DemoCorsoWPF.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Windows;

namespace DemoCorsoWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IConfigurationRoot configuration;

        public static IHost? AppHost { get; private set; }

        public App()
        {
               AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<SecondWindow>();
                    services.AddTransient<IDataAccess, MockDataAccess>();
                    services.AddLogging(configure => configure.AddConsole());
                }).Build();

            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json");
            configuration = configurationBuilder.Build();

        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();


            var startup = AppHost.Services.GetRequiredService<MainWindow>();
            startup.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            
            await AppHost!.StopAsync();
           
            base.OnExit(e);
        }

    }
}
