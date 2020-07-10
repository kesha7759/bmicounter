using System;

namespace BMIcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter newCounter = new Counter(60, 165);
            double score = newCounter.Score();
            Console.WriteLine(score);
            Console.ReadLine();
        }
    }
}
