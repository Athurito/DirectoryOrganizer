using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Organizer.Application.Extensions;
using Organizer.Infrastructure.Extensions;
using Organizer.Wpf.Extensions;

namespace Organizer.Wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : System.Windows.Application
{
    public App()
    {
        RegisterServices();
    }
    
    protected override void OnStartup(StartupEventArgs e)
    {
        
    }

    private static void RegisterServices()
    {
        var services = new ServiceCollection();
        
        services.AddInfrastructure();
        services.AddApplication();
        services.AddWpf();
        
        services.BuildServiceProvider();
    }
}