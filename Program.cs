/*
 Author: Leonardo Constante 
 Date: 09/12/2019
 Comments: This app is for ISM4300 students to check their grade 
*/
using System;

namespace Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
                     //ask input for user 
                     Console.WriteLine("What final grade are you expecting in ISM 4300? ");

                    // try catch is being used to check if right grade is shown

             try
            {
                    //declare variable 
                    string input = Console.ReadLine();

                    //parsing variable
                    int input_value = int.Parse(input);


                //writing conditional statements to match user input

                //conditional statement for A+
                if ((input_value >= 98) && (input_value <= 100))
                {
                    Console.WriteLine("Your grade for ISM 4300 is A+");

                }

                //conditional statement for A
                else if ((input_value >= 92) && (input_value <= 97))
                {
                    Console.WriteLine("Your grade for ISM 4300 is A");
                }

                //conditional statement for A-
                else if ((input_value >= 90) && (input_value <= 91))
                {
                    Console.WriteLine("Your grade for ISM 4300 is A-");
                }

                //conditional statement for B+
                else if ((input_value >= 88) && (input_value <= 89))
                {
                    Console.WriteLine("Your grade for ISM 4300 is B+");
                }

                //conditional statement for B
                else if ((input_value >= 82) && (input_value <= 87))
                {
                    Console.WriteLine("Your grade for ISM 4300 is B");
                }

                //conditional statement for B-
                else if ((input_value >= 80) && (input_value <= 81))
                {
                    Console.WriteLine("Your grade for ISM 4300 is B-");
                }

                //conditional statement for C+
                else if ((input_value >= 78) && (input_value <= 79))
                {
                    Console.WriteLine("Your grade for ISM 4300 is C+");
                }

                //conditional statement for C
                else if ((input_value >= 72) && (input_value <= 77))
                {
                    Console.WriteLine("Your grade for ISM 4300 is C");
                }

                //conditional statement for C-
                else if ((input_value >= 70) && (input_value <= 71))
                {
                    Console.WriteLine("Your grade for ISM 4300 is C-");
                }

                //condtitional statement for D+
                else if ((input_value >= 68) && input_value <= 69)
                {
                    Console.WriteLine("Your grade for ISM 4300 is D+");
                }

                //conditional statement for D
                else if ((input_value >= 62) && (input_value <= 67))
                {
                    Console.WriteLine("Your grade for ISM 4300 is D");
                }

                //conditional statement for D-
                else if ((input_value >= 60) && (input_value <= 61))
                {
                    Console.WriteLine("Your grade for ISM 4300 is D-");
                }

                //conditional statement to check if all other conditional requirements have failed 
                else
                {
                    Console.WriteLine("Your grade for ISM 4300 is F");
                }

                Console.WriteLine();
                Console.ReadKey(true);
            } //end of try

            catch
            {
                Console.WriteLine("Please enter an integar value to get the letter grade");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } //end of catch
        }
    }
}
