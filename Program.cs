using System.ComponentModel.Design;

namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        { // start of menu method, asking user the difficulty
            Console.Clear();
            Console.WriteLine("Te Reo Maori Quiz");
            Console.Write("\nWelcome!\nPlease enter your name to start:  "); // \n to indent to next line
            string user_name = Console.ReadLine(); // stores name                                                                                                                                                
            Console.WriteLine($"\nHello {user_name}!");
            Console.Write("Choose a difficulty by choosing a number below;\n1.Easy\n2.Medium\n3.Hard\n4.Exit\nType here: ");
            string level = Console.ReadLine();                                                                                                                                             
            while (level != "1" && level != "2" && level != "3" && level != "4") // checks for invalid inputs
            {
                Console.Write("Please enter a valid option: ");
                level = Console.ReadLine();
            } // end of while loop                                                                                                                                                                                 
            string user_input = "", user_strAge = "17", user_country = "New Zealand", user_beloved = "Mom", user_fav_game = "Football";
            int user_age = 17;                                                                                                                                                        
            if (level == "1") // 
            {
                Console.Clear(); // level 1 (easy) intro
                Console.WriteLine("Welcome to the Beginner's Quiz!\n\nThis is a 10 question quiz about the basics of Maori languange. This test will test your knowledge of Moari \nVocabulary. You will have to choose from the options below of the best Maori translation of the english word \ngiven, choose the letter of the answer. Take your time and goodluck!\n\nPress any key to start ...");
                Console.ReadKey();                                                                                                                                                                      
                Console.Clear(); // OPTIONAL QUESTIONS PART
                Console.WriteLine("Just a few questions before we start the quiz, this is optional, so you don't have to answer these questions \nif you don't want to. Enter Y to ANSWER the question and N to SKIP..\n\nThe answers of these questions will be used all throughout the test to make it a little bit more fun and interactive.");                                                                                        
                Console.Write("\nHow old are you?"); // optional question 1
                user_strAge = OptionalQuestionsMethod(user_input);
                user_age = Convert.ToInt32(user_strAge);                                                                                                                                               
                Console.Write("\nWhat country are you from? : "); // question 2
                user_country = OptionalQuestionsMethod(user_input);                                                                                                                                          
                Console.Write("\nWho is a person you love? : "); // question 3
                user_beloved = OptionalQuestionsMethod(user_input);                                                                                                                                           
                Console.Write("\nWhat is your favorite game (videogame/sport) to play? : "); // question 4
                user_fav_game = OptionalQuestionsMethod(user_input);                                                                                                                            
                Console.WriteLine("\nPress any key to start the quiz...");
            }
            else if (level == "2")
            { 
                Console.Clear(); //level 2 (medium) intro
                Console.WriteLine("Welcome to the Intermediate/Standard Quiz!\n\nThis is a 10 question quiz, this no longer just makes you translate english words to Maori but it will now also test \nabout your general knowledge of Maori language. Choose the letter of the answer you think is correct, take your time \nand goodluck!\n\nPress any key to start...");
            }
            else if (level == "3")
            {
                Console.Clear(); //level 3 (hard) intro
                Console.WriteLine("Welcome to the Expert's Quiz!\n\nThis is a 10 question quiz, this will test your expertise on the Maori language, including it's history, mastery \nin the language, culture, peotry and the like. Choose the letter of the answer you think is correct, take your \ntime and goodluck!\n\nPress any key to continue...");
            }
            else if (level == "4")
            {
                Console.WriteLine("You exited... Press any key to restart.");
                Console.ReadKey();
                Main(args); // goes back to the start
            }
            Console.ReadKey();                                                                                                                                                                                      
            //EASY QUESTIONS AND ANSWERS
            string[] Easy_Questions = { "Which of the following Maori word translates to 'Hello!' ? \n\na. aloha!\nb. talofa!\nc. kia ora!", $"Which of the following Maori word/phrase translates to 'My name is...' ?\n\na. Ko toku ingoa {user_name}.\nb. Ko taku ingoa whānau ko {user_name}.\nc. Ko wai tou ingoa {user_name}.", "Which of the following Maori word/phrase translates to 'Good morning.' ?\n\na. Mōrena.\nb. Ahiahi marie.\nc. Po marie.", $"Which of the following Maori word/phrase translates to 'Happy Birthday!' ?\n\na. Hau`oli {user_age + 1}th la Hanau  {user_name}!\nb. hari {user_age + 1}th rā Whānau ki a Koe {user_name}!\nc. Āhea tō {user_age + 1}th rā whānau {user_name}!", $"Which of the following Maori word/phrase translates to 'I love you' ?\n\na. He aroha tāku mōku {user_beloved}.\nb. he aroha nui tāku mōu {user_beloved}. \nc. he pai ki a au te waehere {user_beloved}.", "Which of the following Maori word/phrase translates to 'family' ?\n\na. Whanau\nb. Kaitiaki\nc. Tapu", $"Which of the following Maori word/phrase translates to 'I live in...' ?\n\na. e ora ana ahau mo koe {user_country}.\nb. 'ou te nofo i {user_country}. \nc. E noho ana ahau i roto i {user_country}.", "What is the Maori name for New Zealand?\n\na. Aotearoa\nb. New Zealand\nc. Wharenui", $"Which of the following word/phrases translates to 'I am {user_age} years old.' ?\n\na. He {user_age} au makahiki.\nb. E {user_age} tau te pakeke. \nc.E {user_age} ou tausaga", $"Which of the following word/phrases translates to '{user_fav_game} is the worst game ever.' ?\n\na. Ko te {user_fav_game} te kai pai rawa atu.\nb. Ko te {user_fav_game} te keemu kino rawa atu. \nc. {user_fav_game} ole ta'aloga sili ona leaga." };
            string[] Easy_Answers = { "C", "A", "A", "B", "B", "A", "C", "A", "B", "B" }; //all answers in an array                                                                                         
            //MEDIUM QUESTIONS AND ANSWERS
            string[] Medium_Questions = { "How many letters are in the Maori alphabet?\n\na. 26\nb. 20\nc. 32", "How many people in New Zealand speak Maori?\n\na. 100,000\nb. 250,000\nc. 500,000", "What is a 'haka' in Maori culture?\n\na. A Maori greeting\nb. A type of Maori dance\nc. A traditional Maori tattoo", "Which of the following is not a color?\n\na. Kakariki'\nb. Panga\nc. Mawhero", "What is the name for the traditional Maori nose touching greeting?\n\na. Wharenui\nb. Haka\nc. Hongi", "How many vowels does the Maori language have?\n\na. 5\r\nb. 6\nc. 7", "What is the name for the Maori alphabet?\n\na. Te Taura Whiri\nb. Te Reo Maori\nc. Te Arapu Maori", "Which of the following is a Maori dialect?\n\na. Te Reo Pakeha\r\nb. Ngapuhi\nc. Tokelauan", "Which of the following is not a correct Maori word for a food item?\n\na. kumara\nb. pāua\nc. whare", "What is the name of the haka performed by the New Zealand national rugby team before matches?\n\na.Kapa Haka\nb. Ka Mare\nc. Haka Tuturu" };
            string[] Medium_Answers = { "C", "A", "B", "B", "C", "A", "C", "B", "C", "C" }; // all answers in an array                                                                                     
            //HARD QUESTIONS AND ANSWERS
            string[] Hard_Questions = { "What is the name for the Maori language commission?\n\na. Te Taura Whiri i te Reo Maori\nb. Te Papa Tongarewa\nc. Ngai Tahu", "What is the name of the Maori god of the sky?\n\na. Tane\nb. Tangaroa\nc. Rangi", "Which of the following is a Maori vowel?\n\na. /ei/\r\nb. /i/\r\nc. /ai/", "What is the name of the Maori war dance?\n\na. Haka Taparahi\nb. Haka Tuturu\nc. Haka Pohiri", "What is the name of the Maori ancestral canoe that is said to have brought the first Maori to New Zealand?\n\na. Aotea\nb. Tainui\nc. Kurahaupo", "Which Maori language dialect is spoken in the North Island of New Zealand?\n\na. Te Reo o Ngai Tahu\nb. Te Reo o Ngati Porou\nc. Te Reo o Ngati Whatua", "Which of the following is a common feature of Maori phonology?\n\na. Tone\nb. Final consonants\nc. Nasal vowels", "Which of the following is a correct translation for the Maori word 'tino rangatiratanga'?\n\na. Sovereignty and self-determination\nb. Wisdom and understanding\nc. Respect and honory", "Which of the following is the correct pronunciation for the Maori word 'karakia'?\n\na. kah-rah-kee-ah\nb. kah-rah-kyah\nc. kuh-rah-kyah", "What is the name for the Maori language revitalization program launched in 1982?\n\na. Te Aho Matua\nb. Te Reo Maori\nc. Kohanga Reo" };
            string[] Hard_Answers = { "A", "C", "B", "A", "B", "C", "A", "A", "A", "C" }; //all answers in an array                                                                                              
            string user_answer, correct_answers = "";
            int user_score = 0;
            const int QUESTION_VALUE = 1;                                                                                                                                                                           
            //FOR LOOP FOR QUIZ SYSTEM
            for (int i = 0; i < 10; i++) //displaying the questions to the user
            {
                Console.Clear();
                Console.WriteLine($"Your score: {user_score}/{i}\n\n"); // displays score out of the total numbers answers
                if (level == "1")
                {
                    Console.WriteLine($"Question {i + 1}:\n\n{Easy_Questions[i]}"); //i starts at 0 so it has +1 for question number
                    correct_answers = Easy_Answers[i]; // if the level is 1, the correct answers should be taken from Easy Quiz
                }
                if (level == "2") // if level equals to 2, it displays medium questions
                {
                    Console.WriteLine($"Question {i + 1}:\n\n{Medium_Questions[i]}");
                    correct_answers = Medium_Answers[i];
                }
                if (level == "3")
                {
                    Console.WriteLine($"Question {i + 1}:\n\n{Hard_Questions[i]}");
                    correct_answers = Hard_Answers[i];
                }                                                                                                                                                                                        
                Console.Write("\nType your answer here: ");
                user_answer = Console.ReadLine().ToUpper(); //toupper capitalises user input                                                                                                                
                while (user_answer != "A" && user_answer != "B" && user_answer != "C"); // looped as long as it doesn't match ABC
                {
                    Console.Write("Please input a valid answer: ");
                    user_answer = Console.ReadLine().ToUpper();
                } // end of                                                                                                                                                                                           
                if (user_answer == correct_answers) // if user_answer matches correct answer (true or false), it adds 1 point to user_score, add 1 to outof and tells user that they are correct
                {
                    user_score += QUESTION_VALUE; // question value is 1 set earlier
                    Console.WriteLine("\nYour answer was correct!");
                }
                else if (user_answer != correct_answers) // if user does not match the correct answer (true or false), it adds 1 to outof or the total so far, and tells user the correct answer
                    Console.WriteLine($"\nUnlucky the correct answer was {correct_answers}.");
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();
            } //end of for loop
            
            Console.Clear(); // quiz results
            Console.WriteLine($"You finished the quiz, nice job {user_name}!");
            Console.WriteLine($"\nYour score was {user_score}/10.");                                                                                                                                
            if (user_score >= 6) // if user_score greater than or equal to 6
                Console.WriteLine("Congratulations, you passed!");
            else if (user_score < 6) // if user_score less than 6
                Console.WriteLine("Unfortunately, you failed the quiz, better luck next time.");                                                                                                           
            Console.Write("\n\nDo you want to start another quiz? (Y or N): ");
            string retry = Console.ReadLine().ToUpper(); // converts to upper
            while (retry != "Y" && retry != "N"); // end of invalid checker
            {
                Console.Write("Please input a valid answer: ");
                retry = Console.ReadLine().ToUpper();
            }                                                                                                                                                                                               
            if (retry == "Y") // if Y it goes back to menu
                Main(args);
            else if (retry == "N") //if N it breaks = end
                Console.WriteLine("Thank you for taking the quiz, goodbye!");
        } // end of main method
        static string OptionalQuestionsMethod(string user_input)
        {
            Console.Write("\nDo you want to answer the question? (Y/N): ");
            string tempYN = Console.ReadLine().ToUpper();
            while (tempYN != "Y" && tempYN != "N");
            {
                Console.Write("Please input a valid answer: ");
                tempYN = Console.ReadLine().ToUpper();
            }                                                                                                                                                                                       
            switch (tempYN) // switch statement for user input
            {
                case "Y":
                    Console.Write("\nType your answer here: ");
                    user_input = Console.ReadLine();
                    break;
                case "N":
                    break;
            }
            return user_input;
        }
        /*static void Play()
        { // start of play method
            Console.WriteLine("Press any key to start...");
            Console.ReadKey(); //user can press any key
            Console.Clear(); //clears the console app
            Console.WriteLine("Te Reo Maori Quiz");
            Console.Write("\nWelcome!\nPlease enter your name to start:  "); // \n to indent to next line
            string user_name = Console.ReadLine();
            Menu(user_name);
        } // end of play method */

        /*string user_answer;
        int user_age;
            Console.Write("\nHow old are you? : ");
            string strAge = Console.ReadLine().ToUpper(); //ToUpper so that it capitalises user input
            if (strAge == "SKIP") //if user type skip, then default age is 17 (same goes for the rest)
                user_age = 17;
            else
                user_age = Convert.ToInt32(strAge);
            Console.Write("What country are you from? : ");
            string user_country = Console.ReadLine().ToUpper();
            if (user_country == "SKIP")
                user_country = "New Zealand";
            Console.Write("Who is a person you love? : ");
            string user_beloved = Console.ReadLine().ToUpper();
            if (user_beloved == "SKIP")
                user_beloved = "Mom";
            Console.Write("What is your favorite game (videogame/sport) to play? : ");
            string user_fav_game = Console.ReadLine().ToUpper(); 
            if (user_fav_game == "SKIP")
                user_fav_game = "Football";
            Console.WriteLine("\nPress any key to start the quiz...");
            Console.ReadKey();*/
        /*static void CorrectAnswerChecker(string user_answer)
        {
            if (user_answer == Hard_Answers[i]) // if user_answer matches correct answer (true or false), it adds 1 point to user_score, add 1 to outof and tells user that they are correct
            {
                user_score += QUESTION_VALUE;
                outof++;
                Console.WriteLine("\nYour answer was correct!");
            }
            else if (user_answer != Hard_Answers[i]) // if user does not match the correct answer (true or false), it adds 1 to outof or the total so far, and tells user the correct answer
            {
                outof++;
                Console.WriteLine($"\nUnlucky the correct answer was {Hard_Answers[i]}");
            }
        }*/
        // 
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
