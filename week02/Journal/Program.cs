using System;
using System.IO;

class Program
{
    
    
    static void Main(string[] args)
    {
        //int[] validnumbers = { 1, 2, 3, 4, 5, };


        
        int choice = 0;
        Console.Write("Welcome to your journal.");
        //choice = int.Parse(Console.ReadLine());

        Journal theJournal = new Journal();
        PromptGenerator Prompt = new PromptGenerator();




        while (choice != 5)

        {
            choice = Choices();

            switch (choice)

            {
                case 1:
                    string prompt = Prompt.GetPrompt();
                    Entry anEntry = new Entry();


                    Console.Write($"{prompt}>>");
                    string userEntry = Console.ReadLine();
                    anEntry._entryText = userEntry;
                    theJournal._entries.Add(anEntry);
                    break;
                case 2:
                    theJournal.DisplayAll();

                    break;

                case 3:
                    theJournal.SaveToFile();

                    break;

                case 4:
                    theJournal.LoadFromFile();

                    break;

                case 5:
                    Console.WriteLine("Thank you for using the journal app.");

                    break;


                default:
                    Console.WriteLine("Inavlid response choose 1-5");
                    break;
            }


    static int Choices()
        {
                string choices = @"
                please type choose a valid option:
                1. Write journal entry
                2. Display entry 
                3. save file
                4. Load file
                5. Quit ";

                Console.Write(choices);
                string userInput = Console.ReadLine();
                int choice = 0;

                try
                {
                    choice = int.Parse(userInput);
                }

                catch (FormatException)
                {
                    choice = 0;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"unexpected error: {exception.Message}");
                }
                return choice;
        }
   
            
        }




    }
        
        
        
    
    
    
}