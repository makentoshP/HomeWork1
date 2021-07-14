using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ex83_84();
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number!!!");
            }
           
        }

        static void ex77()
        {
            Console.WriteLine("Calculation of division");
            Console.WriteLine("Enter number and divisor");

            string s = Console.ReadLine();
            string[] values = s.Split(' ');
            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);

            if (b == 0)
            {
                Console.WriteLine("Error, divisor cant be zero");
            }
            else
            {
                Console.WriteLine("Your result is: " + a / b);
            }
        }

        static void ex78()
        {
            Console.WriteLine("Calculation of circle area");
            Console.WriteLine("Enter your starting data");

            Console.Write("Radius of the circle in cm -> ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Radius of the hole in cm -> ");
            double b = double.Parse(Console.ReadLine());

            if (a <= b)
            {
                Console.WriteLine("Error, such circle does not exist");
            }
            else
            {
                Console.WriteLine("S = " + Math.Round((Math.PI*(Math.Pow(a, 2) - Math.Pow(b, 2))), 2));
            }
        }

        static void ex79()
        {
            Console.WriteLine("Minutes with seconds in seconds");
            Console.Write("Enter yor time in format 3(min).30(sec) -> ");

            string s = Console.ReadLine();
            string[] values = s.Split('.');
            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);

            if (b > 60)
                Console.WriteLine("Error, max value for seconds is 60");
            else
                Console.WriteLine("Your result is: " + (a * 60 + b) + "sec");
        }

        static void ex80()
        {
            Console.Write("Enter year -> ");
            int a = int.Parse(Console.ReadLine());

            if ((a % 4 == 0) && a != 1700 && a != 1800 && a != 1900)
            {
                Console.WriteLine("Your year is bissextile");
            }
            else
            {
                Console.WriteLine("Your year is not bissextile");
            }
        }

        static void ex81()
        {
            Console.WriteLine("Calculate resistance");
            Console.WriteLine("Enter your data:");

            Console.Write("Firs resistor value -> ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Second resistor value -> ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Choose your connection type 1 - Consistent  2 - Parallel: ");
            char type = char.Parse(Console.ReadLine());

            switch (type)
            {
                case '1':
                    Console.WriteLine("Your resistance: " + (a + b));
                    break;
                case '2':
                    Console.WriteLine("Your resistance: " + ((a * b)/(a + b)));
                    break;
                default:
                    Console.WriteLine("Thre is no such type");
                    break;
            }
        }

        static void ex82()
        {
            ///********************************
            /// ax^2 + bx + c = 0
            /// D = sqrt(b^2 - 4ac)
            /// x = (-b +- sqrt(b^2 - 4ac))/2a
            ///********************************
            Console.WriteLine("Calculate equation ax^2 + bx + c = 0");
            Console.WriteLine("Enter parameters a, b, c:");

            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            int a = int.Parse(values[0]);
            Console.WriteLine(a);
            int b = int.Parse(values[1]);
            Console.WriteLine(b);
            int c = int.Parse(values[2]);
            Console.WriteLine(c);

            int D = ((int)Math.Pow(b, 2) - (4 * a * c));
            Console.WriteLine(D);
            if (D < 0)
                Console.WriteLine("Variables does not exist");
            else if (b == 0)
            {
                Console.WriteLine("Your equation have just one variable:");
                Console.WriteLine("x = " + Math.Sqrt(c / a));
            }
            else
            {
                Console.WriteLine("Your variables:");
                Console.WriteLine("x1 = " + ((-b + Math.Sqrt(D)) / (2 * a)));
                Console.WriteLine("x2 = " + ((-b - Math.Sqrt(D)) / (2 * a)));
            }
        }

        static void ex83_84()
        {
            Console.WriteLine("Calculate price");
            Console.Write("Enter your sum: ");

            int sum = int.Parse(Console.ReadLine());

            if (sum > 500 && sum <= 1000)
            {
                Console.WriteLine("You have discount 3%");
                Console.WriteLine("Your final sum with discount: " + sum * 0.97 + " UAH");
            }
            else if (sum > 1000)
            {
                Console.WriteLine("You have discount 5%");
                Console.WriteLine("Your final sum with discount: " + sum * 0.95 + " UAH");
            }
            else
            {
                Console.WriteLine("There is no discount");
                Console.WriteLine("Your final sum: " + sum);
            }
        }
    }
}
