using System;

class Program
{
    // No extra creativity is added; program implements core requirements.
    // Files: Activity.cs, BreathingActivity.cs, ReflectionActivity.cs, ListingActivity.cs, Program.cs

    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select an option (1-4): ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number 1-4. Press Enter to continue.");
                Console.ReadLine();
                choice = 0;
                continue;
            }

            switch (choice)
            {
                case 1:
                    var breathing = new BreathingActivity();
                    breathing.StartActivity();
                    break;
                case 2:
                    var reflection = new ReflectionActivity();
                    reflection.StartActivity();
                    break;
                case 3:
                    var listing = new ListingActivity();
                    listing.StartActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
