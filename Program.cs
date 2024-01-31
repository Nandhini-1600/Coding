// SWAP INDICES 
// Display random series of numbers to the user and ask them to provide two index values which need to be swapped and display the swapped result to the user.
// For example, 4 8 7 5 6 9 enter the index to be swapped: 2 3 outputs to be: 4 8 5 7 6 9. 
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Swap Indices</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Display random series of numbers to the user </summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Random random = new ();
         int[] numbers = new int[8];
         // Generate random numbers.
         for (int k = 0; k < numbers.Length; k++)
            numbers[k] = random.Next (1, 10);
         Console.WriteLine ("Original Numbers: " + string.Join (" ", numbers));
         Console.Write ("Enter two indices to swap (e.g., 2 3): ");
         var indices = Console.ReadLine ().Split(" ");
         if(indices.Length != 2) {
            Console.WriteLine ("Invalid input");
            return;
         }
         if(!int.TryParse (indices[0], out int a) || !int.TryParse (indices[1], out int b) || a < 0 || b < 0 || a > numbers.Length || b > numbers.Length) {
            Console.WriteLine ("Please provide valid index");
            return;
         }
         if(a == b) {
            Console.WriteLine ("Indices are same"); 
            return;
         }
         Console.WriteLine ("Swapped Numbers: " + SwapNumbers (numbers, a, b));
      }

      /// <summary>swapping the numbers using indices</summary>
      /// <param name="numbers">array of random numbers</param>
      /// <param name="index1">index 1</param>
      /// <param name="index2">index 2</param>
      /// <returns>swapped numbers</returns>
      static string SwapNumbers (int[] numbers, int index1, int index2) {
         int temp = numbers[index1];
         numbers[index1] = numbers[index2];
         numbers[index2] = temp;
         return string.Join (" ", numbers);
      }
      #endregion
   }
   #endregion
}
