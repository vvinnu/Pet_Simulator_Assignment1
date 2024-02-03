using Petsimulator;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //Displaying list of pets to select from

            Console.WriteLine("List of pets available \n");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Squirrel");
            Console.WriteLine("3. Dog");

            //declaring the userinput as 0 to enter the do while loop condition
            string userinput = "0";
            string pet_type = " ";
            do
            {
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
                        Console.WriteLine("\nPlease enter a valid choice below again");
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
           
        }

    }

}