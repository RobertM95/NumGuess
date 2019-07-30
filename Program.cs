using System;
//test
// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            Game();
        }
        static void Game()
        {
            while (true)
            {
                // init Correct number
                //int correctNum = 5;

                //create a new random object
                Random random = new Random();

                // add function to edit the numbers of the randomization.
                int correctNum = random.Next(1, 20);

                // init guess var 
                int guess = 0;

                // ask user for number#
                Console.WriteLine("Guess a number between 1 and 20");

                // while guess is not correct
                while (guess != correctNum)
                {
                    //get users input
                    string input = Console.ReadLine();


                    // checks the input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        ChangeColour(ConsoleColor.Red, "That is not a Number!");

                        // keep going
                        //continue;
                        //Thanks Robert:)
                    }


                    // Cast to int and put into guess variable
                    guess = Int32.Parse(input);

                    if (guess > 20 || guess < 1)
                    {
                        Console.WriteLine("You must be between numbers 1 and 20");

                        continue;
                    }

                    if (guess != correctNum)
                    {

                        ChangeColour(ConsoleColor.Red, "Wrong number, Try again!");
                    }
                }

                //output success message

                ChangeColour(ConsoleColor.DarkYellow, "Congratulations! you guessed the correct number!");

                // does the user want to play again

                PlayAgain();

                // Get users answer
            }
        }

        static void GetAppInfo()
        {
            //string name = "Test Name";
            //int Num = 21;
            //float Float = 1.5f;
            //bool Status = true;

            // Start code here //
            //Console.WriteLine(name);
            //Console.WriteLine("{0} is {1}", name, Num);

            //Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Robert";

            //  Change text colour
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset colour back to default
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // ask users name 
            Console.WriteLine("What is your name?");

            // get user input
            string name = Console.ReadLine();

            // print out welcome with users name 
            Console.WriteLine("Hello {0}, lets play a game...", name);

        }

        static void ChangeColour(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            //Prints out that the input is not a number
            Console.WriteLine(message);
            //Resets colour
            Console.ResetColor();
        }




        static void PlayAgain()
        {
            string answer;

                //answer != "Y" && answer != "N"
            while (true)
            {
                Console.WriteLine("Play Again? [Y] or [N]");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y" || answer == "N")
                {
                    break;
                }
                else Console.WriteLine("That is not an option!");
            }

            if (answer == "Y")
            {

                Console.WriteLine("OK, Here we go!");
                Game();
            }
            else if (answer == "N")
            {
                Console.WriteLine("Thank you for playing!");
                GameEnd();
             
            }
        }

        static void GameEnd()
        {
            Environment.Exit(0);
        }
    }
}

    