// SORT AND SWAP SPECIAL CHARACTERS 
// Given a character array A, along with special character S and sort order O (default order is Ascending)
// Print the sorted array by keeping the elements matching S to the last of the array.
// For example, Input=([a, b, c, a, c, b, d], a, “descending”) ;Output=d, c, c, b, b, a, a .
using System;
using System.Linq;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Sort and swap special character</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Getting inputs from user</summary>
      static void Main () {
         // Getting character from the user.
         char[] a = GetInput ("Enter the letters: ").ToCharArray ();
         // Getting special character to swap from the user.
         string s = GetInput ("Enter the special character: ");
         // Getting the sorting order from the user.
         while (true) {
            Console.Write ("Do you want to sort the character array in decending order: (y)es or (n)o: ");
            var sortOrder = Console.ReadKey ().Key;
            if (sortOrder == ConsoleKey.Y) {
               Console.Write ($"\nOutput: {SortWithSpecialChar (a, s, false)}");
               break;
            } else if (sortOrder == ConsoleKey.N) {
               Console.Write ($"\nOutput: {SortWithSpecialChar (a, s)}");
               break;
            } else Console.WriteLine ("\nInvalid key. Please enter y or n.");
         }
      }

      /// <summary>Provide valid input</summary>
      /// <param name="prompt">Comment for the user</param>
      /// <returns>Valid input</returns>
      static string GetInput (string prompt) {
         string result;
         while (true) {
            Console.Write (prompt);
            string input = Console.ReadLine ();
            if (!string.IsNullOrWhiteSpace (input) && input.All (char.IsLetter)) {
               result = input;
               break;
            } else Console.WriteLine ("Invalid input. Please enter alphabets only and make sure it's not empty.");
         }
         return result;
      }

      /// <summary>Sort the character array with special character</summary>
      /// <param name="a">Character array</param>
      /// <param name="s">Special character</param>
      /// <param name="ascending">Order</param>
      /// <returns>Sorted characters</returns>
      static string SortWithSpecialChar (char[] a, string s, bool ascending = true) {
         string output = "", splChar = "";
         // Split the char array from the special character and stores it in output and store the special character in specialchar.
         foreach (char c in a) {
            if (c != s[0]) output += c;
            else splChar += c;
         }
         // Sort the output based on the user input.
         output = ascending
          ? new string (output.OrderBy (c => c).ToArray ())
          : new string (output.OrderByDescending (c => c).ToArray ());
         // Join the output and remainingchar.
         output += splChar;
         return string.Join (", ", output.ToCharArray ());
      }
      #endregion
   }
   #endregion
}
