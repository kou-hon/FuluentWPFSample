using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace FuluentWPFSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost host = null!;
        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            host = Host.CreateDefaultBuilder(e.Args)
                .ConfigureServices(collection =>
                {
                    collection.AddHostedService<ApplicationHostService>();
                    collection.AddTransient<MainWindow>();
                })
                .Build();
            await host.StartAsync();
        }
    }
}
