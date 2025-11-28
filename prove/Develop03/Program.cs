using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference and scripture text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

        // Create the scripture object
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            // Display the scripture
            scripture.Display();

            Console.WriteLine();
            Console.WriteLine("Press ENTER to hide a word, or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            // Hide a random word
            scripture.HideRandomWord();

            // If all words are hidden, show final state and exit
            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Press ENTER to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}
