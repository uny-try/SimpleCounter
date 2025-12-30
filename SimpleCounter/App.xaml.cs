using Microsoft.Extensions.DependencyInjection;

namespace SimpleCounter;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        Window window = new Window(new AppShell());
        window.Height = 600;
        window.Width = 400;

        return window;
    }
}