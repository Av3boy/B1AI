using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Program
    {

        string userinput = Console.ReadLine();

        static void Main(string[] args)
        {

            Console.WriteLine("hello! My name is B1, i am programmed to serve as an allpurpose program.");
            Console.WriteLine("How can i help? /n Type HELP to see possible commands.");

            Commands();

            #region

            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {

                Console.WriteLine("Are you sure you want to close the program. /n Press Y to close, Press N to cancel.");

                if (Console.ReadKey(true).Key == ConsoleKey.Y)
                    Environment.Exit(0);

                else if(Console.ReadKey(true).Key == ConsoleKey.N)
                {

                    Commands();

                }

            }

            #endregion

        }

        public static void Commands()
        {

            String command;
            Boolean quitNow = false;

            while (!quitNow)
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "/help":
                        Commands();
                        break;

                    case "/version":
                        Console.WriteLine("This should be version.");
                        break;

                    case "/quit":
                        quitNow = true;
                        break;

                    case "/time":
                        Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                        break;

                    case "/cal":
                        Calculator();
                        break;

                    default:
                        Console.WriteLine("Unknown Command " + command);
                        break;
                }
            }

        }

        void Commands(string _commands)
        {

            List<string> commands = new List<string>{ "/help", "/version", "/quit", "/time", "/cal" };

            Console.WriteLine(commands);

            foreach (string command in commands)
            {

                

            }

        }

        public static void Calculator()
        {

            int first;
            int second;
            int answer;

            string operation;

            first = Convert.ToInt32(Console.ReadLine());
            operation = Console.ReadLine();
            second = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {

                case "/":
                    answer = first / second;
                    Console.WriteLine(first + " / " + second + " = " + answer);
                    break;

                case "*":
                    answer = first * second;
                    Console.WriteLine(first + " * " + second + " = " + answer);
                    break;

                case "+":
                    answer = first + second;
                    Console.WriteLine(first + " + " + second + " = " + answer);
                    break;

                case "-":
                    answer = first - second;
                    Console.WriteLine(first + " - " + second + " = " + answer);
                    break;

                default:
                    Console.WriteLine("Unknown Command " + operation);
                    Commands();
                    break;

            }

        }
    }
}
