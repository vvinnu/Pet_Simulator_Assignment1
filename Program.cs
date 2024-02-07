using Petsimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Petsimulator
{
    //class to select and name the pet
    class Petselection
    {
        static void Main(string[] args)
        {

            //declaring the userinput as 0 to enter the do while loop condition
            string userinput = "0";
            string pet_type = " ";
            do
            {
                //Displaying list of pets to select from

                Console.WriteLine("List of pets available \n");
                Console.WriteLine("1. Cat");
                Console.WriteLine("2. Squirrel");
                Console.WriteLine("3. Dog");
                
                //Taking input from the user
                Console.Write("\nEnter your choice of pet: ");

                userinput = Console.ReadLine();
                string text1 = "What would you like to name your pet ?\n";

                //Using a switch statement to handle user's choice of pet

                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("\nYou have choosen a Cat. " + text1);
                        pet_type = "Cat";
                        break;
                    case "2":
                        Console.WriteLine("\nYou have choosen a Squirrel. " + text1);
                        pet_type = "Squirrel";
                        break;
                    case "3":
                        Console.WriteLine("\nYou have choosen a Dog. " + text1);
                        pet_type = "Dog";
                        break;
                    default:
                        Console.WriteLine("\n!!!!!!Please enter a valid choice below again!!!!!!!");
                        break;

                }
            } while (userinput != "1" && userinput != "2" && userinput != "3");

            //Taking the user input for the name of pet
            string petname = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(petname))
            {
                Console.WriteLine("Please enter a valid name\n");
                petname = Console.ReadLine();
            }

            Console.WriteLine("\nNice Name for a " + pet_type + ". Welcome " + petname + ". Let us take good care of you.");

            //calling the menu class by creating an instance
            petmenu menu = new petmenu();
            menu.showmenu(petname);


        }

    }
    //Class for Menu Items
    class petmenu
    {
        public void showmenu(string petname)
        {

            // Creating an instance of pet_attributes
            pet_attributes myPet = new pet_attributes();


            do
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Feed " + petname);
                Console.WriteLine("2. Play with " + petname);
                Console.WriteLine("3. Let " + petname + " rest");
                Console.WriteLine("4. Check " + petname + " status");
                Console.WriteLine("5. Exit");

                Console.WriteLine("----------------------------------------------------------------------");

                //Taking input from the user
                Console.Write("\nEnter the menu option from above to take care of the pet or 5 to exit: ");

                string userinput = Console.ReadLine();

                //Using a switch statement to handle user's choice from the menu options

                switch (userinput)
                {
                    case "1":
                        myPet.Feed();
                        Console.WriteLine("\nYou fed " + petname + ". His hunger decreased and health improved.");
                        Console.WriteLine("\nThank you for feeding.");
                        break;

                    case "2":
                        if (myPet.Hunger >= 8)
                        {
                            Console.WriteLine("\n" + petname + " is hungry. Sorry it cannot play now");
                            Console.WriteLine( petname + " needs to be fed for you to play with it");
                        }
                        else
                        {
                            myPet.Play();
                            Console.WriteLine("\nYou played with " + petname + ". He is much more happier now and also a little bit hungry.");
                            Console.WriteLine("\nThank you for playing.");
                        }
                        break;

                    case "3":
                        myPet.Rest();
                        Console.WriteLine("\nThank you for resting " + petname + " for a while.");
                        Console.WriteLine("\nHis health improved , but also he seems likes little less happier now");
                        break;

                    case "4":

                        Console.WriteLine("\n" + petname + "'s status");
                        Console.WriteLine("\nHunger    -- " + myPet.Hunger);
                        Console.WriteLine("\nHappiness -- " + myPet.Happiness);
                        Console.WriteLine("\nHealth    -- " + myPet.Health);
                        break;

                    case "5":
                        Console.WriteLine("\nThank you for taking care of the " + petname + ".");

                        return;
                        
                    default:
                        Console.WriteLine("\n!!!!!!!Please enter a valid choice below again from the Menu!!!!!!!");
                        break;

                }
            } while ( true );

        }
    }
    class pet_attributes
    {
        // Attributes declaration
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }

        // Constructor
        public pet_attributes()
        {
            // Set default values for attributes
            Hunger = 5;
            Happiness = 5;
            Health = 10;
        }


        // Method to feed the pet
        public void Feed()
        {
            Hunger -= 1; // Decrease hunger when fed
            if (Hunger < 0)  // Ensure hunger doesn't go below 0
            {
                Hunger = 0;
            }
            Health++; // Increase health slightly
            if (Health > 10)
            {
                Health = 10; // Ensure health doesn't exceed 10
            }
            Happiness += 1; // Increase happiness when fed
            if (Happiness > 10)  // Ensure happiness doesn't exceed 10
            {
                Happiness = 10;
            }

        }

        // Method to play with the pet
        public void Play()
        {
            Happiness += 1; // Increase happiness when played with
            if (Happiness > 10)  // Ensure happiness doesn't exceed 10
            { 
                Happiness = 10; 
            }
            Hunger++; // Increase hunger slightly
            if (Hunger >10)  // Ensure hunger doesn't go above 10
            {
                Hunger = 0;
            }
            Health--; // Increase health slightly
            if (Health < 0)
            {
                Health = 0; // Ensure health doesn't go below 0
            }

        }

        // Method to let the pet rest
        public void Rest()
        {
            Health += 1; // Increase health when rested
            if (Health > 10) Health = 10; // Ensure health doesn't exceed 10
            Happiness--; // Decrease happiness slightly


        }
        public void Display_Status()
        {
            
        }
    }

}