// REVERSE NUMBER GUESSING GAME (LSD TO MSD)
// Write the code for displaying the number you guessed.
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Reverse Guessing Game</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Insert the user to think a number between 1 and 100</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.WriteLine ("Welcome to guessing game.");
         Console.WriteLine ("Think a number between 1 and 100.");
         int rem = 0; string binary = "";
         for (int i = 1; i <= 7; i++) {
            // Initially reminder will be 0.
            Console.Write ($"Is the remainder {rem} when divided by {Math.Pow (2, i)}: (y)es or (n)o: ");
            ConsoleKeyInfo consoleKey = Console.ReadKey ();
            ConsoleKey userinput = consoleKey.Key;
            Console.WriteLine ();
            // Add binary number in the binary string.
            if (userinput == ConsoleKey.Y) binary = "0" + binary;
            else if (userinput == ConsoleKey.N) {
               binary = "1" + binary;
               // Reminder(rem) value will be changing based on user input.
               rem = Convert.ToInt32 (binary, 2);
            } else Console.WriteLine ("Invalid input");
         }
         Console.WriteLine ("The number in your mind is " + (rem) + ".");
      }
      #endregion
   }
   #endregion
}
