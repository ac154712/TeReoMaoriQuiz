using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Threading.Tasks.Sources;

namespace TeReoMaoriQuiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            play();


            static void play()
            { // start of play method
                Console.Clear();
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
                if (num == 1 || num == 2 || num == 3 || num == 4)
                { //this is to direct user to which difficulty he chose. 
                    switch (num)
                    {
                        case 1:
                            Easy(name);
                            break;
                        case 2:
                            Medium();
                            break;
                        case 3:
                            Hard();
                            break;
                        case 4:
                            Console.WriteLine("You exited... Press enter start again.");
                            Console.ReadLine();
                            play();
                            break;
                    }
                }
                else
                {
                    do //start of while loop(it is looped so if the user enters an option not in the list
                    { 
                        Console.Write("Please enter a valid option: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                Easy(name);
                                break;
                            case 2:
                                Medium();
                                break;
                            case 3:
                                Hard();
                                break;
                            case 4:
                                Console.WriteLine("You exited... Press enter to start again");
                                Console.ReadLine();
                                play();
                                break;
                        }

                    } while (num != 1 && num != 2 && num != 3 && num != 4);
                }
            }// end of menu method
        }

        static void Easy(string name)
        { // start of easy section
            Console.Clear();
            Console.WriteLine("Welcome to the Beginner's Quiz!");
            Console.WriteLine("This is a 5 question quiz about the basics of Maori languange. This test will test your knowledge of Moari Vocabulary. You will have to choose from the options below of the best Maori translation of the english word given. Take your time\nand goodluck!");
            Console.WriteLine("\nPress enter to start quiz...");
            Console.ReadLine(); //no variable so user just have to press enter

            //all the questions in an array
            string[] EasyQ = new string[5];
            EasyQ[0] = "Which of the following Maori word translates to 'Hello!' ? \n\na. aloha!\nb. talofa!\nc. kia ora!";
            EasyQ[1] = ($"Which of the following Maori word translates to 'My name is... (your name)' ?\n\na. Ko toku ingoa {name}\nb. ko taku ingoa whānau ko {name}\nc. Ko wai tou ingoa {name}\n");
            EasyQ[2] = "333";
            EasyQ[3] = "444";
            EasyQ[4] = "555";
        
            //displaying the questions to the user
            string answer;
            int Qnum = 1, score = 0, outof = 0; // Qnum is set so it starts with 1
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"Your score: {score}/{outof}\n\n");
                Console.WriteLine($"Question {Qnum}\n");
                Console.WriteLine(EasyQ[i]);
                Console.Write("\nType your answer here: ");
                answer = Console.ReadLine().ToUpper();

                if (i == 0) //Question 1
                {
                    switch (answer)
                    {
                        case "A":
                            Qnum++;
                            outof++;
                            Console.WriteLine("Nice try! The correct answer was C.\nNote: aloha! actually means Hello in Hawaian. Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "B":
                            Qnum++;
                            outof++;
                            Console.WriteLine("Nice try! The correct answer was C.\nNote: talofa! actually means Hello in Samoan. Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "C": //correct
                            Qnum++;
                            score++;
                            outof++;
                            Console.WriteLine("You are correct! \nPress enter to continue...");
                            Console.ReadLine();
                            break;
                    }
                }
                else if (i == 1) //Question 2
                {
                    switch (answer)
                    {
                        case "A": //correct
                            Qnum++;
                            score++;
                            outof++;
                            Console.WriteLine("You are correct! Goodjob. \nPress enter to continue...");
                            Console.ReadLine();
                            break;
                        case "B":
                            Qnum++;
                            outof++;
                            Console.WriteLine("Unlucky, the correct answer was A. \nNote: 'ko taku ingoa whānau ko' actually means 'my surname is'. Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case "C":
                            Qnum++;
                            outof++;
                            Console.WriteLine("Unlucky, the correct answer was A \nNote: 'Ko wai tou ingoa' actually means 'what is your name'. Press enter to continue...");
                            Console.ReadLine();
                            break;
                    }
                }
                else if (i == 2)//Question 3 
                {
                    
                }
                else if (i == 3)
                {

                }
                else if (i ==4)
                {

                }
                else
                {
                    do
                    {
                        if (answer != "A" || answer != "B" || answer != "C")
                        {
                            Console.Write("Please input a valid answer: ");
                            answer = Console.ReadLine();
                        }
                    } while (answer != "A" || answer != "B" || answer != "C");
                }
                    
            }


                //end of easy section

                // -----------------------------------OLD CODE OF EASY -----------------------------------

                /*switch(variable name)

              case variable:
                  what u want to run;
                  break;
              case variable
              */

                /*
                String[] answer = new string[10] ;
                int feedback = 0, Qnum = 0, i = 0, score = 0, outof = 0;

                //Question 1
                Console.Clear();
                Qnum++;
                Console.WriteLine($"Question {Qnum}");
                Console.WriteLine("\nWhich of the following Maori word translates to 'Hello!' ?");
                Console.WriteLine("a. aloha!\nb. talofa!\nc. kia ora!\n");
                Console.Write("Your answer: ");
                answer[i]= Console.ReadLine().ToUpper(); //To.Upper so if the user enters a small letter

                //if for user answer
                if (answer[i] == "A")
                {
                    feedback = 2; //2 means wrong
                    outof++;
                    i++;
                }
                else if (answer[i] == "B")
                {
                    feedback = 2; //2 means wrong
                    outof++;
                    i++;
                }
                else if (answer[i] == "C") //correct
                {
                    feedback = 1; //1 means correct
                    score++; //adding one point to the score
                    outof++; //out of is how many questions the user has answered so far
                    i++; //adding 1 so that the answer in the next question will be stored in answer[2] (second chunk of array)
                }

                do //if user inputs an invalid option
                    {
                        Console.WriteLine("Please enter a valid option: ");
                        answer[i] = Console.ReadLine().ToUpper();
                        if (answer[i] == "A")
                        {
                            feedback = 2;
                            outof++;
                            i++;
                        }
                        else if (answer[i] == "B")
                        {
                            feedback = 2;
                            outof++;
                            i++;
                        }
                        else if (answer[i] == "C")
                        {
                            feedback = 1; //1 means correct
                            score++; 
                            outof++; 
                            i++; 
                        }
                    } while (answer[i] != "A" || answer[i] != "B" || answer[i] != "C");

                //end of question 1

                //Question 2
                Console.Clear();


                if (feedback == 1) //if statement if the user got it correct or not
                {
                    Console.WriteLine("You were correct!");
                }
                else if (feedback == 2)
                {
                    Console.WriteLine("Unlucky, you got it wrong.");
                } //end of if

                Console.WriteLine($"Your score: {score}/{outof} ");
                Qnum++;

                //the actual question part
                Console.WriteLine($"\nQuestion {Qnum}");
                Console.WriteLine("Which of the following Maori word translates to 'My name is...' ?");
                Console.WriteLine("a. ko toku ingoa...\nb. ingoa waitohu...\nc. ko wai tou ingoa...\n");
                Console.Write("Your answer: ");
                answer[i] = Console.ReadLine().ToUpper();

                //if for user answer
                if (answer[i] == "A")
                {
                    feedback = 2; //2 means wrong
                    outof++;
                    i++;
                }
                else if (answer[i] == "B")
                {
                    feedback = 1; //1 means correct
                    score++; //adding one point to the score
                    outof++;
                    i++;
                }
                else if (answer[i] == "C")
                {
                    feedback = 2; //2 means worng
                    outof++; //out of is how many questions the user has answered so far
                    i++; //adding 1 so that the answer in the next question will be stored in answer[2] (second chunk of array)
                }

                do //if user inputs an invalid option
                {
                    Console.WriteLine("Please enter a valid option: ");
                    answer[i] = Console.ReadLine().ToUpper();
                    if (answer[i] == "A")
                    {
                        feedback = 2;
                        outof++;
                        i++;
                    }
                    else if (answer[i] == "B")
                    {
                        feedback = 1;
                        score++;
                        outof++;
                        i++;
                    }
                    else if (answer[i] == "C")
                    {
                        feedback = 2;
                        score++;
                        outof++;
                        i++;
                    }
                } while (answer[i] != "A" || answer[i] != "B" || answer[i] != "C");
                */

                //----------------------------- END OF EASY OLD CODE --------------------------------------


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