using System;
using System.Threading;
//task 2
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int width;
            int height;
            bool on = false;
            string randomSymbol = "1234567890ETAOINSHRDLCUMWFGYPBVKXJQZ/-+=/][.,";
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("enable pentagon hacking yes/no");
            string text = Console.ReadLine();
            
            if(text == "yes")
            {
                Console.SetCursorPosition(rand.Next(0, width), rand.Next(0, height));
                on = true;
            }
            else
            {
                Environment.Exit(0);
            }
            
            
            
            while (on){
                for (int i = 0; i < 10; i++){
                    Console.SetCursorPosition(rand.Next(0, width), rand.Next(0, height));
                    Console.WriteLine(randomSymbol[rand.Next(0, 45)]);
                }
                for (int i = 0; i < 20; i++){
                    Console.SetCursorPosition(rand.Next(0, width), rand.Next(0, height));
                    Console.Write(" ");
                }
            }
        }
    }
}
