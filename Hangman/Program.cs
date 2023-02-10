using System;

public class Hangman {

    public static void Main(string[] args){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("H A N G M A N");
        Console.WriteLine("=X=X=X=X=X=X=");
        int tries = 0;
        int maxTries = 7;
        Console.ForegroundColor = ConsoleColor.White;
        
        string wordToGuess = "Halloween";
        string[] wrongGuesses = new string[maxTries];
        string rightguesses = "";

        while(tries < maxTries) {
            //Console.WriteLine($"Wrong guesses: {wrongGuesses.ToString()}");
            Console.WriteLine("Wrong guesses: {0}", string.Join(", ", wrongGuesses));

            Console.Write("WORD: ");
            
            foreach(char letter in wordToGuess) {
                if (rightguesses.Contains(letter.ToString())) {
                    Console.Write(letter);
                }else {
                    Console.Write("_");
                }
            }
            Console.WriteLine("\nEnter your guess:");
            string currentGuess = Console.ReadLine();

            if (rightguesses.Contains(currentGuess) || wrongGuesses.Contains(currentGuess)) {
                Console.WriteLine("You've already guessed that letter! Try a different one.");
            }else if( wordToGuess.Contains(currentGuess)){
                rightguesses += currentGuess;
            } else {
                wrongGuesses[tries] = currentGuess;
                tries++;
                continue;
            }

            if (rightguesses.Length.Equals(wordToGuess.Distinct().Count())){
                break;
            }
        }
        if (tries >= 7) {
            Console.WriteLine("You've hanged someone!!");
        } else {
            Console.WriteLine("You guessed the right word!");
        }

    }

    


}
