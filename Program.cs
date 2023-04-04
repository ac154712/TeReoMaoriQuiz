using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

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
                    Medium(name);
                    break;
                case "3":
                    Hard(name);
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
            Console.WriteLine("This is a 10 question quiz about the basics of Maori languange. This test will test your knowledge of Moari Vocabulary. You will have to choose from the options below of the best Maori translation of the english word given, choose the letter of the answer. Take your time\nand goodluck!");
            Console.WriteLine("\nPress any key to start ...");
            Console.ReadKey(); 

            Console.Clear();
            int age = 17;
            Console.WriteLine("Just a few questions before we start the quiz, this is optional, so you don't have to answer these questions if you don't want to. JUST TYPE SKIP TO SKIP THE QUESTION.");
            Console.WriteLine("\nThe answers of these questions will be used all throughout the test to make it a little bit more fun and interactive.");
            Console.Write("\nHow old are you? : ");
            string strAge = Console.ReadLine().ToUpper();
            if (strAge == "SKIP")
            {
                age = 17;
            }
            else
                age = Convert.ToInt32(strAge);
            Console.Write("\nWhat country are you from? : ");
            string country = Console.ReadLine().ToUpper();
            if (country == "SKIP")
            {
                country = "New Zealand";
            }
            Console.Write("\nWho is a person you love? : ");
            string beloved = Console.ReadLine().ToUpper();
            if (beloved == "SKIP")
            {
                beloved = "Jesus";
            }
            Console.Write("\nWhat is your favorite game to play? : ");
            string favGame = Console.ReadLine().ToUpper();
            if (favGame == "SKIP")
            {
                favGame = "Football";
            }
            Console.WriteLine("\nPress any key to start the quiz...");
            Console.ReadKey();

            string[] EasyQ = new string[10]; //all the easy questions in an array
            EasyQ[0] = "Which of the following Maori word translates to 'Hello!' ? \n\na. aloha!\nb. talofa!\nc. kia ora!";
            EasyQ[1] = $"Which of the following Maori word/phrase translates to 'My name is...' ?\n\na. Ko toku ingoa {name}.\nb. Ko taku ingoa whānau ko {name}.\nc. Ko wai tou ingoa {name}.";
            EasyQ[2] = "Which of the following Maori word/phrase translates to 'Good morning.' ?\n\na. Kia ora.\nb. Ata mārie.\nc. Mōrena.";
            EasyQ[3] = $"Which of the following Maori word/phrase translates to 'Happy Birthday!' ?\n\na. Hau`oli {age+1}th la Hanau  {name}!\nb. hari {age + 1}th rā Whānau ki a Koe {name}!\nc. Āhea tō {age + 1}th rā whānau {name}!";
            EasyQ[4] = $"Which of the following Maori word/phrase translates to 'I love you' ?\n\na. He aroha tāku mōku {beloved}.\nb. he aroha nui tāku mōu {beloved}. \nc. he pai ki a au te waehere {beloved}.";
            EasyQ[5] = "Which of the following Maori word/phrase translates to 'family' ?\n\na. Whanau\nb. Kaitiaki\nc. Tapu";
            EasyQ[6] = $"Which of the following Maori word/phrase translates to 'I live in...' ?\n\na. e ora ana ahau mo koe {country}.\nb. 'ou te nofo i {country}. \nc. E noho ana ahau i roto i {country}.";
            EasyQ[7] = "What is the Maori name for New Zealand?\n\na. Aotearoa\nb. New Zealand\nc. Wharenui";
            EasyQ[8] = $"Which of the following word/phrases translates to 'I am {age} years old.' ?\n\na. He {age} au makahiki.\nb. E {age} tau te pakeke. \nc.E {age} ou tausaga";
            EasyQ[9] = $"Which of the following word/phrases translates to '{favGame} is the word game ever.' ?\n\na. Ko te {favGame} te kai pai rawa atu.\nb. Ko te {favGame} te keemu kino rawa atu. \nc. {favGame} ole ta'aloga sili ona leaga.";

            string[] EasyA = { "C", "A", "A", "B", "B", "A", "C", "A", "B", "B"}; //all answers in an array

            string answer;
            int score = 0, outof = 0;
            for (int i = 0; i < 10; i++) //displaying the questions to the user
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
                    Console.WriteLine($"\nUnlucky the correct answer was {EasyA[i]}.");
                }
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();

            } //end of for loop

            // quiz results
            char retry = 'Y';
            Console.Clear();
            Console.WriteLine($"You finished the Easy Quiz, nice job {name}!");
            Console.WriteLine($"\nYour score was {score}/{outof}.");
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

        static void Medium(string name)
        { // start of medium quiz
            Console.Clear();
            Console.WriteLine("Welcome to the Intermediate/Standard Quiz!");
            Console.WriteLine("This no longer just makes the user translate english words to Maori but it will now also test about your general knowledge of Maori lunguage.");
            Console.WriteLine("\nPress any key to start...");
            Console.ReadKey();

            string[] MedQ = new string[10]; //all the easy questions in an array
            MedQ[0] = "How many letters are in the Maori alphabet?\n\na. 26\nb. 20\nc. 32";
            MedQ[1] = "How many people in New Zealand speak Maori?\n\na. 100,000\nb. 250,000\nc. 500,000";
            MedQ[2] = "What is a 'haka' in Maori culture?\n\na. A Maori greeting\nb. A type of Maori dance\nc. A traditional Maori tattoo";
            MedQ[3] = "Which of the following is not a color?\n\na. Kakariki'\nb. Panga\nc. Mawhero";
            MedQ[4] = "What is the name for the traditional Maori nose touching greeting?\n\na. Wharenui\nb. Haka\nc. Hongi";
            MedQ[5] = "How many vowels does the Maori language have?\n\na. 5\r\nb. 6\nc. 7";
            MedQ[6] = "What is the name for the Maori alphabet?\n\na. Te Taura Whiri\nb. Te Reo Maori\nc. Te Arapu Maori";
            MedQ[7] = "Which of the following is a Maori dialect?\n\na. Te Reo Pakeha\r\nb. Ngapuhi\nc. Tokelauan";
            MedQ[8] = "Which of the following is not a correct Maori word for a food item?\n\na. kumara\nb. pāua\nc. whare";
            MedQ[9] = "What is the name of the haka performed by the New Zealand national rugby team before matches?\n\na.Kapa Haka\nb. Ka Mare\nc. Haka Tuturu";

            string[] MedA = { "C", "A", "B", "B", "C", "A", "C", "B", "C", "C"}; // all answers in an array

            string answer;
            int score = 0, outof = 0;
            for (int i = 0; i < 10; i++) //displaying the questions to the user
            {
                Console.Clear();
                Console.WriteLine($"Your score: {score}/{outof}\n\n");
                Console.WriteLine($"Question {i + 1}:\n\n{MedQ[i]}");
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

                if (answer == MedA[i])
                {
                    score++;
                    outof++;
                    Console.WriteLine("\nYour answer was correct!");
                }
                else if (answer != MedA[i])
                {
                    outof++;
                    Console.WriteLine($"\nUnlucky the correct answer was {MedA[i]}.");
                }
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();
            } //end of for loop

            // quiz results
            char retry = 'Y';
            Console.Clear();
            Console.WriteLine($"You finished the Easy Quiz, nice job {name}!");
            Console.WriteLine($"\nYour score was {score}/{outof}.");
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
        } // end of medium quiz

        static void Hard(string name)
        { // start of hard quiz
            Console.Clear();
            Console.WriteLine("Welcome to the Expert's Quiz!");

            string[] HardQ = new string[10]; //all the easy questions in an array
            HardQ[0] = "What is the name for the Maori language commission?\n\na. Te Taura Whiri i te Reo Maori\nb. Te Papa Tongarewa\nc. Ngai Tahu";
            HardQ[1] = "What is the name of the Maori god of the sky?\n\na. Tane\nb. Tangaroa\nc. Rangi";
            HardQ[2] = "";
            HardQ[3] = "What is the name of the Maori war dance?\n\na. Haka Taparahi\nb. Haka Tuturu\nc. Haka Pohiri";
            HardQ[4] = "What is the name of the Maori ancestral canoe that is said to have brought the first Maori to New Zealand?\n\na. Aotea\nb. Tainui\nc. Kurahaupo";
            HardQ[5] = "Which Maori language dialect is spoken in the North Island of New Zealand?\n\na. Te Reo o Ngai Tahu\nb. Te Reo o Ngati Porou\nc. Te Reo o Ngati Whatua";
            HardQ[6] = "Which of the following is a common feature of Maori phonology?\n\na. Tone\nb. Final consonants\nc. Nasal vowels";
            HardQ[7] = "Which of the following is a correct translation for the Maori word 'tino rangatiratanga'?\n\na. Sovereignty and self-determination\nb. Wisdom and understanding\nc. Respect and honory";
            HardQ[8] = "Which of the following is the correct pronunciation for the Maori word 'karakia'?\n\na. kah-rah-kee-ah\nb. kah-rah-kyah\nc. kuh-rah-kyah";
            HardQ[9] = "What is the name for the Maori language revitalization program launched in 1982?\n\na. Te Aho Matua\nb. Te Reo Maori\nc. Kohanga Reo";

            string[] HardA = { "A", "C", "B", "A", "B", "C", "A", "A", "A", "C" }; //all answers in an array
            
            string answer;
            int score = 0, outof = 0;
            for (int i = 0; i < 10; i++) //displaying the questions to the user
            {
                Console.Clear();
                Console.WriteLine($"Your score: {score}/{outof}\n\n");
                Console.WriteLine($"Question {i + 1}:\n\n{HardQ[i]}");
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

                if (answer == HardA[i])
                {
                    score++;
                    outof++;
                    Console.WriteLine("\nYour answer was correct!");
                }
                else if (answer != HardA[i])
                {
                    outof++;
                    Console.WriteLine($"\nUnlucky the correct answer was {HardA[i]}");
                }
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();

            } //end of for loop

            // quiz results
            char retry = 'Y';
            Console.Clear();
            Console.WriteLine($"You finished the Easy Quiz, nice job {name}!");
            Console.WriteLine($"\nYour score was {score}/{outof}.");
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
