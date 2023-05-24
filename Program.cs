namespace TeReoMaoriQuiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
        { // start of menu method, asking user the difficulty
            Console.Clear();
            Console.WriteLine("Te Reo Maori Quiz");
            Console.Write("\nWelcome!\nPlease enter your name to start:  "); // \n to indent to next line
            string user_name = Console.ReadLine();
            Console.WriteLine($"\nHello {user_name}!");
            Console.Write("Choose a difficulty by choosing a number below;\n1.Easy\n2.Medium\n3.Hard\n4.Exit\nType here: ");
            string level = Console.ReadLine();

            do //checks for user invalid inputs
            {
                if (level != "1" && level != "2" && level != "3" && level != "4")
                {
                    Console.Write("Please enter a valid option: ");
                    level = Console.ReadLine();
                    if (level == "1" || level == "2" || level == "3" || level == "4")
                    {
                        break; //breaks the loop and goes to the next line
                    }
                }
            } while (level != "1" && level != "2" && level != "3" && level != "4");

            if (level == "4")
                    Console.WriteLine("You exited... Press any key to start again.");
                    Console.ReadKey();
                    Main();
            
            /*Console.Clear();
            Console.WriteLine("Welcome to the Beginner's Quiz!");
            Console.WriteLine("This is a 10 question quiz about the basics of Maori languange. This test will test your knowledge of Moari Vocabulary. You will have to choose from the options below of the best Maori translation of the english word given, choose the \nletter of the answer. Take your time and goodluck!");
            Console.WriteLine("\nPress any key to start ...");
            Console.ReadKey(); */

            Console.Clear();
            string user_input = "", user_strAge, user_country, user_beloved, user_fav_game;
            int user_age;
            Console.WriteLine("Just a few questions before we start the quiz, this is optional, so you don't have to answer these questions \nif you don't want to. Press enter to every question.");
            Console.WriteLine("\nThe answers of these questions will be used all throughout the test to make it a little bit more fun and interactive.");
            Console.Write("\nHow old are you?");
            user_strAge = OptionalQuestionsMethod(user_input);
            if (user_input == "default")
                user_age = 17;
            else
                user_age = Convert.ToInt32(user_strAge);
            Console.Write("\nWhat country are you from? : ");
            user_country = OptionalQuestionsMethod(user_input);
            if (user_input == "default")
                user_country = "New Zealand";
            Console.Write("\nWho is a person you love? : ");
            user_beloved = OptionalQuestionsMethod(user_input);
            if (user_input == "default")
                user_beloved = "Mom";
            Console.Write("\nWhat is your favorite game (videogame/sport) to play? : ");
            user_fav_game = OptionalQuestionsMethod(user_input);
            if (user_input == "default")
                user_fav_game = "Football";
            Console.WriteLine("\nPress any key to start the quiz...");
            Console.ReadKey();
                //EASY QUESTIONS AND ANSWERS
            string[] Easy_Questions = { "Which of the following Maori word translates to 'Hello!' ? \n\na. aloha!\nb. talofa!\nc. kia ora!", $"Which of the following Maori word/phrase translates to 'My name is...' ?\n\na. Ko toku ingoa {user_name}.\nb. Ko taku ingoa whānau ko {user_name}.\nc. Ko wai tou ingoa {user_name}.", "Which of the following Maori word/phrase translates to 'Good morning.' ?\n\na. Mōrena.\nb. Ahiahi marie.\nc. Po marie.", $"Which of the following Maori word/phrase translates to 'Happy Birthday!' ?\n\na. Hau`oli {user_age + 1}th la Hanau  {user_name}!\nb. hari {user_age + 1}th rā Whānau ki a Koe {user_name}!\nc. Āhea tō {user_age + 1}th rā whānau {user_name}!", $"Which of the following Maori word/phrase translates to 'I love you' ?\n\na. He aroha tāku mōku {user_beloved}.\nb. he aroha nui tāku mōu {user_beloved}. \nc. he pai ki a au te waehere {user_beloved}.", "Which of the following Maori word/phrase translates to 'family' ?\n\na. Whanau\nb. Kaitiaki\nc. Tapu", $"Which of the following Maori word/phrase translates to 'I live in...' ?\n\na. e ora ana ahau mo koe {user_country}.\nb. 'ou te nofo i {user_country}. \nc. E noho ana ahau i roto i {user_country}.", "What is the Maori name for New Zealand?\n\na. Aotearoa\nb. New Zealand\nc. Wharenui", $"Which of the following word/phrases translates to 'I am {user_age} years old.' ?\n\na. He {user_age} au makahiki.\nb. E {user_age} tau te pakeke. \nc.E {user_age} ou tausaga", $"Which of the following word/phrases translates to '{user_fav_game} is the worst game ever.' ?\n\na. Ko te {user_fav_game} te kai pai rawa atu.\nb. Ko te {user_fav_game} te keemu kino rawa atu. \nc. {user_fav_game} ole ta'aloga sili ona leaga." };
            string[] Easy_Answers = { "C", "A", "A", "B", "B", "A", "C", "A", "B", "B"}; //all answers in an array

            string user_answer;
            int user_score = 0, outof = 0;
            const int QUESTION_VALUE = 1;
            //FOR LOOP FOR QUIZ SYSTEM
            for (int i = 0; i < Easy_Questions.Length; i++) //displaying the questions to the user
            {
                Console.Clear();
                Console.WriteLine($"Your score: {user_score}/{outof}\n\n");
                    if (level == "1")
                        Console.WriteLine($"Question {i + 1}:\n\n{Easy_Questions[i]}"); //i starts at 0 so it has +1 for question number
                    else if (level == "2")
                        Console.WriteLine($"Question {i + 1}:\n\n{Medium_Questions[i]}");
                    else if (level == "3")
                        Console.WriteLine($"Question {i + 1}:\n\n{Hard_Questions[i]}");
                    Console.Write("\nType your answer here: ");
                user_answer = Console.ReadLine().ToUpper(); //toupper capitalises user input
                user_answer = ValidityChecker(user_answer); //validity checker method at the bottom

                if (user_answer == Easy_Answers[i]) // if user_answer matches correct answer (true or false), it adds 1 point to user_score, add 1 to outof and tells user that they are correct
                {
                    user_score += QUESTION_VALUE; // question value is 1 set earlier
                    outof++;
                    Console.WriteLine("\nYour answer was correct!");
                }
                else if (user_answer != Easy_Answers[i]) // if user does not match the correct answer (true or false), it adds 1 to outof or the total so far, and tells user the correct answer
                {
                    outof++;
                    Console.WriteLine($"\nUnlucky the correct answer was {Easy_Answers[i]}.");
                }
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();
            } //end of for loop

            // quiz results
            Console.Clear();
            Console.WriteLine($"You finished the Easy Quiz, nice job {user_name}!");
            Console.WriteLine($"\nYour score was {user_score}/{outof}.");
            if (user_score >= 6) // if user_score greater than or equal to 6
            {
                Console.WriteLine("Congratulations, you passed!");
            }
            else if (user_score < 6) // if user_score less than 6
            {
                Console.WriteLine("Unfortunately, you failed the quiz, better luck next time.");
            }
            Console.Write("\n\nDo you want to start another quiz? (Y or N): ");
            string retry = Console.ReadLine().ToUpper(); // converts to char and to upper
            retry = ValidityCheckerYN(retry); //method at bottom

            switch (retry) // if Y it goes back to menu, if N it breaks = end
            {
                case "Y":
                    Menu(user_name);
                    break;
                case "N":
                    Console.WriteLine("Thank you for taking the quiz, goodbye!");
                    break;
            }
        } //end of easy quiz

        static void Medium(string user_name)
        { // start of medium quiz
            Console.Clear();
            Console.WriteLine("Welcome to the Intermediate/Standard Quiz!");
            Console.WriteLine("This is a 10 question quiz, this no longer just makes you translate english words to Maori but it will now also test \nabout your general knowledge of Maori language. Choose the letter of the answer you think is correct, take your time \nand goodluck!"); // \n are used so the text outputted in the console looks clean
            Console.WriteLine("\nPress any key to start...");
            Console.ReadKey();

            string[] Medium_Questions = new string[10]; //all the easy questions in an array
            Medium_Questions[0] = "How many letters are in the Maori alphabet?\n\na. 26\nb. 20\nc. 32";
            Medium_Questions[1] = "How many people in New Zealand speak Maori?\n\na. 100,000\nb. 250,000\nc. 500,000";
            Medium_Questions[2] = "What is a 'haka' in Maori culture?\n\na. A Maori greeting\nb. A type of Maori dance\nc. A traditional Maori tattoo";
            Medium_Questions[3] = "Which of the following is not a color?\n\na. Kakariki'\nb. Panga\nc. Mawhero";
            Medium_Questions[4] = "What is the name for the traditional Maori nose touching greeting?\n\na. Wharenui\nb. Haka\nc. Hongi";
            Medium_Questions[5] = "How many vowels does the Maori language have?\n\na. 5\r\nb. 6\nc. 7";
            Medium_Questions[6] = "What is the name for the Maori alphabet?\n\na. Te Taura Whiri\nb. Te Reo Maori\nc. Te Arapu Maori";
            Medium_Questions[7] = "Which of the following is a Maori dialect?\n\na. Te Reo Pakeha\r\nb. Ngapuhi\nc. Tokelauan";
            Medium_Questions[8] = "Which of the following is not a correct Maori word for a food item?\n\na. kumara\nb. pāua\nc. whare";
            Medium_Questions[9] = "What is the name of the haka performed by the New Zealand national rugby team before matches?\n\na.Kapa Haka\nb. Ka Mare\nc. Haka Tuturu";

            string[] Medium_Answers = { "C", "A", "B", "B", "C", "A", "C", "B", "C", "C"}; // all answers in an array

            string user_answer;
            int user_score = 0, outof = 0;
            const int QUESTION_VALUE = 1;
            for (int i = 0; i < Medium_Questions.Length; i++) //displaying the questions to the user
            {
                Console.Clear();
                Console.WriteLine($"Your score: {user_score}/{outof}\n\n");
                Console.WriteLine($"Question {i + 1}:\n\n{Medium_Questions[i]}");
                Console.Write("\nType your answer here: ");
                user_answer = Console.ReadLine().ToUpper();
                user_answer = ValidityChecker(user_answer); //validity checker method at the bottom

                if (user_answer == Medium_Answers[i]) // if user_answer matches correct answer (true or false), it adds 1 point to user_score, add 1 to outof and tells user that they are correct
                {
                    user_score += QUESTION_VALUE;
                    outof++;
                    Console.WriteLine("\nYour answer was correct!"); 
                }
                else if (user_answer != Medium_Answers[i]) // if user does not match the correct answer (true or false), it adds 1 to outof or the total so far, and tells user the correct answer
                {
                    outof++;
                    Console.WriteLine($"\nUnlucky the correct answer was {Medium_Answers[i]}.");
                }
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();
            } //end of for loop

            // quiz results
            Console.Clear();
            Console.WriteLine($"You finished the Easy Quiz, nice job {user_name}!");
            Console.WriteLine($"\nYour score was {user_score}/{outof}.");
            if (user_score >= 6) // if user_score greater than or equal to 6, it tells user they passed
            {
                Console.WriteLine("Congratulations, you passed!");
            }
            else if (user_score < 6) // if user_score less than 6, it tells user they failed
            {
                Console.WriteLine("Unfortunately, you failed the quiz, better luck next time.");
            }
            Console.Write("\n\nDo you want to start another quiz? (Y or N): ");
            string retry = Console.ReadLine().ToUpper(); // converts to char and to upper
            retry = ValidityCheckerYN(retry); //method at bottom

            switch (retry) // if Y it goes back to menu, if N it breaks = end
            {
                case "Y":
                    Menu(user_name);
                    break;
                case "N":
                    Console.WriteLine("Thank you for taking the quiz, goodbye!");
                    break;
            }
        } // end of medium quiz

        static void Hard(string user_name)
        { // start of hard quiz
            Console.Clear();
            Console.WriteLine("Welcome to the Expert's Quiz!");
            Console.WriteLine("This is a 10 question quiz, this will test your expertise on the Maori language, including it's history, mastery \nin the language, culture, peotry and the like. Choose the letter of the answer you think is correct, take your \ntime and goodluck!");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            string[] Hard_Questions = new string[10]; //all the easy questions in an array
            Hard_Questions[0] = "What is the name for the Maori language commission?\n\na. Te Taura Whiri i te Reo Maori\nb. Te Papa Tongarewa\nc. Ngai Tahu";
            Hard_Questions[1] = "What is the name of the Maori god of the sky?\n\na. Tane\nb. Tangaroa\nc. Rangi";
            Hard_Questions[2] = "Which of the following is a Maori vowel?\n\na. /ei/\r\nb. /i/\r\nc. /ai/";
            Hard_Questions[3] = "What is the name of the Maori war dance?\n\na. Haka Taparahi\nb. Haka Tuturu\nc. Haka Pohiri";
            Hard_Questions[4] = "What is the name of the Maori ancestral canoe that is said to have brought the first Maori to New Zealand?\n\na. Aotea\nb. Tainui\nc. Kurahaupo";
            Hard_Questions[5] = "Which Maori language dialect is spoken in the North Island of New Zealand?\n\na. Te Reo o Ngai Tahu\nb. Te Reo o Ngati Porou\nc. Te Reo o Ngati Whatua";
            Hard_Questions[6] = "Which of the following is a common feature of Maori phonology?\n\na. Tone\nb. Final consonants\nc. Nasal vowels";
            Hard_Questions[7] = "Which of the following is a correct translation for the Maori word 'tino rangatiratanga'?\n\na. Sovereignty and self-determination\nb. Wisdom and understanding\nc. Respect and honory";
            Hard_Questions[8] = "Which of the following is the correct pronunciation for the Maori word 'karakia'?\n\na. kah-rah-kee-ah\nb. kah-rah-kyah\nc. kuh-rah-kyah";
            Hard_Questions[9] = "What is the name for the Maori language revitalization program launched in 1982?\n\na. Te Aho Matua\nb. Te Reo Maori\nc. Kohanga Reo";

            string[] Hard_Answers = { "A", "C", "B", "A", "B", "C", "A", "A", "A", "C" }; //all answers in an array
            
            string user_answer;
            int user_score = 0, outof = 0;
            const int QUESTION_VALUE = 1; // makes question worth 1 point
            for (int i = 0; i < Hard_Questions.Length; i++) //displaying the questions to the user
            {
                Console.Clear();
                Console.WriteLine($"Your score: {user_score}/{outof}\n\n");
                Console.WriteLine($"Question {i + 1}:\n\n{Hard_Questions[i]}");
                Console.Write("\nType your answer here: ");
                user_answer = Console.ReadLine().ToUpper();
                user_answer = ValidityChecker(user_answer); //validity checker method at the bottom

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
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadKey();
            } //end of for loop

            // quiz results
            Console.Clear();
            Console.WriteLine($"You finished the Easy Quiz, nice job {user_name}!");
            Console.WriteLine($"\nYour score was {user_score}/{outof}.");
            if (user_score >= 6) // if user_score greater than or equal to 6, it tells user they passed
            {
                Console.WriteLine("Congratulations, you passed!");
            }
            else if (user_score < 6) // if user_score less than 6, it tells user they failed
            {
                Console.WriteLine("Unfortunately, you failed the quiz, better luck next time.");
            }
            Console.Write("\n\nDo you want to start another quiz? (Y or N): ");
            string retry = Console.ReadLine().ToUpper(); // to upper capitalises user input
            retry = ValidityCheckerYN(retry); //method at bottom

            switch (retry) // if Y it goes back to menu, if N it breaks = end
            {
                case "Y":
                    Menu(user_name);
                    break;
                case "N":
                    Console.WriteLine("Thank you for taking the quiz, goodbye!");
                    break;
            }
        } // end of hard quiz
        static string ValidityChecker(string user_answer)
        {
            do //checks for invalid inputs
            {
                if (user_answer != "A" && user_answer != "B" && user_answer != "C")
                {
                    Console.Write("Please input a valid answer: ");
                    user_answer = Console.ReadLine().ToUpper();
                    if (user_answer == "A" || user_answer == "B" || user_answer == "C")
                    {
                        break; //breaks the loop and goes to next line
                    }
                }
            } while (user_answer != "A" && user_answer != "B" && user_answer != "C"); // looped as long as it doesn't match ABC
            return user_answer;
        }
        static string ValidityCheckerYN(string retry)
        {
            do //checks for invalid inputs
            {
                if (retry != "Y" && retry != "Y")
                {
                    Console.Write("Please input a valid answer: ");
                    retry = Console.ReadLine().ToUpper();
                    if (retry == "Y" || retry == "Y")
                    {
                        break; //breaks the loop and goes to next line
                    }
                }
            } while (retry != "Y" && retry != "N");
            return retry;
        }
        static string OptionalQuestionsMethod(string user_input)
        {
            Console.Write("\nAnswer the question? (Y/N): ");
            string tempYN = Console.ReadLine().ToUpper();
            do //checks for invalid inputs
            {
                if (tempYN != "Y" && tempYN != "N")
                {
                    Console.Write("Please input a valid answer: ");
                    tempYN = Console.ReadLine().ToUpper();
                    if (tempYN == "Y" || tempYN == "N")
                    {
                        break; //breaks the loop and goes to next line
                    }
                }
            } while (tempYN != "Y" && tempYN != "N");

            switch (tempYN)
            {
                case "Y":
                    Console.Write("\nType your answer here: ");
                    user_input = Console.ReadLine();
                    break;
                case "N":
                    user_input = "default";
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
