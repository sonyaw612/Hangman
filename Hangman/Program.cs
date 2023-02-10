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
        int counter = 0;
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
                // update word
            
            // TO-DO LIST:
            // check if word is completed or counter has run out
            // ToUpper all characters

            Console.WriteLine(string.Join("", correctChars));
            Console.WriteLine("Guess a letter!");
            char tempChar = char.Parse(Console.ReadLine());
            // bool charSuccess = char.TryParse(Console.ReadLine(), out char value);
            
            if(guessedChars.ToString().IndexOf(tempChar) == -1){ //  the user has not guessed this character before
                Console.WriteLine("New character inserted");
                guessedChars.Append(tempChar);  
                
                if(word.IndexOf(tempChar) == -1) { // if character is not in the word
                    counter++;
                    Console.WriteLine("Try again D:");
                    continue;
                }
                else{
                    for(int i = 0; i < word.Length; i++) { // if character is in the word, we loop through the word
                        if(word[i] == tempChar) {
                            correctChars[i] = tempChar;
                        }
                    }
                }
            }
            else{
                    Console.WriteLine("You've tried that!");
            }


        }
    }


}