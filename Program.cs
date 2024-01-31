// STRING PERMUTATIONS
// Generate all string character permutations. 
// For example, Input: "NOT", Output: "NOT NTO ONT OTN TNO TON" 
using System;
using System.Collections.Generic;
using System.Text;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>String permutations </summary>
   internal class Program {
      #region Methods ---------------------------------------------

      public static List<string> result = new List<string> ();
      /// <summary>Getting input from the user </summary>
      static void Main () {
         Console.Write ("Enter the input:");
         Permute (Console.ReadLine ()!);
         Console.Write ("Output: \n");
         //print each and every element in the list
         foreach (string permutation in result)
            Console.WriteLine (permutation);
         Console.WriteLine ($"Number of permuted elements {result.Count}");//display count of the  permuted elements
      }
      /// <summary>input permutations</summary>
      /// <param name="str">input</param>
      static void Permute (string str) => PermuteHelper (str.ToCharArray (), 0, str.Length - 1);

      /// <summary>permute the input using swap</summary>
      /// <param name="strArray"> char array of input</param>
      /// <param name="left">select element based on index</param>
      /// <param name="right">select element based on index</param>
      static void PermuteHelper (char[] strArray, int left, int right) {
         if (left == right)
            result.Add (new string (strArray));//add the permuted output to the list
         else {
            for (int i = left; i <= right; i++) {
               Swap (ref strArray[left], ref strArray[i]);//swapping the letters based on indecise
               PermuteHelper (strArray, left + 1, right);//calling the function again
               Swap (ref strArray[left], ref strArray[i]); //swapping the letters based on indecise
            }
         }
      }
      /// <summary>Swapping the letters </summary>
      /// <param name="a">char</param>
      /// <param name="b">char</param>
      static void Swap (ref char a, ref char b) {
         //char temp = a;
         //a = b; b = temp;
         //swapping the letters
         (a, b) = (b, a);
      }
      #endregion
   }
   #endregion
}
