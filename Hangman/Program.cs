/*
VARIABLES:
string1: for the word to be guessed
string2: true/false string ("001101")

int counter: how many tries they have left

METHODS:
update string2()
update string1()
display progress()
check if they won or not (ran out of tries or they guessed the whole word)

*/

using System.Text;

class Hangman {
    public static void Main(string[] args) {
        string word = "Halloween";
        char[] correctChars = new char[word.Length];    // array of characters that user got right
        Array.Fill(correctChars, '_');

        StringBuilder guessedChars = new StringBuilder("", word.Length); // characters that user input

        bool unsolved = true;
        while(true) {
            // prompt the user for a char, get first char incase they typed a word or etc.
            // check if they attempted that char
            // if they have, repeat ( continue)
            // if not check against word:
                // reduce counter
                // update word and tf word


                // check progress()
            Console.WriteLine("Guess a letter!");
            char tempChar = char.Parse(Console.ReadLine());
            // bool charSuccess = char.TryParse(Console.ReadLine(), out char value);
            
            if(guessedChars.ToString().IndexOf(tempChar) == -1){
                Console.WriteLine("New character inserted");
            }
            break;

        }
    }


}