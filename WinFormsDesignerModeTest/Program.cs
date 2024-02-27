using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Windows.Forms;

namespace WinFormsDITest
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IHostBuilder hostBuilder = Host.CreateDefaultBuilder();
            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainWindow>(); //register recipe to how the instance is created and that there is only 1 instance required and must then be reused (=> call default constructor)

                //Why is this required if UserControl does not use constructor injection?
                services.AddTransient(provider => new Lazy<MainWindow>(provider.GetRequiredService<MainWindow>));
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
