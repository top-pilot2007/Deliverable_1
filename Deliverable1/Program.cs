using System;

namespace Deliverable1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string vacationType = null;
            int groupSize;
            Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
            vacationType = Console.ReadLine();
            Console.Write("How many are in your group? ");
            groupSize = int.Parse(Console.ReadLine());


            string travelSuggestion = (groupSize <= 2) ? "first class" : (groupSize <= 5) ? "helicopter" : "charter flight";

            string destination = null;
            if (vacationType == "musical") { destination = "New Orleans"; }
            else if (vacationType == "tropical") { destination = "a beach vacation in Mexico"; }
            else if (vacationType == "adventurous") { destination = "whitewater rafting the Grand Canyon"; }


            string result = "Since you’re a group of "
                            + groupSize
                            + " going on a "
                            + vacationType
                            + " vacation, you should take a "
                            + travelSuggestion
                            + " to "
                            + destination
                            + ".";
            Console.WriteLine(result);

            
        }
    }
}
