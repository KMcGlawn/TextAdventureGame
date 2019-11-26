using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            GameClass.GameOpening();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            GameClass.FirstChoice();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            GameClass.SecondChoice();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            GameClass.ThirdChoice();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            GameClass.FourthChoice();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            GameClass.EndingOfGame();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            TextColor("GAME OVER", "red");
            Console.WriteLine("To exit the game press \"Enter\"");
            Console.ReadLine();
        }

        static void TextColor(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    public static class GameClass
    {
        public static void GameOpening()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Epic Adventures of Ben and Nate!");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You find yourself walking alone down a dirt road. In the distance a cloud of dirt is being stirred up by a black truck. As the dust cloud gets closer it slows down.  \nA man rolls down his passenger's window and you see a brindle colored dog with a grey collar wagging his tail.  \nThe man shouts to you, \"Hi I'm Nate, and this is my dog, Ben.  We're heading down to the pond to catch some fish. Would you care to join us for the day?\" ");

            GetUsername();
        }

        public static void GetUsername()
        {
            Console.WriteLine("Ben and Nate want you to tag along for a fishing adventure.  What would you like them to call you?");

            string username = Console.ReadLine();
            if (username == "")
            {
                Console.WriteLine("Guess you don't want to go fishing after all...");
            }
            else
            {
                Console.WriteLine($"Thanks for coming with Ben and Nate fishing, {username}, they are happy to have company.");
            }
        }
        

        public static void FirstChoice()
        {
            Console.WriteLine("Nate gestures for you to hop into the truck with Ben and him.  \nYou can choose to hop in the bed of the truck or in the backseat of the cab since Ben is riding shotgun.  \nType bed to hop into the bed of the truck.  Type cab to get into the backseat of the cab.");
            string firstChoice = Console.ReadLine();
            firstChoice = firstChoice.ToLower();
            if (firstChoice == "bed")
            {
                Console.WriteLine("You hop into the bed of the truck with the fishing gear and supplies.  Nate takes off down the dirt road again.");
            }
            else if (firstChoice == "cab")
            {
                Console.WriteLine("You hop into the backseat of the cab sitting behind Ben.  Nate continues down the dirt road.");

            }
            else
            {
                Console.WriteLine("Guess you didn't really want to go fishing today.");
            }
        }
        public static void SecondChoice()
        {
            Console.WriteLine("The truck arrives at a pier on a small pond. Ben jumps out of the truck and runs down the pier to the edge of the water. \nTo follow Ben down the pier type Ben, if you would like to stay and help Nate unload supplies type Nate.");
            string secondChoice = Console.ReadLine();
            secondChoice = secondChoice.ToLower();
            if (secondChoice == "nate")
            {
                Console.WriteLine("Nate turns to you and says, \"Thanks for staying here to help me unload, it's a big help!\"");
            }
            else if (secondChoice == "ben")
            {
                Console.WriteLine("You follow Ben down the pier and gaze out at the pond. Nate shouts from the truck, \"Hey can you come back here and grab this cooler of bait?!\"");
            }
            else
            {
                Console.WriteLine("You stumble out of the truck and head back down the dirt road.  Guess you weren't really interested in fishing today.");
            }
        }
        public static void ThirdChoice()
        {
            Console.WriteLine("As you and Nate head down to the pier with the gear, \nNate asks if you would prefer using the rod and reel or the cane pole with a string and hook. \nTo choose the rod and reel press A, if you would prefer the cane pole press B.");
            string thirdChoice = Console.ReadLine();
            thirdChoice = thirdChoice.ToLower();
            if (thirdChoice == "a")
            {
                Console.WriteLine("Nate hands you the rod and reel and ties the hook on the string to the cane pole for himself.");
            }
            else if (thirdChoice == "b")
            {
                Console.WriteLine("Nate hands you the cane pole and keeps the rod and reel for himself.");
            }
            else
            {
                Console.WriteLine("You find a stick and throw it in the water for Ben");
            }
        }
        static int luck = 5;
        static Random randomNumber = new Random();

        public static bool Luck()
        {

            int karma = randomNumber.Next(10);
            bool result = false;

            if (luck >= karma)
            { result = true; }

            return result;
        }
        public static void FourthChoice()
        {


            Console.WriteLine("You and Nate bait your hooks and cast into the water. \nYou feel a tug on your line. Will your luck allow you to catch a fish? Press enter to find out!");
            Console.ReadLine();
            Luck();
            bool fish = Luck();
            if (fish == true)
            {
                Console.WriteLine("You catch a fish!");
            }
            else if (fish == false)
            {
                Console.WriteLine("You pull up a large wet sock");
            }
            Console.WriteLine("Press A to cast again. Press B to stop fishing for the evening");
            string fourthChoice = Console.ReadLine();
            fourthChoice = fourthChoice.ToLower();
            if (fourthChoice == "a")
            {
                Console.WriteLine("You cast your line again and wait patiently for a tug");
                if (fish == true)
                {
                    Console.WriteLine("You catch a fish!");
                }
                else if (fish == false)
                {
                    Console.WriteLine("Ben jumps into the water and splashes around scaring all the fish away");
                }
            }
            else if (fourthChoice == "b")
            {
                Console.WriteLine("You turn to Nate and say, \"Thanks for letting me tag along today!\"");
            }
                     
            
        
        }
        public static void EndingOfGame()
        {
            Console.WriteLine("As the sun sets over the small pond you help Nate gather his gear. \nTo thank him for the day and head off on your own type \"Thanks\", if you would prefer to stay and pet Ben for awhile type \"Ben\".");
            string endingOfGame = Console.ReadLine();
            endingOfGame = endingOfGame.ToLower();
            if (endingOfGame == "thanks")
            {
                Console.WriteLine("You turn to Nate with a big smile on your face and say, \"Thanks for the fun day, it was great!\"");
            }
            else if (endingOfGame == "ben")
            {
                Console.WriteLine("You look down at your feet to Ben.  As he gazes up at you, your fingers scratch the soft part just behind his ears.");
            }

       
        }

    }
    
    
}
