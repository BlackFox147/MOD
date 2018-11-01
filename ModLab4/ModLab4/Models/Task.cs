namespace ModLab4.Models
{
    public class Task
    {
        public Task(int id)
        {
            Id = id;
            CountInQ = 0;
            IsExit = false;
        }

        public int Id { get; }

        public int CountInQ { get; set; }

        public bool IsExit{ get; set; }
    }
}
