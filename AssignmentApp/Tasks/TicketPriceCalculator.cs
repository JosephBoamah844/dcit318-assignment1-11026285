using System;

namespace AssignmentApp.Tasks
{
    public class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7");
            else
                Console.WriteLine("Ticket Price: GHC10");
        }
    }
}
