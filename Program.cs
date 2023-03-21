﻿using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace TeReoMaoriQuiz
{
    internal class Program
    {
        
         static void Main(string[] args)
        {
            play();
            

         static void play()
            { // start of play method
                Console.WriteLine("Te Reo Maori Quiz");
                Console.Write("Welcome!, please enter your name to start:  ");
                string name = Console.ReadLine();
                Menu(name);
            } // end of play method 

         static void Menu(string name)
            { // start of menu method, asking user the difficulty (easy, med, hard)
                Console.WriteLine($"\nHello {name}!");
                Console.Write("Choose a difficulty by choosing a number below;\n1.Easy\n2.Medium\n3.Hard\n4.Exit\nType here: ");
                int num = Convert.ToInt32(Console.ReadLine());
                {
                    if (num == 1)
                    {
                        Easy();
                    }
                    else if (num == 2)
                    {
                        Medium();
                    }
                    else if (num == 3)
                    {
                        Hard();
                    }
                    else if (num == 4)
                    {
                        Console.WriteLine("Goodbye!");
                    }
                    else
                        do //start of while loop(it is looped so if the user enters an option not in the list
                    { //this is to direct user to which difficulty he chose. 
                        Console.Write("Please enter a valid option: ");
                        num = Convert.ToInt32(Console.ReadLine());
                            if (num == 1)
                            {
                                Easy();
                            }
                            else if (num == 2)
                            {
                                Medium();
                            }
                            else if (num == 3)
                            {
                                Hard();
                            }
                            else if (num == 4)
                            {
                                Console.WriteLine("Goodbye!");
                            }
                            
                    } while (num != 1 && num != 2 && num != 3 && num != 4);
                } //end of menu method
            }
        }
        
        static void Easy()
        { // start of easy section
            Console.Clear();
            Console.WriteLine("Welcome to the Beginner's Quiz!");
            Console.WriteLine("This is a 10 question quiz of basic Maori langguange knowledge. You will have to choose from the options below of the best english word that describes the Maori word. Take your time and goodluck!");
            Console.WriteLine("\nPress enter to start quiz...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("question?");
            Console.WriteLine("a.111\nb.222\nc.333\n");
            Console.Write("Your answer: ");
            string answer = Console.ReadLine().ToUpper();



        } // end of easy section
        static void Medium()
        { // start of medium section
            Console.Clear();
            Console.WriteLine("Welcome to the Intermediate/Standard Quiz!");
        } // end of medium section
        static void Hard()
        { // start of hard section
            Console.Clear();
            Console.WriteLine("Welcome to the Expert's Quiz!");
        } // end of hard section
    }
}