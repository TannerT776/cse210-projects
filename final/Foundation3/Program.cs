using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Address address2 = new Address("456 Oak Ave", "Orem", "UT", "USA");
        Address address3 = new Address("789 Park Blvd", "Lehi", "UT", "USA");

        Lecture lecture = new Lecture(
            "C# Deep Dive",
            "Advanced C# topics for intermediate developers.",
            "12/18/2025",
            "7:00 PM",
            address1,
            "Dr. Smith",
            100);

        Reception reception = new Reception(
            "Networking Night",
            "Meet local developers and share projects.",
            "01/05/2026",
            "6:30 PM",
            address2,
            "rsvp@devmeetup.com");

        OutdoorGathering outdoor = new OutdoorGathering(
            "Tech Picnic",
            "Casual meetup with food and outdoor games.",
            "06/10/2026",
            "11:00 AM",
            address3,
            "Sunny with light breeze");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);

        foreach (Event e in events)
        {
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine("----------------");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("FULL DETAILS");
            Console.WriteLine("------------");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION");
            Console.WriteLine("-----------------");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
        }
    }
}
