using System;
namespace inl_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minDurationSeconds = 2 * 60 + 45;
            const int maxDurationSeconds = 4 * 60 + 20;

            Console.Write("ange låtens längd (minuter): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("ange låtens längd (sekunder): ");
            int seconds = int.Parse(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out minutes) &&
                int.TryParse(Console.ReadLine(), out seconds) &&
                seconds >= 0 && seconds <60)
            {
                
                int totalDurationSeconds = minutes * 60 + seconds;

                if (totalDurationSeconds >= minDurationSeconds && totalDurationSeconds <= maxDurationSeconds)
                {
                    Console.WriteLine("låter få spelas på radiostationen.");
                }
                else
                {
                    Console.WriteLine("låten får inte spelas på radiostationen.");
                }

            }
        }
    }
}

