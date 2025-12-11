using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // 3 miles in 30 minutes
        activities.Add(new Running("12/01/2025", 30, 3.0));

        // 45 minutes at 15 mph
        activities.Add(new Cycling("12/02/2025", 45, 15.0));

        // 20 laps in 25 minutes
        activities.Add(new Swimming("12/03/2025", 25, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
