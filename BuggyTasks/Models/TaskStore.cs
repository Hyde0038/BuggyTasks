using System.Collections.ObjectModel;

namespace BuggyTasks.Models
{
    public static class TaskStore
    {
        public static ObservableCollection<TaskItem> Tasks { get; } = new ObservableCollection<TaskItem>
        {
            new TaskItem { Title = "Example 1" },
            new TaskItem { Title = "Example 2" }
        };
    }
}