// VOTING CONTEST 
// Given a string S to a method, with each character in it representing a vote for a contestant, return the winner with the most votes.
// For example,input=Helloworld;output wil be L, 3 => Winner and votes.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Voting Contest</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>getting input from the user</summary>
      static void Main () {
         Console.WriteLine ("Enter the string: ");
         string input = Console.ReadLine ()!;
         FindWinner (input, out char winner, out int votes);
         Console.WriteLine ($"{winner}, {votes} => Winner and votes");
      }
      
      /// <summary>find the winner based on votes</summary>
      /// <param name="input">word</param>
      /// <param name="winner">letter with maximum votes</param>
      /// <param name="votes">votes</param>
      static void FindWinner (string input, out char winner, out int votes) {
         // Store character and votes.
         Dictionary<char, int> voteCount = new ();
         foreach (char c in input.ToLower ()) 
            if (Char.IsLetter (c))  voteCount[c] = voteCount.TryGetValue (c, out int count) ? count + 1 : 1;
         var result = voteCount.OrderByDescending (kvp => kvp.Value).FirstOrDefault ();
         winner = result.Key;
         votes = result.Value;
      }
      #endregion
   }
   #endregion
}
