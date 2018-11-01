using System.Collections.Generic;
using System.Linq;

namespace ModLab4.Models
{
    public class Queue
    {
        public IList<Task> QueueTasks { get; set; }

        public Queue()
        {
            QueueTasks = new List<Task>();
        }

        public bool IsBlock()
        {
            return QueueTasks.Count >= 2;
        }

        public bool IsQueueEmpty()
        {
            return QueueTasks.Count == 0;
        }

        public void UpdateTimeForTask()
        {
            QueueTasks.ToList().ForEach(t => t.CountInQ++);
        }

        public void AddTask(Task task)
        {
            QueueTasks.Add(task);
        }

        public Task RemoveTask()
        {
            var removedTask = QueueTasks.First();
            QueueTasks.RemoveAt(0);
            return removedTask;
        }

        public override string ToString()
        {
            return QueueTasks.Count.ToString();
        }
    }
}
