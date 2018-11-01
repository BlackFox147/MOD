using System.Collections.Generic;
using lab3.Models;

namespace lab3
{
    public class QueuingSystem
    {
        private readonly Chanel p;
        private readonly Chanel p1;
        private readonly Chanel p2;
        private readonly Queue queue;
        private readonly IList<Task> outputTasks;
        private int countOfTasks;

        public IDictionary<string, double> CountOfState { get; private set; }

        public QueuingSystem(double p, double p1, double p2)
        {
            var myRandom = new MyRandom();

            this.p = new Chanel(p, myRandom);
            this.p1 = new Chanel(p1, myRandom);
            this.p2 = new Chanel(p2, myRandom);
            queue = new Queue();
            
            outputTasks = new List<Task>();
            CountOfState = new Dictionary<string, double>();
            countOfTasks = 0;
        }

        public void GenerateNextState()
        {
            UpdateStatus();

            if (p2.IsBlock())
            {
                if (p2.IsComplate())
                {
                    p2.Task.IsExit = true;
                    outputTasks.Add(p2.Task);
                    p2.Clean();
                }
            }

            if (p1.IsBlock())
            {
                if (p1.IsComplate())
                {
                    if (p2.IsBlock())
                    {
                        outputTasks.Add(p1.Task);
                    }
                    else
                    {
                        p2.Task = p1.Task;
                    }
                    p1.Clean();
                }
            }

            if (!queue.IsQueueEmpty())
            {
                if (!p1.IsBlock())
                {
                    p1.Task = queue.RemoveTask();
                }
            }

            if (p.IsComplate())
            {
                var newTask = new Task(++countOfTasks);
                if (!p1.IsBlock())
                {
                    p1.Task = newTask;
                }
                else
                {
                    if(!queue.IsBlock())
                    {
                        queue.AddTask(newTask);
                    }
                    else
                    {
                        outputTasks.Add(newTask);
                    }
                }
            }

            queue.UpdateTimeForTask();
            
        }

        private void UpdateStatus()
        {
            string newState = queue.ToString() + p1 + p2;

            if (!CountOfState.ContainsKey(newState))
            {
                CountOfState.Add(newState, 0);
                CountOfState[newState]++;
            }

            CountOfState[newState]++;
        }
    }
}
