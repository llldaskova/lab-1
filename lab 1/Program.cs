using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] { 5, 3, 4 };
            Console.WriteLine(HW1.QueueTime(a, 1));
            a = new[] { 10, 2, 3, 3 };
            Console.WriteLine(HW1.QueueTime(a, 2));
            a = new[] { 10, 2, 3 };
            Console.WriteLine(HW1.QueueTime(a, 2));
        }
    }
}
