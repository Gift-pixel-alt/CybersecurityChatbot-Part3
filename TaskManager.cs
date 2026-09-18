using System.Collections.Generic;
using System.Linq;

namespace CybersecurityChatbot_Part2
{
    public class TaskManager
    {
        public List<SecurityTask> Tasks { get; set; } = new List<SecurityTask>();

        public void AddTask(string description)
        {
            Tasks.Add(new SecurityTask
            {
                Description = description,
                IsCompleted = false
            });
        }

        public void CompleteTask(int index)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                Tasks[index].IsCompleted = true;
            }
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                Tasks.RemoveAt(index);
            }
        }

        public int GetCompletedCount()
        {
            return Tasks.Count(task => task.IsCompleted);
        }
    }
}