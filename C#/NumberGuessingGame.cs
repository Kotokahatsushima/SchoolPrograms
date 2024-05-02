using System;
public class HelloWorld 
{
  public static void Main() 
  {
        Random rnd = new Random();
        //Random Number and guessed state initialization
        int randomized_number = rnd.Next(0, 100);
        bool guessed = false;

        //Runs while it's not yet guessed
        while (!(guessed))
        {
            Console.WriteLine("Enter your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            int difference;

            //Makes sure the difference is positive
            if(guess > randomized_number)
            {
                difference = guess - randomized_number;
            } 
            else 
            {
                difference = randomized_number - guess;
            }

            //Checks if input is guessed, very far, far or close
            if (guess == randomized_number)
            {
                guessed = true;
            }
            else if (difference > 20)
            {
                Console.WriteLine("It is very far");
            }
            else if (difference > 10)
            {
                Console.WriteLine("It is far");
            }
            else if (difference <= 10)
            {
                Console.WriteLine("It is close");
            }
        }

        //Main method recursion to play the game again
        Console.WriteLine("You guessed the right number. Do you want to play again? y/n");
        string inputResponse = Console.ReadLine();
        if(inputResponse == "y")
        {
            Main();
        }
    }
}