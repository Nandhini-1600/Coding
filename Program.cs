using System;
Console.Write ("Enter the number:");
string input = Console.ReadLine ();
Console.WriteLine (IndividualDigit (input));

static string IndividualDigit (string input) {
   if (input.Contains ('.')) {
      string[] substrings = input.Split ('.');
      if (substrings.Length == 2) {
         string integralPart = string.Join (" ", substrings[0].ToCharArray ());
         string fractionalPart = string.Join (" ", substrings[1].ToCharArray ());
         return "Integral part: " + integralPart + "; Fractional part: " + fractionalPart;
      }
      return "Invalid input";
   }
   return "Integral part:" + string.Join (" ", input.ToCharArray ());
}
