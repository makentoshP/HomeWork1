using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try
            {
                ex146();
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number!!!");
            }
        }

        static void ex143()
        {
            Console.WriteLine("Ввід масиву");
            int[] a = new int[5];
            int count = 0;

            for (int i = 0; i <= 4; ++i)
            {
                Console.Write($"a[{i}] ->");
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] != 0)
                    count++;
            }
            Console.WriteLine($"В масиві {count} ненульових елемента");
        }

        static void ex144()
        {
            
            Console.WriteLine("Vvedit chisla");
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int min = int.Parse(a[0]);

            for (int i = 1; i <= 4; ++i)
            {
                min = int.Parse(a[i]) < min ? int.Parse(a[i]) : min;
            }

            Console.WriteLine("Min elem: " + min);
        }

        static void ex146()
        {
            Console.WriteLine("Vvedit chisla");
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            double sum = 0.0, notZero = 0.0;
            for (int i = 0; i <= 9; ++i)
            {
                sum += int.Parse(a[i]);
                notZero += int.Parse(a[i]) != 0 ? 1 : 0;
            }
            double average = sum / notZero;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("NonZero elements: " + notZero);
            Console.WriteLine("Average: " + Math.Round(average, 2));
        }
    }
}
