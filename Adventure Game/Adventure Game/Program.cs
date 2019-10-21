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
            bool hiddenroom = false;
            List<string> items = new List<string>();
            string location = "kitchen";
            Console.WriteLine("Welcome to this adventure game");
            Console.WriteLine("if you need help write 'help'");
            Console.WriteLine("To start the game press any button");
            Console.ReadLine();
            Console.WriteLine("You awaken in a broken down house. " +
            "The only thing on your body are some old rags. Who are you? What happened here? How did you get here? " +
            "You choose to embark on a jouney to find answers to your questions. But where do you start?");
            Kitchen();

            while (play)
            {
                string command = Console.ReadLine().ToLower();
                string[] choice = command.Split(' ');
                if (choice[0] == "help")
                {
                    Console.WriteLine("To move write 'go' followed by direction, 'north', 'south', 'east' or 'west'.");
                    Console.WriteLine("To view inventory write 'inventory'.");
                    Console.WriteLine("To quit the game write 'quit' or 'end'.");
                    Console.WriteLine("To look around the place write 'search'.");
                    Console.WriteLine("To search specific places write 'search' followed by location.");
                    Console.WriteLine("To pick up items write 'take' followed by the item.");
                    Console.WriteLine("To use an item in inventory write 'use' followed by the item.");
                }
                else if (choice[0] == "inventory")
                {
                    Console.WriteLine("These are the following items that you currently own.");
                    foreach (string i in items)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (choice[0] == "quit" || choice[0] == "end")
                {
                    play = false;
                }
                else if (choice[0] == "go")
                {
                    if (choice[1] == "north")
                    {
                        if (location == "kitchen" || location == "pantry" || location == "proch" || location == "washroom")
                        {
                            Console.WriteLine("You can't move north in this location.");
                        }
                        else if (location == "hall")
                        {
                            location = "kitchen";
                            Kitchen();
                        }
                        else if (location == "tower")
                        {
                            location = "washroom";
                            Washroom();
                        }
                        else if (location == "livingroom")
                        {
                            location = "hall";
                            Hall();
                        }
                    }
                    else if (choice[1] == "south")
                    {
                        if (location == "livingroom" || location == "porch" || location == "pantry" || location == "tower")
                        {
                            Console.WriteLine("You can't move south in this location.");
                        }
                        else if (location == "washroom")
                        {
                            if (hiddenroom)
                            {
                                location = "tower";
                                Tower();
                            }
                            else
                            {
                                Console.WriteLine("You don't seem to be able to move in that direction");
                            }
                        }
                        else if (location == "hall")
                        {
                            location = "livingroom";
                            Livingroom();
                        }
                        else if (location == "kitchen")
                        {
                            location = "hall";
                            Hall();
                        }
                    }
                    else if (choice[1] == "east")
                    {
                        if (location == "porch" || location == "livingroom" || location == "tower")
                        {
                            Console.WriteLine("You can't move east in this location.");
                        }
                        else if (location == "pantry")
                        {
                            location = "kitchen";
                            Kitchen();
                        }
                        else if (location == "kitchen")
                        {
                            location = "porch";
                            Porch();
                        }
                        else if (location == "washroom")
                        {
                            location = "hall";
                            Hall();
                        }
                        else if (location == "hall")
                        {
                            location = "doghouse";
                            Doghouse();
                        }
                    }
                    else if (choice[1] == "west")
                    {
                        if (location == "livingroom" || location == "tower" || location == "washroom" || location == "pantry")
                        {
                            Console.WriteLine("You can't move west in this location.");
                        }
                        else if (location == "doghouse")
                        {
                            location = "hall";
                            Hall();
                        }
                        else if (location == "hall")
                        {
                            location = "washroom";
                            Washroom();
                        }
                        else if (location == "porch")
                        {
                            location = "kitchen";
                            Kitchen();
                        }
                        else if (location == "kitchen")
                        {
                            location = "pantry";
                            Pantry();
                        }
                    }
                }
                else if (choice[0] == "use")
                {
                    if (location == "doghouse")
                    {
                        if (choice[1] == "knife")
                        {
                            Console.WriteLine("You need to pass through and stab the knife right into its chest." +
                                "The dog writhes in pain until it finally stops moving." +
                                "You can now move forward but with a bad feeling in your heart");
                        }
                        else if (choice[1] == "rusty" && choice[2] == "knife")
                        {
                            Console.WriteLine("You need to pass through and stab the knife right into its chest." +
                                "The dog writhes in pain until it finally stops moving." +
                                "You can now move forward but with a bad feeling in your heart");
                        }
                        else if (choice[1] == "meat")
                        {
                            Console.WriteLine("You reach out the meat towards the dog." +
                                "It takes a while but the dog takes the meat and devours it." +
                                "The dog seems happy and as you move you see that it follows you." +
                                "You've gained a companion and of corse it needs a name." +
                                "What is it's name?");
                            string name = Console.ReadLine();
                            items.Add(name + " the Dog");
                            items.Remove("rotten meat");
                        }
                    }
                    if (location == "washroom")
                    {
                        if (choice[1] == "flour")
                        {
                            Console.WriteLine("");
                            hiddenroom = true;
                            items.Remove("flour");
                        }
                    }
                }
                else if (choice[0] == "take")
                {
                    if (location == "kitchen")
                    {
                        if (choice[1] == "knife")
                        {
                            Console.WriteLine("You pick up the rusty knife, " +
                                "it's not that sharp but could probably kill something if needed");
                            items.Add("Rusty Knife");
                        }
                        if (choice[1] == "rusty" && choice[2] == "knife")
                        {
                            Console.WriteLine("You pick up the rusty knife, " +
                                "it's not that sharp but could probably kill something if needed");
                            items.Add("Rusty Knife");
                        }
                        if (choice[1] == "meat")
                        {
                            Console.WriteLine("This meat does not look appetizing" +
                                "You definitely don't want to eat it but something else might");
                            items.Add("Rotten meat");
                        }
                    }
                    if (location == "pantry")
                    {
                        if (choice[1] == "flour")
                        {
                            Console.WriteLine("You take the flour." +
                                "When thrown it might make it difficult to see. " +
                                "You never know what will happen");
                            items.Add("Flour");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect command.");
                }
            }
        }

        static void Kitchen()
        {
            Console.WriteLine("You are in the kitchen. As you look around you see a fridge, stove, table" +
                "To the west of you there is a pantry, to the east a porch and to the south is the hall");
        }
        static void Porch()
        {
            Console.WriteLine("You arrive in a dusty porch");
        }
        static void Pantry()
        {
            Console.WriteLine("You walk into the pantry. There seems to be mold growing on the walls");
        }
        static void Hall()
        {
            Console.WriteLine("Walking into the hall you see four ways to move forwards.");
        }
        static void Livingroom()
        {
            Console.WriteLine("You are in the living room. ");
        }
        static void Washroom()
        {
            Console.WriteLine("Standing in the dim light of the washroom");
        }
        static void Tower()
        {
            Console.WriteLine("Walking into this dusty tower you see the tall stairs going up.");
        }
        static void Doghouse()
        {
            Console.WriteLine("Walking towards the lonely doghouse");
        }
    }
}
