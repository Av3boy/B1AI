using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Hey
    {
        public static void hey()
        {
            string Message1 = "";
            string Message2 = "";
            string username = File.ReadLines(Program.configpath).First();
            Random random1 = new Random();
            string Hello1 = "Hey ";
            string Hello2 = "Hi ";
            string Hello3 = "Hello ";
            string Question1 = "! How are you doing?";
            string Question2 = "! How have you been?";
            string Question3 = "! How's everything?";
            string Question4 = "! How's it going?";
            string Question5 = "! What's going on?";
            string Question6 = "! What's new?";
            string Question7 = "! What's up?";
            string Question8 = "! Whassup?";
            string Question9 = "! What are you up to?";


            int randomNumber1 = random1.Next(0, 3);
            switch (randomNumber1)
            {
                case 0:
                    Message1 = Hello1;
                    break;

                case 1:
                    Message1 = Hello2;
                    break;

                case 2:
                    Message1 = Hello3;
                    break;

            }

            int randomNumber2 = random1.Next(0, 9);

            switch (randomNumber2)
            {
                case 0:
                    Message2 = Question1;
                    break;

                case 1:
                    Message2 = Question2;
                    break;

                case 2:
                    Message2 = Question3;
                    break;

                case 3:
                    Message2 = Question4;
                    break;

                case 4:
                    Message2 = Question5;
                    break;

                case 5:
                    Message2 = Question6;
                    break;

                case 6:
                    Message2 = Question7;
                    break;

                case 7:
                    Message2 = Question8;
                    break;

                case 8:
                    Message2 = Question9;
                    break;
            }

            Console.WriteLine(Message1 + username + Message2);
            Program.speaker.Speak(Message1 + username + Message2);
        }
    }
}
