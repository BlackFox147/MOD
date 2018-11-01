using System;
using System.Collections.Generic;
using System.Text;
using lab3.Models;

namespace lab3
{
    class QueuingSystem
    {
        //private readonly Random _rand, _rand1, _rand2;
        //private readonly double _p, _p1, _p2;

        //public byte J { get; private set; }    // Состояние очереди  {0, 1}
        //public byte T1 { get; private set; }   // Состояние канала 1 {0, 1}
        //public byte T2 { get; private set; }   // Состояние канала 2 {0, 1}

        //public int DenialCounter { get; private set; }  // Счётчик отказов
        //public int Counter1 { get; private set; }       // Счётчик занятости канала 1
        //public int Counter2 { get; private set; }       // Счётчик занятости канала 2

        private readonly Chanel p;
        private readonly Chanel p1;
        private readonly Chanel p2;
        private readonly Queue queue;
        private IList<Task> outputTasks;
        private int CountOfTasks;

        private MyRandom myRandom;

        public IDictionary<string, double> CountOfState { get; set; }

        public QueuingSystem(double p, double p1, double p2)
        {
            myRandom = new MyRandom();

            this.p = new Chanel(p, myRandom);
            this.p1 = new Chanel(p1, myRandom);
            this.p2 = new Chanel(p2, myRandom);
            queue = new Queue();
            
            outputTasks = new List<Task>();
            CountOfState = new Dictionary<string, double>();
            CountOfTasks = 0;
            //J = 0;
            //T1 = 0;
            //T2 = 0;
            //DenialCounter = 0;
            //Counter1 = 0;
            //Counter2 = 0;
            //_rand = new Random();
            //_rand1 = new Random(101);
            //_rand2= new Random(4242440);
            //_p = p;     // Вероятность не выдачи заявки
            //_p1 = p1;   // Вероятность не обслуживания заявки каналом 1
            //_p2 = p2;   // Вероятность не обслуживания заявки каналом 2
        }

        public void GenerateNextState()
        {
            UpdateStatus();

            if (p2.IsBlock())
            {
                if (p2.IsComplate() && p1.IsBlock())
                {
                    p1.Task.IsExit = true;
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
                var newTask = new Task(++CountOfTasks);
                if (!p1.IsBlock())
                {
                    p1.Task = newTask;
                }
                else
                {
                    if(!queue.IsBlock)
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
