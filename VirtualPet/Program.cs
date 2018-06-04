using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOADED CONSTRUCTOR 
            VirtualPet pickle = new VirtualPet(15, 30, 20, "Pickle the Pitbull");
            //END LOADED CONSTRUCTOR

            Console.WriteLine("Time to check on {0} ! Type yes to continue.", pickle.Name);
            string exitResponse = Console.ReadLine().ToLower();

            //WHILE LOOP TO RE-DISPLAY MENU WHEN 'YES' IS TYPED
            while (exitResponse.Equals("yes"))
            {
                Console.WriteLine("Please select from the following menu to check on {0}.", pickle.Name);

                Console.WriteLine("Select 1 to get {0}'s status", pickle.Name);
                Console.WriteLine("Select 2 to feed {0}.", pickle.Name);
                Console.WriteLine("Select 3 to play with {0}.", pickle.Name);
                Console.WriteLine("Select 4 to let {0} take a nap.", pickle.Name);
                int userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        pickle.Tick();
                        Console.WriteLine("Pickle The Pitbull:");
                        Console.WriteLine("Hunger: {0}%", pickle.Hunger);
                        Console.WriteLine("Bored: {0}%", pickle.Bored);
                        Console.WriteLine("Tired: {0}%", pickle.Tired);

                        if (pickle.HungerAlert)
                        {
                            Console.WriteLine("{0} is {1}% hungry and needs to be fed.", pickle.Name, pickle.Hunger);
                            Console.WriteLine("Please enter a new hunger level for {0}.", pickle.Name);
                            int newHunger = int.Parse(Console.ReadLine());
                            pickle.SetHunger(newHunger);
                        }

                        if (pickle.BoredAlert)
                        {
                            Console.WriteLine("{0} is {1}% bored and wants to play.", pickle.Name, pickle.Bored);
                            Console.WriteLine("Please enter a new boredom level for {0}.", pickle.Name);
                            int newBored = int.Parse(Console.ReadLine());
                            pickle.SetBored(newBored);
                        }

                        if (pickle.TiredAlert)
                        {
                            Console.WriteLine("{0} is {1}% sleepy and wants to take a nap.", pickle.Name, pickle.Tired);
                            Console.WriteLine("Please enter a new sleepiness level for {0}.", pickle.Name);
                            int newTired = int.Parse(Console.ReadLine());
                            pickle.SetTired(newTired);
                        }

                        //Console.WriteLine("{0} is {1}% hungry, {2}% bored, and {3}% sleepy.", pickle.Name, pickle.Hunger, pickle.Bored, pickle.Tired);
                        //I had this sentence here before I added back the numbered status menu.

                        break;
                    case 2:
                        Console.WriteLine("You fed {0}! She is happy. Please enter a new hunger level for {0}.", pickle.Name);
                        int hunger = int.Parse(Console.ReadLine());
                        pickle.SetHunger(hunger);
                        Console.WriteLine("{0} is now {1}% hungry.", pickle.Name, pickle.Hunger);
                        break;
                    case 3:
                        Console.WriteLine("You played with {0}! She is happy. Please enter a new boredom level for {0}.", pickle.Name);
                        int bored = int.Parse(Console.ReadLine());
                        pickle.SetBored(bored);
                        Console.WriteLine("{0} is now {1}% bored.", pickle.Name, pickle.Bored);
                        break;
                    case 4:
                        Console.WriteLine("You let {0} take a nap! She is happy. Please enter a new sleepiness level for {0}.", pickle.Name);
                        int tired = int.Parse(Console.ReadLine());
                        pickle.SetTired(tired);
                        Console.WriteLine("{0} is now {1}% sleepy.", pickle.Name, pickle.Tired);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Type yes to check on {0} again.", pickle.Name);
                exitResponse = Console.ReadLine().ToLower();

            }

        }
    }
}
// Below is my original program class code that I could not get to work.
//I tried to make it so that when you type yes, it shows the menu like it was on the assignment sheet ("Hunger: 15%, Bored: 20%, etc)
//And then I wanted the following menu to have the user enter a number to do something with the pet.
//But I couldn't get the numbers to update when it looped back around, so the first menu of her status levels wouldn't change.
//I shouldn't have but I deleted my code that I had in the virtualpet class that made those numbers increment but it was working. 
//It would generate a random number and add or subtract that to the original number, depending on the case (hunger = hunger decreases but boredom increases)
//I tested it to see if it would just write the new numbers in a console writeline when the user did something (played with pet, the percentage of boredness went down).
//I just couldn't figure out how to make that number show up in the status menu instead of only in a console writeline.
//So on Sunday I finally admitted defeat and tried to model my project after your waterways example.
//So I'd feel a lot better if we could talk about it whenever we go over these projects so I can figure out what I was doing wrong. 



//string exitResp;
//Console.WriteLine("Time to check on your pet! Type yes to see her status:");
//exitResp = Console.ReadLine().ToLower();

//while (exitResp == "yes")
//{

//Console.WriteLine("Pickle The Pitbull:");
//Console.WriteLine("Hunger: {0}%", pickle.Hunger);
//pickle.Tick();
//Console.WriteLine("Bored: {0}%", pickle.Bored);
//pickle.Tick();
//Console.WriteLine("Tired: {0}%", pickle.Tired);
//pickle.Tick();
//Console.WriteLine("");

//Console.WriteLine("What would you like to do?");
//Console.WriteLine("1. Feed Pickle.");
//Console.WriteLine("2. Play with Pickle.");
//Console.WriteLine("3. Let Pickle take a nap.");
//int userChoice = int.Parse(Console.ReadLine());

//if (userChoice == 1)
//{
//    Console.WriteLine("You fed Pickle! Now she's bored.");
//    Console.WriteLine();
//    pickle.Tick();
//}

//else if (userChoice == 2)
//{
//    Console.WriteLine("You played with Pickle! Now she's sleepy.");
//    Console.WriteLine();
//    pickle.Tick();
//}

//else if (userChoice == 3)
//{
//    Console.WriteLine("Shhhh! Pickle is napping. She might be hungry when she wakes up.");
//    Console.WriteLine();
//    pickle.Tick();

//}
//Console.WriteLine("Please type yes to check Pickle's new status:");
//exitResp = Console.ReadLine().ToLower();