using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try
            {
                ex115();
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number!!!");
            }
        }

        static void ex105()
        {
            Console.WriteLine("Таблиця квадратів");
            Console.WriteLine("-----------------");
            Console.WriteLine("Число\t Квадрат");
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine(i + "\t  " + i*i);
            }
            Console.WriteLine("-----------------");
        }

        static void ex106()
        {
            Console.WriteLine("Таблиця квадратів непарних чисел");
            Console.WriteLine("-----------------");
            Console.WriteLine("Число\t Квадрат");
            for (int i = 1; i <= 10; ++i)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i + "\t  " + i * i);
            }
            Console.WriteLine("-----------------");
        }

        static void ex107()
        {
            Console.WriteLine("Сума додатніх чисел");
            Console.Write("Введіть кількість зсумованих чисел -> ");
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= count; ++i)
            {
                sum += i;
            }

            Console.WriteLine($"Сума перших {count} чисел рівна {sum}");
        }

        static void ex108()
        {
            Console.WriteLine("Сума додатніх парних чисел");
            Console.Write("Введіть кількість зсумованих чисел -> ");
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= count; ++i)
            {
                
                sum += (i*2);
            }

            Console.WriteLine($"Сума перших {count} чисел рівна {sum}");
        }

        static void ex109()
        {
            Console.WriteLine("Сума ряду чисел чисел 1+3+5+7+9...");
            Console.Write("Введіть кількість зсумованих чисел -> ");
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= count; ++i)
            {

                sum += (1 + i * 2);
            }

            Console.WriteLine($"Сума перших {count} чисел рівна {sum}");
        }

        static void ex110()
        {
            Console.WriteLine("Сума ряду чисел чисел 1 + 1/2 + 1/3 + 1/4...");
            Console.Write("Введіть кількість зсумованих чисел -> ");
            int count = int.Parse(Console.ReadLine());
            double sum = 0.0;

            for (double i = 1; i <= count; ++i)
            {

                sum += (1 / i);
            }

            Console.WriteLine($"Сума перших {count} чисел рівна {Math.Round(sum, 4)}");
        }

        static void ex111()
        {
            Console.WriteLine("Таблиця степенів двійки");
            Console.WriteLine("-----------------");
            Console.WriteLine("Число\t Квадрат");
            for (int i = 0; i <= 10; ++i)
            {
                Console.WriteLine(i + "\t  " + Math.Pow(2, i));
            }
            Console.WriteLine("-----------------");
        }

        static void ex112()
        {
            Console.WriteLine("Факторіал");
            Console.Write("Введіть число факторіал якого будемо рахувати -> ");
            int count = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 1; i <= count; ++i)
            {

                sum *= i;
            }

            Console.WriteLine($"Факторіал числа {count} дорівнює {sum}");
        }

        static void ex113()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("    x    |    y    ");
            Console.WriteLine("-----------------");

            double x = -2.0;
            double y;

            while (x <= 2.0)
            {
                y = -2.4 * Math.Pow(x, 2) + 5 * x - 3;
                Console.Write($"{Math.Round(x, 2)}\t   ");
                Console.WriteLine($"{Math.Round(y, 2)}");
                x += 0.5;
            }
        }

        static void ex114()
        {
            Console.WriteLine("Середнє арефметичне дробових");
            Console.WriteLine("Вводьте числа через Enter -> ");
            double temp;
            double sum = 0.0;

            for (double i = 1; i <= 5; ++i)
            {
                Console.Write("-->");
                temp = double.Parse(Console.ReadLine());
                sum += temp;
            }

            Console.WriteLine($"Середнє арифметичне дорівнює {sum/5}");
        }

        static void ex115()
        {
            Console.WriteLine("Середнє арефметичне дробових");
            Console.Write("Введіть кількість чисел -> ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Вводьте числа через Enter -> ");

            double temp;
            double sum = 0.0;

            for (int i = 1; i <= count; ++i)
            {
                Console.Write("-->");
                temp = double.Parse(Console.ReadLine());
                sum += temp;
            }

            Console.WriteLine($"Середнє арифметичне дорівнює {sum / count}");
        }
    }
}
