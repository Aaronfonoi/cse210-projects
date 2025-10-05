using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Activity Session");
            Console.WriteLine($"Breathing activity: {breathingLog}");
            Console.WriteLine($"Reflecting activity: {reflectingLog}");
            Console.WriteLine($"Listing activity: {listingLog}");
            Console.WriteLine();

        }

        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("***MENU***");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. End Session");
            Console.Write("please select an option: ");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.PromptBreathing();
                    breathingActivity.EndActivity();

                    breathingLog++;
                    break;




                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.RunActivity();
                    reflectingActivity.PromptReflection();
                    reflectingActivity.EndActivity();

                    reflectingLog++;
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.PromptListing();
                    listingActivity.EndActivity();

                    listingLog++;
                    break;

                case "4":
                    Environment.Exit(0);
                    break;


                default:
                    Console.WriteLine("please enter the number of the option.");
                    break;

            }


        }
        Environment.Exit(0);
    }
}