using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using BuggyTasks.Models;

namespace BuggyTasks.ViewModels;

public partial class TaskListViewModel : ObservableObject
{
    public ObservableCollection<TaskItem> Tasks => TaskStore.Tasks;
}