using System;
using System.Collections.Generic;
//using HangmanK.Messages;
using System.Threading;

namespace HangmanK
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            
            string hangManWord = "guess";
            string currentGuessedCharacter = string.Empty;
            string guessedCharactersList = string.Empty;

            char[] maskStartWord = new string('-', hangManWord.Length).ToCharArray();

            int triesMultiplier = 2;
            int guessingTries = hangManWord.Length * triesMultiplier;
            //int violations = 0;


            Console.CursorVisible = false;

            Messages.CallStartMessages();

            while (!gameOver)
            {
                Messages.CallGameMessages();

                currentGuessedCharacter = Console.ReadLine().ToString();
                guessedCharactersList += currentGuessedCharacter[0] + ", ";

                gameOver = true;
            }
        }
    }
}
