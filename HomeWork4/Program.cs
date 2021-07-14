using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int result;
            int numberOfEquations = random.Next(18, 24);
            int[,] arrayOfEquations = new int[numberOfEquations, 2];
            
            Console.WriteLine("Greetings, my minions, today you will granted permission to prove your smartness!\n");
            Console.WriteLine($"You need to answer correctly to {numberOfEquations} question:");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            generateEquations(arrayOfEquations, numberOfEquations, random);

            result = examination(arrayOfEquations, numberOfEquations);

            resultOutput(result, numberOfEquations);            
        }
        
        static int calculateMark(int result, int num)
        {
            double a, b;
            a = result;
            b = num;
            return (int)(a / (b / 12));
        }
        static void generateEquations(int[,] arr, int num, Random rand)
        {
            int a, b;

            for (int i = 0; i < num; ++i)
            {
                a = rand.Next(1, 10);
                b = rand.Next(1, 10);

                if (checkEquationsForaccessibility(arr, a, b, i))
                {
                    arr[i, 0] = a;
                    arr[i, 1] = b;
                }
                else
                {
                    i--;
                }
            }
        }

        static bool checkEquationsForaccessibility(int[,] arr, int firstNumber, int secondNumber, int pos)
        {
            for (int i = 0; i <= pos; ++i)
            {
                if (arr[i, 0] == firstNumber && arr[i, 1] == secondNumber)
                    return false;
            }
            return true;
        }

        static int examination(int[,] arr, int num)
        {
            int result = 0, temp;
            for (int i = 0; i < num; ++i)
            {
                Console.Write($"{i+1}. {arr[i, 0]} * {arr[i, 1]} = ");
                
                try
                {
                    temp = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (temp != arr[i, 0] * arr[i, 1])
                    {
                        continue;
                    }
                    else
                    {
                        result++;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("NO! That is not a number! Try again!");
                    i--;
                    continue;
                }
            }
            return result;
        }

        static void resultOutput(int result, int number)
        {
            try
            {
                if (result < number / 2)
                {
                    Console.WriteLine($"You FOOL, you have only {result} correct answers");
                    Console.WriteLine($"Your mark is {calculateMark(result, number)}.");
                }
                else if (result >= number / 2 && result < (number * 2) / 3)
                {
                    Console.WriteLine($"You have {result} correct answers, it is OK");
                    Console.WriteLine($"Your mark is {calculateMark(result, number)}.");
                }
                else if (result >= (number * 2) / 3)
                {
                    Console.WriteLine($"You have {result} correct answers! \n G L O R I O U S   S U C C E S S");
                    Console.WriteLine($"Your mark is {calculateMark(result, number)}!");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Zero correct answer, you must be ashemed!");
            }
        }
    }
}
