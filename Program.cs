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
            var _messages = new Messages();
            
            bool gameOver = false;
            
            string hangManWord = "guess";
            string currentGuessedCharacter = string.Empty;
            string guessedCharacterList = string.Empty;
            List<char> guessedCharacters = new List<char>();

            char[] maskStartWord = new string('-', hangManWord.Length).ToCharArray();

            int triesMultiplier = 2;
            int guessingTries = hangManWord.Length * triesMultiplier;
            int violations = 0;


            Console.CursorVisible = false;

            //Messages.CallStartMessages();

            while (!gameOver)
            {
                currentGuessedCharacter = _messages.CallGameMessages(new string(maskStartWord),guessedCharacterList,guessingTries).ToLower();

                guessedCharacterList += currentGuessedCharacter[0] + ", ";

                if (currentGuessedCharacter.Length > 0)
                {
                    
                    guessedCharacterList += currentGuessedCharacter[0] + ", ";

                    if (guessedCharacters.Contains(currentGuessedCharacter[0]))
                    {
                        _messages.CallCharMessages();
                    }

                    guessedCharacters.Add(currentGuessedCharacter[0]);

                    if (currentGuessedCharacter.Length > 1)
                    {
                        if (violations >= 1)
                        {
                            guessingTries--;
                        }

                        _messages.CallViolationMessages();

                        violations++;
                    }

                    if (hangManWord.Contains(currentGuessedCharacter[0].ToString()))
                    {
                        for (int i = 0; i < hangManWord.Length; i++)
                        {
                            if (hangManWord[i] == currentGuessedCharacter[0])
                            {
                                maskStartWord[i] = currentGuessedCharacter[0];
                            }
                        }
                    }

                    guessingTries--;

                    if (guessingTries == 0)
                    {
                        gameOver = true;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(messages[1]);
                        Console.ResetColor();
                    }
                    else if (!new string(maskStartWord).Contains("-"))
                    {
                        gameOver = true;

                        Console.Clear();

                        Console.WriteLine("The word is {0}!", hangManWord.ToUpper());
                        Thread.Sleep(2000);

                        Console.Clear();

                        for (int i = flashing; i > 0; i--)
                        {
                            Console.WriteLine(messages[2]);
                            Thread.Sleep(500);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine(messages[2]);
                            Thread.Sleep(500);
                            Console.ResetColor();
                            Console.Clear();
                        }

                        Console.WriteLine(messages[2]);
                    }
                }

            }
            }
        }
    }
}
