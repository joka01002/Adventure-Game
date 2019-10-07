using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            List<string> items = new List<string>();
            string location = "kitchen";
            Console.WriteLine("Welcome to this adventure game");
            Console.WriteLine("if you need help write 'help'");
            Console.WriteLine("To start the game press any button");
            Console.ReadLine();
            Console.WriteLine("You awaken in a broken down house. " +
            "The only thing on your body are some old rags. Who are you? What happened here? How did you get here? " +
            "You choose to embark on a jouney to find answers to your questions. But where do you start?");
            
            while(play)
            {
                string choice = Console.ReadLine().ToLower();
                if(choice == "help")
                {
                    Console.WriteLine("To move write 'go' followed by direction, 'north', 'south', 'east' or 'west'.");
                    Console.WriteLine("To view inventory write 'inventory'.");
                    Console.WriteLine("To quit the game write 'quit'.");
                    Console.WriteLine("To look around the place write 'search'.");
                    Console.WriteLine("To search specific places write 'search' followed by location.");
                    Console.WriteLine("To pick up items write 'pick up' followed by the item.");
                    Console.WriteLine("To use an item in inventory write 'use' followed by the item.");
                }
                else if(choice == "inventory")
                {
                    Console.WriteLine("These are the following items that you currently own.");
                    foreach(string i in items)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if(choice == "quit")
                {
                    play = false;
                }
                else if (choice == "go north")
                {

                }
                else if (choice == "go south")
                {

                }
                else if (choice == "go east")
                {

                }
                else if (choice == "go west")
                {

                }
                else
                {
                    Console.WriteLine("Incorrect command.");
                }
            }
        }
    }
}
