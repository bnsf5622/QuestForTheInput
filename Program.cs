using System;

namespace QuestForTheInput
{
    class Program
    {
        static void Main(string[] args)
        {
            String yourName;
            String yourQuest;
            double VelocityOfSwallow;

            // We can us Console.ReadLine as is with our strings because its default is string
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            
            Console.WriteLine("What is your quest? ");
            yourQuest = Console.ReadLine();

            /* When we get to our double data type, we have to do a bit of type changing
                 so we'll use Convert.ToDouble method and put ConsoleReadLine() as the argument. */
            Console.WriteLine("What is the airspeed velocity of an unladed swallow?!?!?!");
            VelocityOfSwallow = Convert.ToDouble(Console.ReadLine());

            Console.Write("How do you know " + VelocityOfSwallow + " is correct, " + yourNameName + ", ");
            Console.WriteLine
        }
    }
}
