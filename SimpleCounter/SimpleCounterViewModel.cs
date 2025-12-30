using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SimpleCounter;

public partial class SimpleCounterViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsHighCount))]
    [NotifyCanExecuteChangedFor(nameof(DecrementCountCommand))]
    public int count;

    public bool IsHighCount => Count >= 10;

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
