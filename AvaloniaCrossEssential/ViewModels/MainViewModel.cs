
using Microsoft.Maui.ApplicationModel;
using ReactiveUI;
using System.Reactive;

namespace AvaloniaCrossEssential.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    public ReactiveCommand<Unit, Unit> TestCommand { get; } = ReactiveCommand.CreateFromTask(async () =>
    {
        // Simulate a long-running task
        await Browser.OpenAsync("https://www.google.com");
    });
}
