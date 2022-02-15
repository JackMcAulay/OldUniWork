using System;

class MasterMind
{
    private void PlayGame(int N, int M)
    {
        bool playGame = true;//bool value used to exit the while loop when the user wants to stop playing

        while (playGame)//loops until playGame is false
        {
            int[] paturn = new int[N];//creates an int array for the paturn to be stored in, using N for the number of positions in the array
            int[] history = new int[100];//creates an int array for the game history to be stored in
            int posInHistory = 0;//stores the position in the history array of the next free position 
            paturn = GenPaturn(N, M);//calls the GenPaturn method and stores it in the paturn array

            bool isSolved = false;//bool value used to exit the while loop when the user guesses the correct paturn

            while (!isSolved)//loops until isSolved is true
            {
                int[] userGuess = new int[N];//creates an int array for the users guess to be stored in, using N for the number of positions in the array
                userGuess = UserGuess(N);//calls the UserGuess method and stores it in the userGuess array

                int blackPegs = CheckPos(paturn, userGuess, N);//calls the CheckPos methid and stores the int value in blackPegs
                int whitePegs = CheckCol(paturn, userGuess, N);//calls the CheckCol methid and stores the int value in whitePegs
                Console.WriteLine($"\nBlack Pegs :{blackPegs}     White Pegs :{whitePegs}");//displays the values of the balck and white pegs

                for (int i = 0; i <= N - 1; i++)//itterates through the userGuess array
                {
                    history[posInHistory] = userGuess[i];//adds the value in the array to the history
                    posInHistory++;//increment posInHistory by one
                }

                Console.WriteLine("\nGuess History : ");//displays the values of the balck and white pegs
                for (int i = 0; i <= history.Length - 1; i++)//itterates through the history array
                {
                    if (history[i] == 0)//if the value in the array is 0
                    {
                        Console.WriteLine("\n");//add a new line
                        break;//exit the for loop, as it is the end of the items stored in the history
                    }

                    Console.Write($"{history[i]}");//display the value in the history array at position i

                    if ((i + 1) % N == 0 && history[i + 1] != 0)//adds a dash in between each guess using mod, a dash is not added if it is the last guess stored in the history
                    {
                        Console.Write(" - ");
                    }
                }

                if (blackPegs == N && whitePegs == N)//checks if the guess is correct
                {
                    Console.WriteLine("Well Done! You guessed the Paturn!");//displays game won message
                    isSolved = true;//sets is solved to true to exitr the while loop
                }
            }

            Console.WriteLine("\nWould you like to play again? (y/n) : ");
            string playAgain = Console.ReadLine();//asks the user if they want to play again
            if (playAgain.ToLower() != "y")//is the responce is not a y
            {
                playGame = false;//play game is set to false to exit the while loop
            }
        }
        Console.WriteLine("\nBye.");
        Console.ReadKey();
    }

    private int[] GenPaturn(int N, int M)//for generating the random paturn for the user to guess
    {
        int[] paturn = new int[N];//creates an int array for the paturn to be stored in, using N for the number of positions in the array
        Random r = new Random();//for creating a random number

        for (int i = 0; i <= N - 1; i++)//itterates though the array to add a number at eac position
        {
            int num = r.Next(1, M + 1);//generates the random number
            paturn[i] = num; //assigns the position in the array the generated random number
        }
            
        return paturn;//returns the paturn as an int array
    }

    private int[] UserGuess(int N)//for taking the users guess and turing it into an array
    {
        bool isValid = false;//bool value to used to exit the while loop if the users guess is valid
        string guess = "";//stores the users guess
        int[] paturn = new int[N]; //creates an int array for the users guess to be stored in

        while (!isValid)//while loop which ends when the user has entered a valid guess
        {
            Console.WriteLine($"\nMake A Guess of the Paturn (with {N} positions, 1 to {N}) (e.g. 1243, 3223) :");
            guess = Console.ReadLine();//takes the users input and stores it in the guess string

            if (guess.Length != N)//checks the length of the string to see if it is valid
            {
                Console.WriteLine($"Invalid Guess.");//error message displayed if the guess is invalid
            }
            else
            {
                isValid = true;//chages the bool value to exit the while loop
            }
        }

        for (int i = 0; i <= N - 1; i++)//itterates through the guess string
        {
            paturn[i] = Convert.ToInt32(guess[i]) - 48;//adds a value from the string into the array
        }

        return paturn;//returns the paturn as an int array
    }

    private int CheckPos(int[] paturn, int[] userGuess, int N)//checks if the corect colour pegs are in the correct location, adding a black peg for each correct one
    {
        int blackPegs = 0;//blackPegs set to 0

        for (int i = 0; i <= N - 1; i++)//itterates through the both arrays (paturn and userGuess)
        {
            if (paturn[i] == userGuess[i])//compairs the values in each array
            {
                blackPegs++;//if they match increment balckPegs by one
            }
        }

        return blackPegs;//returns the number of black pegs as an integer
    }

    private int CheckCol(int[] paturn, int[] userGuess, int N)//checks if the user has selected the correct colour of pegs
    {
        int whitePegs = 0;//whitePegs set to 0

        for (int i = 0; i <= N - 1; i++)//itterates through the paturn array
        {
            for (int j = 0; j <= N - 1; j++)//itterates through the userGuess array
            {
                if (paturn[i] == userGuess[j])//compairs the values in each array
                {
                    whitePegs++;//if they match increment balckPegs by one
                    break;//breaks the loop to prevent adding to many white pegs, if there is multiple of the same colour
                }
            }
        }

        return whitePegs;//returns the number of white pegs as an integer
    }

    static void Main(string[] args)
    {
        MasterMind Mastermind = new MasterMind();

        Console.WriteLine("Welcome to Mastermind. Please enter the number of positions and colours for your games.\n");

        Console.WriteLine("Positions :");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Colours :");
        int M = Convert.ToInt32(Console.ReadLine());

        Mastermind.PlayGame(N, M);
    }
}

