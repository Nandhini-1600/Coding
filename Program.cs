using System;
using System.Text;
for (; ; ) {
   Console.Write ("Enter the input string:");
   string input = Console.ReadLine ().ToLower ();
   string reducedString = ReduceString (input);
   Console.WriteLine ("Output:" + reducedString);
}

string ReduceString(string input) {
   StringBuilder result = new StringBuilder ();
   foreach (char c in input) {
      if (result.Length > 0 && result[result.Length - 1] == c) result.Remove (result.Length - 1, 1);
      else result.Append (c);
   }
   return result.ToString ();
}
