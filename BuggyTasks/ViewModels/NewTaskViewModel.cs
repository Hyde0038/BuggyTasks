using BuggyTasks.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BuggyTasks.ViewModels;

public partial class NewTaskViewModel : ObservableObject
{
    [ObservableProperty]
    string newTaskTitle;

    [RelayCommand]
    async Task AddTaskAsync()
    {
        if (string.IsNullOrWhiteSpace(NewTaskTitle))
            return;

        TaskStore.Tasks.Add(new TaskItem { Title = NewTaskTitle });
        NewTaskTitle = string.Empty;
        
        await Shell.Current.GoToAsync("..");
    }
}