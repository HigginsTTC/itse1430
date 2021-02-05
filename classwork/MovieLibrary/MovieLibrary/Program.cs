/*
 * ITSE 1430
 * 
 */

using System;
using System.Collections.Generic;

namespace MovieLibrary
{
    class Program
    {
        static void Main() // (stromg[] srgs)           
        { 
            bool done = false;
            do
            {
                char option = DisplayMainMenu();

                // Switch statement is equivalent to a series of if-else-if with equality checks
                //      switch-statement :: =switch (E) { case-statements* [optional default-statement] };
                //  case-statment ::= case E : S ;
                // default-statement ::= default : S ;

                // case label rules:
                //  -must be constant values : literals or simple expressions of constant values
                //  -must be unique
                //  -can be a string
                //  -only allowed a single default
                // Fallthrough behavior if no break statement
                //  -not allowed, must use a break statement
                //  -Allowed if case lable has no statement (including semicolon)

                // Styling rules
                //  - Single statement ( excluding break) no blcok statement needed
                //  -Multipe statements (excluding break) should use blcok statement to avoid compiler errors.

                switch (10)
                {
                    case 10: S1; S2; S3; break;
                    case 12:
                    {
                        int x; x = 10;
                        break;
                    };
                    case 13: SByte; break;
                }


                switch (option)
                {
                    case 'A': AddMovie(); break;
                    case 'V': ViewMovie(); break;
                    case 'Q': done = true; break;

                    default: DisplayError("Unknown command"); break;
                }


                if (option == 'A')
                    AddMovie();
                else if (option == 'V')
                    ViewMovie();
                else if (option == 'Q')
                    done = true;
                else
                    DisplayError("Unknown command");
            } while (!done);
        }

        private static char DisplayMainMenu ()
        {
            Console.WriteLine("Movie Library"); 
            Console.WriteLine("-------------");

            Console.WriteLine("(A)dd Movie");
            Console.WriteLine("V)iew Movie");
            Console.WriteLine("(Q)uit");

            string input = Console.ReadLine();

            do
            {

                if (Console.ReadLine()== "A" || Console.ReadLine()== "a")
                    return 'A';
                else if (Console.ReadLine()== "Q" || Console.ReadLine()== "q")
                    return 'Q';
                else if (Console.ReadLine()== "V" || Console.ReadLine()== "v")
                    return 'V';

                DisplayError("Invalid option");
            } while (true);
        }
        // Get movie from user
        static void AddMovie()
        {
            // title, release year, run length (min), description, rating
            Console.Write("Enter a title: ");
            title = Console.ReadLine();

            Console.Write("Enter optional description: ");
            description = Console.ReadLine();

            Console.Write("Enter a release year ");
            releaseYear = ReadInt32(1900);

            Console.Write("Enter the run length in minutes: ");
            runLength = ReadInt32(0);

            Console.Write("Enter the rating: ");
            rating = Console.ReadLine();

            Console.Write("Is this a Classic (Y/N): ");
            isClassic = ReadBoolean();

            ViewMovie();
        }

        static string title;
        static string description;
        static int releaseYear;
        static int runLength;
        static string rating;
        static bool isClassic;


        string stringliteral = "Hello" + "World";


        void DemoString ()
        {
            // Conversion t string
            int hours = 10;
            string hourString = hours.ToString(); // *
            // or
            hourString = 10.ToString();

        }

        private static object emptyString1;
        private static object defautString1;
        private static string emptyString2;
        // Verbatim syntax
        string filePath = "C:\\Temp\\test.txt";
        string secondFilePath = @"C:\Temp\test.txt"; // Verbatim syntax

        // Empty string
        // null and empty string are not the same
        string emptyString = "";  // this is not the default value of a string.
        string emptyString3 = String.Empty;
        string defautString = null; 
        bool areEqual = emptyString1 == defautString1; // false

        // checking for empty string
        bool isEmptyPreferred = String.IsNullOrEmpty(emptyString2);

        // String concatenation
        string first = "Hello", second = "World";

        string concatOp = first1 + " " + second1;  // 
        string concatFunction = String.Concat(first2, " ", second2);
        private static string second1;
        private static string first1;
        private static IEnumerable<string> first2;
        private static object second2;
        private static string immutableString1 = String.Empty;


