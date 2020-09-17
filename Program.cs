/*
 * Author: Daniel Niles
 * Date: 9/17/2020
 * Purpose: To show what letter grade a student has earned. 
 */
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Niles_TechAssignment2b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for user input
            Console.WriteLine("Please enter your expected final grade");
            //To catch any invalid inputs
            try
            {
                //Reads what the user input
                String userInput = Console.ReadLine();
                //parses user input from a string to an integer
                int grade = int.Parse(userInput);
                //If statement to ensure the grade is between 0 and 100
                if (grade > 0 && grade <= 100)
                {
                    //Creates a string for the switch statement to send the final value to
                    String finalGrade;
                    //divides grade by 10 to make it easier to process the cases
                    switch (grade / 10)
                    {
                        case 10:
                            finalGrade = "A+";
                            break;
                        //Case 9 means any number after 9, or 90 - 90 in this case
                        case 9:
                            finalGrade = "A";
                            break;
                            //same as above, but for B
                        case 8:
                            finalGrade = "B";
                            break;
                        case 7:
                            finalGrade = "C";
                            break;
                        case 6:
                            finalGrade = "D";
                            break;
                            //The default here shows any number not previously touched on by the case is an F
                        default:
                            finalGrade = "F";
                            break;
                    }
                    //Writes the final response
                    Console.WriteLine("Your final grade is: " + finalGrade);
                }
            }
            //End try
            catch
            {
                //Ensures the user types their grade correctly
                Console.WriteLine("Please enter a number between 0 and 100");
            }
        }
    }
    }
 

