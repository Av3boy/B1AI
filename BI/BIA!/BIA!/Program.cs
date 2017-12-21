using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello! My name is B1, i am programmed to serve as an allpurpose program.");
            Console.WriteLine("How can i help? Type /HELP to see available commands.");
            Program.Commands();

        }

        public static void Quit()
        {
                Console.WriteLine("Are you sure you want to close the program. Press Y to close, Press N to cancel.");

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
                Environment.Exit(0);

            else
                Console.Clear();
                Program.Main();
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
                    case "/clear":
                        Console.Clear();
                        Program.Main();
                        break;

                    case "/help":
                        Program.commands();
                        break;

                    case "/version":
                        Console.WriteLine("V 0.1.0");
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

        public static void commands()
        {
            string[] commands = new string[6] { "/help", "/version", "/quit", "/time", "/cal", "/clear" };
            foreach (string s in commands)
            {
                Console.WriteLine(s);                
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