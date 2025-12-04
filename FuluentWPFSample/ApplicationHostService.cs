using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace FuluentWPFSample
{
    public class ApplicationHostService(IServiceProvider _serviceProvider) : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            _MainWindow.Show();
            await Task.CompletedTask;
        }

        private Window? _MainWindow;

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}
