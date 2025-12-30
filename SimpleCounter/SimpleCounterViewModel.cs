using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SimpleCounter;

public partial class SimpleCounterViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DecrementCountCommand))]
    private int count;

    [RelayCommand]
    public void IncrementCount()
    {
        Count++;
    }

    [RelayCommand(CanExecute = nameof(CanDecrementCount))]
    public void DecrementCount()
    {
        Count--;
    }

    private bool CanDecrementCount()
    {
        return Count > 0;
    }
}
