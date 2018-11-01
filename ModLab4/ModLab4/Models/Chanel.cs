namespace ModLab4.Models
{
    public class Chanel
    {
        public Task Task { get; set; }

        private double p;
        private MyRandom random;

        public Chanel(double p, MyRandom random)
        {
            this.p = p;
            this.random = random;
        }

        public bool IsComplate()
        {
            return random.GenerateNextDoube() < p;
        }

        public bool IsBlock()
        {
            return Task != null;
        }

        public void Clean()
        {
            Task = null;
        }

        public override string ToString()
        {
            return IsBlock() ? "1" : "0";
        }
    }
}
