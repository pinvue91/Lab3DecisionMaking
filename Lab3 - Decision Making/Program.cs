using System;

namespace Lab3___Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hi. Please tell me your name: ");

            string name = Console.ReadLine();
            bool runProg = true;

            while (runProg)
            {
                Console.Write($"{name}, please enter a number between 1 and 100: ");

                int num;//needs to come before TryParse so it can have a var to output to

                //user input here & validations. if input is int & 1-100, output to num. if not, loop
                while (!int.TryParse(Console.ReadLine(), out num) || num <1 || num >100) 
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Try again.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write($"{name}, please enter a number between 1 and 100: ");
                }

                //odd, odd & > 60
                if (num % 2 != 0)
                {
                    Console.WriteLine($"{num} Odd");
                }
                //even & >60
                else if (num % 2 == 0 && num > 60)
                {
                    Console.WriteLine($"{num} Even");
                }

                //even & between 26-60
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine("Even");
                }
                //even 
                else if (num % 2 == 0 && num >= 2 && num < 25)
                {
                    Console.WriteLine("Even and less than 25.");
                }               

                Console.Write($"{name}, would like to enter another number (y/n)? ");
                
                bool ynValid = false;
                while (ynValid == false)
                {
                    string yn = Console.ReadLine();
                    if (yn == "n")
                    {
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Thank you. Have a great day, {name}.");
                        Console.BackgroundColor = ConsoleColor.Black;
                        ynValid = true;
                        runProg = false;
                        
                    }
                    else if (yn == "y")
                    {
                        ynValid = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"{name}, would like to enter another number (y/n)? ");
                    }
                }

            }
        }
    }
}
