namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Counter counter1 = new Counter();

            counter.event1 += (sender, e) =>
            {
                Console.WriteLine("достигнут порог 10 вызовов у counter");
            };

            counter1.event1 += (sender, e) =>
            {
                Console.WriteLine("достигнут порог 10 вызовов у counter1");
            };

            for (int i = 0; i < 10; i++) 
            {
            counter.Increment();
            }
            for (int i = 0; i < 5; i++)
            {
                counter1.Increment();
            }

        }
    }
    public class Counter
    {
        public int count;
        public event EventHandler event1;
        public void Increment()
        {
            count = count + 1;
            if (count == 10)
            {
                OnThresholdReached();
            }
        }
        protected virtual void OnThresholdReached()
        {
            event1?.Invoke(this, EventArgs.Empty);
        }
    }
}