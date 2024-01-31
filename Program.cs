// CHOCOLATE WRAPPERS 
// Write a method, for a given money X along with price P of a chocolate and required wrappers W for a chocolate in exchange. 
// Return the maximum number of chocolates C you can get along with any unused money X and wrappers W.
// For example,Input:X = 15, P = 4, W = 3 Output:C = 4, X = 3, W = 1
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Chocolate Wrappers</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.Write ("Enter the amount: ");
         int x = GetInput ();
         Console.Write ("Enter the price of a chocolate: ");
         int p = GetInput ();
         Console.Write ("Enter the number of wrappers needed for a chocolate: ");
         int w = GetInput ();
         CalculateChocolates (x, p, w, out int chocolates, out int balance, out int balanceWrappers);
         Console.WriteLine ($"Output: C = {chocolates}, X = {balance}, W = {balanceWrappers}");
      }

      /// <summary>Checking the input is integer or not</summary>
      /// <returns>Integer value</returns>
      static int GetInput () {
         int value;
         while (!int.TryParse (Console.ReadLine (), out value))
            Console.Write ("Invalid input.Please enter a valid integer.");
         return value;
      }

      /// <summary>Calculating no of chocolate can buy with this money,remaining money,remaining wrappers</summary>
      /// <param name="money">The amount user having</param>
      /// <param name="price">Price of a chocolate</param>
      /// <param name="wrappers">No of wrappers can exchange with a chocolate</param>
      /// <param name="chocolates">No of chocolate can buy with the money</param>
      /// <param name="balance">Remaining amount after buying chocolate</param>
      /// <param name="balanceWrappers">Remaining wrappers after buying chocolate</param>
      static void CalculateChocolates (int money, int price, int wrappers, out int chocolates, out int balance, out int balanceWrappers) {
         chocolates = money / price; // Initial chocolates bought with money
         balance = money % price; // Remaining money after buying initial chocolates
         chocolates += chocolates / wrappers; // Add the chocolates obtained from wrappers to the total count
         balanceWrappers = chocolates % wrappers;
      }
      #endregion
   }
   #endregion
}
