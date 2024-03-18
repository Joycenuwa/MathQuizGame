using System;



class Program
{
    private static int correctAnswer;

    static public void Level2()
    {
        Console.WriteLine();
        Console.WriteLine("1. This level is a little hard, but I trust you can do this:");
        Console.WriteLine("2 as it is a mixture of all mathematical Operators");
        Console.WriteLine();

        bool intIsGood = false;
        int numberofQuestions = 0;
        Console.WriteLine("How many question would you like to answer in this level?");

        do
        {
            if (int.TryParse(Console.ReadLine(), out var numofQues))
            {
                numberofQuestions = numofQues;
                intIsGood = true;
            }
            else
            {
                Console.WriteLine("Enter a valid integer value");
            }
        } while (!intIsGood);
        Console.WriteLine();
        Console.WriteLine("Press ENTER to Start the Quiz\n");
        Console.ReadKey();

        int score = 0;

        for (int numberofQuestionsLeft = 1; numberofQuestionsLeft <= numberofQuestions; numberofQuestionsLeft++)
        {
            Random generator = new Random();

            int randomNumber1 = generator.Next(10, 20);
            int randomNumber2 = generator.Next(0, 9);
            string[] mathOperators = { "x", "/", "+", "-" };

            bool intIsGood1 = false;
            int answer = 0;
            Random mathOperatorsGenerator = new Random();
            string operation = (mathOperators[generator.Next(0, mathOperators.Length)]);
            Console.WriteLine($"{randomNumber1} {operation} {randomNumber2} = ");
           do
            {
                if (int.TryParse(Console.ReadLine(), out var ans))
                {
                    answer = ans;
                    intIsGood1 = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid integer value");
                }
            } while (!intIsGood1);
            
            switch (operation)
            {
                case "+":
                    correctAnswer = randomNumber1 + randomNumber2;
                    break;
                case "-":
                    correctAnswer = randomNumber1 - randomNumber2;
                    break;
                case "x":
                    correctAnswer = randomNumber1 * randomNumber2;
                    break;
                case "/":
                    correctAnswer = randomNumber1 / randomNumber2;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            } 
            
            if (answer == correctAnswer)
            {
                Random scoreResponseGenerator = new Random();

                ++score;
                Console.ForegroundColor = ConsoleColor.Green;
                int scoreResponseIndex = scoreResponseGenerator.Next(0, 7);
                string[] scoreResponse = { "Correct!", "That's brilliant!", "Great!", "Excellent!", "Accurate!", "Good Job!", "Keep it up!" };
                Console.WriteLine(scoreResponse[scoreResponseIndex]);
                Console.WriteLine("Your score is: " + score);

                Console.ResetColor();
            }


            else
            {
                Random scoreResponseGenerator1 = new Random();
                Console.ForegroundColor = ConsoleColor.Red;
                int scoreResponseIndex1 = scoreResponseGenerator1.Next(0, 4);
                string[] scoreResponse = { "Incorrect!", "Relax, You can do this!", "Come on, You've got this!", "Wrong!" };
                Console.WriteLine(scoreResponse[scoreResponseIndex1]);
                Console.WriteLine("The answer is " + correctAnswer);

                Console.ResetColor();
            }

            Console.WriteLine("You have answered " + numberofQuestionsLeft + " out of " + numberofQuestions + " questions");
            Console.WriteLine();

            if (numberofQuestionsLeft == numberofQuestions)
            {
                if (score == numberofQuestions)
                {
                    Console.WriteLine("Congratulations! You got all questions correctly");
                }
                else
                {
                    Console.WriteLine("you got " + score + " of " + numberofQuestions + " questions correctly ");
                    Console.WriteLine("Thanks for playing! Bye! ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
    static public bool TryAgain()
    {
        Console.WriteLine("Welcome to JODE Math Quiz competition\n");
        Console.WriteLine("Instructions: \n1 You are allowed to choose the number of questions you would like to answer in this level");
        Console.WriteLine("2 You must answer all questions correctly to move to the next level\n3 Your score will be displayed as you proceed ");
        Console.WriteLine("4 If your score is less than the total questions answered,You will be asked to attempt quiz again or quit playing");
        Console.WriteLine("5 This is to test how well you know your multiplication table ");
        Console.WriteLine();
        Console.WriteLine("Please enter your name: ");
        string name = (Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hello " + name + "\n");

        bool intIsGood = false;
        int numberofQuestions = 0;
        Console.WriteLine("How many question would you like to answer?");

        do
        {
            if (int.TryParse(Console.ReadLine(), out var numofQues))
            {
                numberofQuestions = numofQues;
                intIsGood = true;
            }
            else
            {
                Console.WriteLine("Enter a valid integer value");
            }
        } while (!intIsGood);

        Console.WriteLine("Press ENTER to Start the Quiz\n");
        Console.ReadKey();

        int score = 0;

        for (int numberofQuestionsLeft = 1; numberofQuestionsLeft <= numberofQuestions; numberofQuestionsLeft++)
        {
            Random generator = new Random();

            int randomNumber1 = generator.Next(1, 12);
            int randomNumber2 = generator.Next(1, 10);

            bool intIsGood1 = false;
            int answer = 0;

            Console.WriteLine(randomNumber1 + " times " + randomNumber2 + " = ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out var ans))
                {
                    answer = ans;
                    intIsGood1 = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid integer value");
                }
            } while (!intIsGood1);
            int correctAnswer = randomNumber1 * randomNumber2;

            if (answer == correctAnswer)
            {
                Random scoreResponseGenerator = new Random();

                ++score;
                Console.ForegroundColor = ConsoleColor.Green;
                int scoreResponseIndex = scoreResponseGenerator.Next(0, 7);
                string[] scoreResponse = { "Correct!", "That's brilliant!", "Great!", "Excellent!", "Accurate!", "Good Job!", "Keep it up!" };
                Console.WriteLine(scoreResponse[scoreResponseIndex]);
                Console.WriteLine("Your score is: " + score);

                Console.ResetColor();
            }


            else
            {
                Random scoreResponseGenerator1 = new Random();
                Console.ForegroundColor = ConsoleColor.Red;
                int scoreResponseIndex1 = scoreResponseGenerator1.Next(0, 4);
                string[] scoreResponse = { "Incorrect!", "Relax, You can do this!", "Come on, You've got this!", "Wrong!" };
                Console.WriteLine(scoreResponse[scoreResponseIndex1]);
                Console.WriteLine("The answer is " + correctAnswer);

                Console.ResetColor();
            }

            Console.WriteLine("You have answered " + numberofQuestionsLeft + " out of " + numberofQuestions + " questions");
            Console.WriteLine();

            // At the end of a quiz
            if (numberofQuestionsLeft == numberofQuestions)
            {
                if (score == numberofQuestions)
                {
                    Console.WriteLine("Congratulations! You got all questions correctly");
                    Console.WriteLine("You are now qualified to participate in Level two game ");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to proceed to level 2");
                    Console.ReadKey();

                    do
                    {
                        Level2();
                    } while (true);
                }
                else
                {
                    Console.WriteLine("you got " + score + " of " + numberofQuestions + " questions correctly ");
                    Console.WriteLine("Do you want to Try again? ");
                    Console.WriteLine("Enter T to try again, any other key to quit: ");
                    string tryAgainResponse = Console.ReadLine().ToUpper();

                    if (tryAgainResponse == "T")
                        return true;

                    Environment.Exit(0);
                    // Code to Exit the application.
                    // https://stackoverflow.com/questions/10286056/what-is-the-command-to-exit-a-console-application-in-c
                    // Accessed on 7/1/2023

                }
            }
        }
        return false;
    }
    static void Main()
    {
        do
        {
            TryAgain();
        }
        while (true);

    }

}




