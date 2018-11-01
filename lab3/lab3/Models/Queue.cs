using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace lab3.Models
{
    public class Queue
    {
        public IList<Task> QueueTasks { get; set; }

        public bool IsBlock => QueueTasks.Count >= 2;

        public Queue()
        {
            QueueTasks = new List<Task>();
        }

        public bool IsQueueEmpty()
        {
            return QueueTasks.Count == 0;
        }

        public void UpdateTimeForTask()
        {
            QueueTasks.ToList().ForEach(t => t.CountInQ++);
        }

        public bool AddTask(Task task)
        {
            if (IsBlock) return false;

            QueueTasks.Add(task);
            return true;
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
