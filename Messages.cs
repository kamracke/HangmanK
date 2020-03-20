using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading;

namespace HangmanK
{
    public class Messages
    {
        private string[] messages =
            {
            @" __    __       ___      .__   __.   _______ .___  ___.      ___      .__   __.
|  |  |  |     /   \     |  \ |  |  /  _____||   \/   |     /   \     |  \ |  |
|  |__|  |    /  ^  \    |   \|  | |  |  __  |  \  /  |    /  ^  \    |   \|  |
|   __   |   /  /_\  \   |  . `  | |  | |_ | |  |\/|  |   /  /_\  \   |  . `  |
|  |  |  |  /  _____  \  |  |\   | |  |__| | |  |  |  |  /  _____  \  |  |\   |
|__|  |__| /__/     \__\ |__| \__|  \______| |__|  |__| /__/     \__\ |__| \__|",

            @"  _______      ___      .___  ___.  _______      ______   ____    ____  _______ .______       __ 
 /  _____|    /   \     |   \/   | |   ____|    /  __  \  \   \  /   / |   ____||   _  \     |  |
|  |  __     /  ^  \    |  \  /  | |  |__      |  |  |  |  \   \/   /  |  |__   |  |_)  |    |  |
|  | |_ |   /  /_\  \   |  |\/|  | |   __|     |  |  |  |   \      /   |   __|  |      /     |  |
|  |__| |  /  _____  \  |  |  |  | |  |____    |  `--'  |    \    /    |  |____ |  |\  \----.|__|
 \______| /__/     \__\ |__|  |__| |_______|    \______/      \__/     |_______|| _| `._____|(__)",

            @"____    __    ____  __  .__   __. .__   __.  _______ .______      
\   \  /  \  /   / |  | |  \ |  | |  \ |  | |   ____||   _  \     
 \   \/    \/   /  |  | |   \|  | |   \|  | |  |__   |  |_)  |    
  \            /   |  | |  . `  | |  . `  | |   __|  |      /     
   \    /\    /    |  | |  |\   | |  |\   | |  |____ |  |\  \----.
    \__/  \__/     |__| |__| \__| |__| \__| |_______|| _| `._____|"
        };

        private string[] counting =
            {
            @" __ 
/_ |
 | |
 | |
 | |
 |_|",
            @" ___  
|__ \ 
   ) |
  / / 
 / /_ 
|____|",
            @" ____  
|___ \ 
  __) |
 |__ < 
 ___) |
|____/",
            @" _  _   
| || |  
| || |_ 
|__   _|
   | |  
   |_| ", @" _____ 
| ____|
| |__  
|___ \ 
 ___) |
|____/"
        };

        public void CallStartMessages()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();

            for (int i = counting.Length; i > 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(messages[0]);
                Console.WriteLine(counting[i - 1]);
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.ResetColor();
        }

        public string CallGameMessages(string maskStartWord, string guessedCharacterList, int guessingTries)
        {
            Console.Clear();
            Console.WriteLine("Guess the word: {0}", maskStartWord);
            Console.WriteLine("Guessed characters: {0}", guessedCharacterList);
            Console.WriteLine("You have {0} tries left.", guessingTries);
            Console.WriteLine();
            Console.Write("Your next guess is: ");

            return Console.ReadLine().ToString();
        }

        public void CallCharMessages()
        {
            Console.WriteLine("You already guessed this letter, try another!");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        public void CallViolationMessages()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOnly ONE single character allowed!");
            Console.WriteLine("You will lose 2 tries for each following violation of this rule.");
            Console.ResetColor();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}
