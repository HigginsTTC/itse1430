/*
 * ITSE 1430
 * 
 */

using System;

namespace MovieLibrary
{
    class Program
    {
        static void Main() // (stromg[] srgs)           

        {
            AddMovie();
            DisplayMainMenu();
        }

        private static void DisplayMainMenu ()
        {
            Console.WriteLine("Movie Library"); 
            Console.WriteLine("-------------");

            Console.WriteLine("(A)dd Movie");
            Console.WriteLine("(Q)uit");

            string input = Console.ReadLine();

            //TODO: validate input
            //TODO: Return selected option
        }
        // Get movie from user
        static void AddMovie()
        {
            // title, release year, run length (min), description, rating
            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            Console.Write("Enter optional description: ");
            string description = Console.ReadLine();

            Console.Write("Enter a release year ");
            int releaseYear = ReadInt32();

            Console.Write("Enter the run length in minutes: ");
            int runLength = ReadInt32();

            Console.Write("Enter the rating: ");
            string rating = Console.ReadLine();

            Console.Write("Is this a Classic (Y/N): ");
            bool isClassic = ReadBoolean();
        }

        static bool ReadBoolean()
        {
            ConsoleKeyInfo key = Console.ReadKey(); //returns the character the user enters

            //TODO: Handle key values
            return true;
        }


        // Read and integer value
        static int ReadInt32()
        {

            //TODO: handle min value

            //TODO: Keep prompting until valid value
            string input = Console.ReadLine();

            //TODO: Fix so it doesn't crash if not integer
            // Convert string to int
            int value = Int32.Parse(input);

            return value;
        }
        void DemoTypes()
        {

        }

        void DemoVariables ()
        {
            string textInput;
            textInput = "Hello";
        }

        // Data to collect
        // title, release year, run length (min), description, rating

    }
}