        string joinFunction = String.Join(' ', first2, second2);

        // Strings are immutable!!!! there values cannot change.
        string immutableString = "Hello";
        //immutableString1 += " "; // now we have 2 strings,  "Hello" and "Hello "


        // String formatting
        //      the result of 4 + 5 = 9
        static int x = 4;
        static int y = 5;
        static int total = x + y;




        static void ViewMovie()
        {
            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine(releaseYear);
            Console.WriteLine(runLength);
            Console.WriteLine(rating);
            Console.WriteLine(isClassic);
        }

        static bool ReadBoolean()
        {
            do
            {
                //ConsoleKeyInfo key = Console.ReadKey(); //returns the character the user enters
                string input = Console.ReadLine();

                if (input == "Y" || input == "y")
                    return true;
                else if (input == "N" || input == "n")
                    return false;
                DisplayError("Plese enter either Y or N");
            } while (true);
        }

        static int ReadInt32()
        {
            return ReadInt32(Int32.MinValue);
        }



        // Read and integer value
        static int ReadInt32( int minimumValue )
        {

            //TODO: handle min value

            // while (Eb) S;  (pretest)
            //  S executes 0 or more times, if false, not a all

            //  * do while
            //  S executes at least once (posttest)
            // nreak statement
            //      Only valid in loop constructs
            //      Immediately exits the current loop
            // continue statuement
            //      Only valid in loop constructs
            //      Immediately exits the current iteration and checks the loop again


            do
            {
                //TODO: Keep prompting until valid value
                //string input = Console.ReadLine();

                // Type inferencing - compiler infers the based upon assignment
                var input = Console.ReadLine(); // var is only valid in local variables. 
                var value = 43.5 + 45;

                //TODO: Fix so it doesn't crash if not integer
                // Convert string to int
                //int value = Int32.Parse(input);  // takes a string and converts it to int ((prefer TryParse))

                //int result;
                //if (Int32.TryParse(input, out result))  // TryParse returns a true false 


                if (Int32.TryParse(input, out int result))  // inline variable declaration
                {
                    // Make sure it is at leae minValue
                    if (result >= minimumValue)
                        return result;
                    else
                        DisplayError("Value must be at leaset " + minimumValue);
                } else
                    DisplayError("Value must be numeric");// Helper Function

            } while (true);       
        }

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

        void DemoTypes()
        {

        }

        void DemoExpressions()
        {
            // Arithmetic
            int result = 4 + 5;
            //  +   -    *    /    %

            // int division problem, you will lose your remainders.

            // Logical bool op bool = bool
            bool logicalResult = true && true;  // Logical AND
            logicalResult = true || true;       // Logical OR
            logicalResult = !true;              // Logical !

            // Relational 
            bool relationalResult = 10 > 20;
            relationalResult = 10 < 20;
            relationalResult = 10 >= 20;
            relationalResult = 10 <= 20;
            relationalResult = 10 != 20;
            relationalResult = 10 == 20;

            // Conditional
            //  Expression ? Expression true : Expession false
            //  if else
            // Et and Ef must be the exasct same type  (tend to need type casting)

            // Misc
            // assignment
            // right associateve : evalus the right side first and then the left
            logicalResult = relationalResult = false;

            // funcation calls
            // Parameter :: = variabe inside function defineition used to store temporary value
            // Argument :: = expression used to assign a value to a parameter
            // kinds of parameters
            //  There are three
            //   *  Input (pass by value) - copies the argument value into the parameters memory location, two separate copies
            //          Foo(12);
            //      Input/Output (pass by reference C++ and Java) - temporarily share the same memory location for 2 different variables.
            //          Foo(ref arg);
            //      output - Function caller provides space but the function provides the value
            //          Fos(out arg);
            result = ReadInt32();
            result = Int32.Parse("123");
        }

        // Input parameter - T name
        // Input/Output parmeter parameter - ref T 
        // Output parameter - out T ame
        void Foo ( int inputParameter, ref double ioParamete, out bool result )
        {
            result = false;
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
