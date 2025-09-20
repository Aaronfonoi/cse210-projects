using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture scripture = new Scripture("Helaman ", 5, 6,7, "6 Behold, my sons, I desire that ye should remember to keep the commandments of God; and I would that ye should declare unto the people these words. Behold, I have given unto you the names of our first parents who came out of the land of jerusalem; and this I have done that when you remember your names ye may remember them; and when ye remember them ye may remember their works; and when ye remember their works ye may know how that it is said, and also written, that they were good. 7 Therefore, my sons, I would that ye should do that which is good, that it may be said of you, and also written, even as it has been said and written of them.");
        Console.Clear();
        scripture.Display();
        Console.WriteLine(" ###### Press enter key to continue or type quit to finish ######");


        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            
                
                    break;
            

            if (!scripture.HideRandomWords())
            {
                Console.WriteLine("Congratulations youve made through the scripture memorizer!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine(" Press enter key to continue or type quit to finish");
        }

        
    }
}