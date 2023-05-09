using System;

namespace VariabelOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Malthe";
            //Indexed output
            Console.WriteLine("Your name is: {0}", fornavn);
            //Concated output
            Console.WriteLine("Your name is: " + fornavn);
            //Interpoled 
            Console.WriteLine($"Your name is: {fornavn}");

            //Waits for key-press before ending program
            Console.ReadKey();
        }
    }
    
}