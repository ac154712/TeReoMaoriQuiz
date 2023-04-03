using Microsoft.VisualBasic;

namespace TeReoMaoriQuiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            Play();  
        }
        static void Play()
        { // start of play method
            Console.Clear();
            Console.WriteLine("Te Reo Maori Quiz");
            Console.Write("Welcome!, please enter your name to start:  ");
            string name = Console.ReadLine();
            Menu(name);
        } // end of play method 

        static void Menu(string name)
        { // start of menu method, asking user the difficulty
            Console.WriteLine($"\nHello {name}!");
            Console.Write("Choose a difficulty by choosing a number below;\n1.Easy\n2.Medium\n3.Hard\n4.Exit\nType here: ");
            string num = Console.ReadLine();


            do //checks for user invalid inputs
            {
                if (num != "1" && num != "2" && num != "3" && num != "4")
                {
                    Console.Write("Please enter a valid option: ");
                    num = Console.ReadLine();
                    if (num == "1" || num == "2" || num == "3" || num == "4")
                    {
                        break; //breaks the loop and goes to the next line
                    }
                }
            } while (num != "1" && num != "2" && num != "3" && num != "4");


            switch (num) //this is to direct user to which difficulty he chooses.
            {
                case "1":
                    Easy(name);
                    break;
                case "2":
                    Medium();
                    break;
                case "3":
                    Hard();
                    break;
                case "4":
                    Console.WriteLine("You exited... Press any key to start again.");
                    Console.ReadKey();
                    Play();
                    break;
            }
        }// end of menu method

        static void Easy(string name)
        { //start of easy quiz
            Console.Clear();
            Console.WriteLine("Welcome to the Beginner's Quiz!");
            Console.WriteLine("This is a 5 question quiz about the basics of Maori languange. This test will test your knowledge of Moari Vocabulary. You will have to choose from the options below of the best Maori translation of the english word given. Take your time\nand goodluck!");
            Console.WriteLine("\nPress any key to start ...");
            Console.ReadKey(); 

            Console.Clear();
            int age = 0;
            string beloved = "";
            Console.WriteLine("Just a few questions before we start the quiz, this is optional, so you don't have to answer these questions if you don't want to.");
            Console.WriteLine("The answers of these questions will be used all throughout the test to make it a little bit more fun and interactive.");
            Console.Write("\nHow old are you? : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Who do you love the most? : ");
            beloved = Console.ReadLine();
            Console.WriteLine("\nPress any key to start the quiz...");
            Console.ReadKey();

            string[] EasyQ = new string[5]; //all the easy questions in an array
            EasyQ[0] = "Which of the following Maori word translates to 'Hello!' ? \n\na. aloha!\nb. talofa!\nc. kia ora!";
            EasyQ[1] = $"Which of the following Maori word translates to 'My name is...' ?\n\na. Ko toku ingoa {name}.\nb. Ko taku ingoa whānau ko {name}.\nc. Ko wai tou ingoa {name}.";
            EasyQ[2] = "Which of the following Maori word translates to 'Good morning.' ?\n\na. Kia ora.\nb. Ata mārie.\nc. Mōrena.";
            EasyQ[3] = $"Which of the following Maori word translates to 'Happy Birthday!' ?\n\na. Hau`oli {age+1}th la Hanau  {name}!\nb. hari {age + 1}th rā Whānau ki a Koe {name}!\nc. Āhea tō {age + 1}th rā whānau {name}!";
            EasyQ[4] = $"Which of the following Maori word translates to 'I love you' ?\n\na. He aroha tāku mōku {beloved}\nb. he aroha nui tāku mōu {beloved} \nc. he pai ki a au te waehere {beloved}";

            string[] EasyA = new string[5];
            EasyA[0] = "C";
            EasyA[1] = "A";
            EasyA[2] = "A";
            EasyA[3] = "B";
            EasyA[4] = "B";
            //{ "C, A, A, B, B" };
            string answer;
            int score = 0, outof = 0;
            for (int i = 0; i < 5; i++) //displaying the questions to the user
            {
                Console.Clear();
                Console.WriteLine($"Your score: {score}/{outof}\n\n");
                Console.WriteLine($"Question {i + 1}:\n\n{EasyQ[i]}");
                Console.Write("\nType your answer here: ");
                answer = Console.ReadLine().ToUpper();

                do //checks for invalid inputs
                {
                    if (answer != "A" && answer != "B" && answer != "C")
                    {
                        Console.Write("Please input a valid answer: ");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "A" || answer == "B" || answer == "C")
                        {
                            break; //breaks the loop and goes to next line
                        }
                    }
                } while (answer != "A" && answer != "B" && answer != "C");

                if (answer == EasyA[i])
                {
                    score++;
                    outof++;
                    Console.WriteLine("\nYour answer was correct!");
                }
                else if (answer != EasyA[i])
                {
                    outof++;
                    Console.WriteLine($"\nUnlucky the correct answer was {EasyA[i]}\n");
                }
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();

            } //end of for loop

            // quiz results
            char retry = 'Y';
            Console.Clear();
            Console.WriteLine("You finished the Easy Quiz, nice job!");
            Console.WriteLine($"\nYour score was {score}/{outof}");
            if (score >= 3)
            {
                Console.WriteLine("Congratulations, you passed!");
            }
            else if (score < 3)
            {
                Console.WriteLine("Unfortunately, you failed the quiz, better luck next time.");
            }
            Console.WriteLine("\n\nDo you want to start another quiz? (Y or N): ");
            retry = Convert.ToChar(Console.ReadLine().ToUpper()); // converts to char and to upper

            do //checks for invalid inputs
            {
                if (retry != 'Y' && retry != 'N')
                {
                    Console.Write("Please input a valid answer: ");
                    answer = Console.ReadLine().ToUpper();
                    if (retry == 'Y' || retry == 'N')
                    {
                        break; //breaks the loop and goes to next line
                    }
                }
            } while (retry != 'Y' && retry != 'N');

            switch (retry)
            {
                case 'Y':
                    Menu(name);
                    break;
                case 'N':
                    break;
            }
        } //end of easy quiz

        static void Medium()
        { // start of medium quiz
            Console.Clear();
            Console.WriteLine("Welcome to the Intermediate/Standard Quiz!");
            Console.WriteLine("This no longer just makes the user translate english words to Maori but it will now also test about your general knowledge of Maori lunguage.");
        } // end of medium quiz

        static void Hard()
        { // start of hard quiz
            Console.Clear();
            Console.WriteLine("Welcome to the Expert's Quiz!");
        } // end of hard quiz


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

        /*if (i == 0) //Question 1
                {
                    switch (answer)
                    {
                        case "A":
                            outof++;
                            Console.WriteLine("\nNice try! The correct answer was C.\nNote: aloha! actually means 'Hello!' in Hawaian. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "B":
                            outof++;
                            Console.WriteLine("\nNice try! The correct answer was C.\nNote: talofa! actually means 'Hello!' in Samoan. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "C": //correct
                            score++;
                            outof++;
                            Console.WriteLine("\nYou are correct! \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                else if (i == 1) //Question 2
                {
                    switch (answer)
                    {
                        case "A": //correct
                            score++;
                            outof++;
                            Console.WriteLine("\nYou are correct, Goodjob! \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "B":
                            outof++;
                            Console.WriteLine("\nUnlucky, the correct answer was A. \nNote: 'ko taku ingoa whānau ko' actually means 'my surname is'. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "C":
                            outof++;
                            Console.WriteLine("\nUnlucky, the correct answer was A \nNote: 'Ko wai tou ingoa' actually means 'what is your name'. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                else if (i == 2)//Question 3 
                {
                    switch (answer)
                    {
                        case "A": //correct
                            outof++;
                            score++;
                            Console.WriteLine("\nCorrect! OMGGGG!!!.\nNote: All three choices are actually correct lol. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "B": //correct
                            score++;
                            outof++;
                            Console.WriteLine("\nCorrect! OMGGGG!!!.\nNote: All three choices are actually correct lol. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "C": //correct
                            score++;
                            outof++;
                            Console.WriteLine("\nCorrect! OMGGGG!!!.\nNote: All three choices are actually correct lol. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                else if (i == 3)//Question 4
                {
                    switch (answer)
                    {
                        case "A":
                            outof++;
                            Console.WriteLine("\nNice try! The correct answer was B.\nNote: 'Hau`oli la Hanau!' actually means 'Happy {age+1}th Birthday!' but in Hawaian. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "B": // correct
                            score++;
                            outof++;
                            Console.WriteLine("\nYou are correct, nice work!\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "C":
                            outof++;
                            Console.WriteLine($"\nNice try! The correct answer was B.\nNote: 'Āhea tō rā whānau!' actually means 'When is your {age+1}th birthday!' in Maori. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                else if (i == 4)//Question 5
                {
                    switch (answer)
                    {
                        case "A":
                            outof++;
                            Console.WriteLine("\nUnlucky, the correct answer was B.\nNote: 'He aroha tāku mōku' actually means 'I love me' in Maori. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "B": // correct
                            score++;
                            outof++;
                            Console.WriteLine("\nYou are correct, nice work!\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case "C":
                            outof++;
                            Console.WriteLine("\nUnlucky, the correct answer was B.\nNote: 'he pai ki a au te waehere' actually means 'I love coding' in Maori. \n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                } */
        //----------------------------- END OF EASY OLD CODE --------------------------------------
    }
}
