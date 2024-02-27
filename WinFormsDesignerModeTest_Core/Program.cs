using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinFormsDesignerModeTest_Core
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());

            IHostBuilder hostBuilder = Host.CreateDefaultBuilder();
            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<Service>();
                services.AddSingleton<MainWindow>();
            });

            var host = hostBuilder.Build();

            //save DI instances provider to be accessed from UserControls (outside DI) in WinForms
            DIContainer.Services = host.Services;

            //The MainWindow instance is created during this call.
            var mainWindow = DIContainer.Get<MainWindow>();
            Application.Run(mainWindow);
        }
    }
}