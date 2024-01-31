// Reverse number guessing game(MSD TO LSD)
// System will display the number you guessed.
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Reverse number guessing game</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>insert the user to think a ramdom number 1 and 100 </summary>
      static void Main () {
         Console.WriteLine ("Welcome to the Guessing Game!");
         Console.WriteLine ("Think of a number between 1 and 100, and I will try to guess it.");
         int min = 1, max = 100, computerGuess;
         while (true) { // Infinite loop
            // The computer makes a guess in the middle of the current range
            computerGuess = (min + max) / 2;
            Console.Write ($"Is your number {computerGuess} ?((h)igh / (l)ow / (c)orrect): ");
            string userinput = Console.ReadLine ().ToLower ();
            if (userinput == "h") {
               min = computerGuess + 1; // Adjust the range according to the user input
               if (min > max) {
                  Console.WriteLine ("Invalid guess. Your guess can't be higher than 100.");
                  break;
               }
            } else if (userinput == "l") {
               max = computerGuess - 1; // Adjust the range according to the user input
               if (max < min) {
                  Console.WriteLine ("Invalid guess. Your guess can't be lower than 1.");
                  break;
               }
            } else if (userinput == "c") {
               Console.WriteLine ($"{computerGuess} is your guessed number.");
               break; // Exit the loop when the user input is "c"
            } else Console.WriteLine ("Invalid input");
         }
      }
      #endregion
   }
   #endregion
}
