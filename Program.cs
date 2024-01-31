// Program to implement double.Parse method that takes a string and returns a double.
using System;
using System.Linq;

namespace Training {
   #region class Program ---------------------------------------------------------------------------------
   /// <summary>Class program</summary>
   class Program {
      #region Method ------------------------------------------------
      /// <summary>Display output</summary>
      static void Main () {
         for (; ; ) {
            Console.WriteLine ("Enter a number:");
            string input = Console.ReadLine ();
            if (MDouble.Parse (input, out double result)) Console.WriteLine ($"Parsed value: {result}");
            else Console.WriteLine ("Invalid input. Please enter a valid number.");
         }
      }
      #endregion
   }
   #endregion

   #region class MDouble --------------------------------------------------------------------------------
   /// <summary>Double precision floating point number representation</summary>
   public class MDouble {
      #region Method ------------------------------------------------
      /// <summary>Calculate exp part</summary>
      /// <param name="input">Input number</param>
      /// <param name="exp">Exponent part</param>
      /// <returns>Value after exp</returns>
      static bool AfterExp (string input, out double exp) {
         exp = 0;
         if (input.Contains ('.')) return false;
         (double sign, string result) = SignCheck (input);
         if (!NumericPart (result, out double intPart)) return false;
         exp = sign * intPart;
         return true;
      }

      /// <summary>Calculate value before exp</summary>
      /// <param name="input">Input number</param>
      /// <param name="baseNum">Base number</param>
      /// <returns>Value before exp</returns>
      static bool BeforeExp (string input, out double baseNum) {
         baseNum = 0;
         if (input.Length == 1 && new[] { '.', '+', '-' }.Any (input.Contains)) return false;
         (double sign, string result) = SignCheck (input);
         string[] parts = result.Split ('.');
         if (parts.Length > 2) return false;
         if (!NumericPart (parts[0], out double intPart)) return false;
         double deciPart = 0;
         if (parts.Length == 2 && !string.IsNullOrEmpty (parts[1]))
            if (!DecimalPart (parts[1], out deciPart)) return false;
         baseNum = sign * (intPart + deciPart);
         return true;
      }

      /// <summary>Calculate decimal part</summary>
      /// <param name="input">Input</param>
      /// <param name="decPart">Decimal part</param>
      /// <returns>Value of decimal part</returns>
      static bool DecimalPart (string input, out double decPart) {
         decPart = 0; double f = 0.1;
         foreach (char c in input) {
            if (!char.IsDigit (c)) return false;
            decPart += (c - '0') * f;
            f *= 0.1;
         }
         return true;
      }

      /// <summary>Calculate numeric part</summary>
      /// <param name="input">Input</param>
      /// <param name="numPart">Numeric part</param>
      /// <returns>Value of numeric part</returns>
      static bool NumericPart (string input, out double numPart) {
         numPart = 0;
         foreach (char c in input) {
            if (!char.IsDigit (c)) return false;
            numPart = numPart * 10 + (c - '0');
         }
         return true;
      }

      /// <summary>Implementation of double parse</summary>
      /// <param name="input">Input number</param>
      /// <param name="res">Double parse value</param>
      /// <returns>Returns a double precision floating point number whether the input is valid</returns>
      public static bool Parse (string input, out double res) {
         res = 0;
         // Remove the space and change the upper character to lower character
         input = input.Trim ().ToLower ();
         if (string.IsNullOrWhiteSpace (input) || input.StartsWith ('e') || input.EndsWith ('e')) return false;
         string[] parts = input.Split ('e');
         if (parts.Length == 2 && BeforeExp (parts[0], out double baseNum) && AfterExp (parts[1], out double exp)) {
            res = baseNum * Math.Pow (10, exp);
            return true;
         } else if (parts.Length == 1) return BeforeExp (input, out res);
         return false;
      }

      /// <summary>Calculate sign value</summary>
      /// <param name="input">Input</param>
      /// <returns>Sign and input value</returns>
      static (double, string) SignCheck (string input) {
         double sign = 1; string output = input;
         if (input[0] is '-' or '+') {
            sign = (input[0] == '-') ? -1 : 1;
            output = input.Substring (1);
         }
         return (sign, output);
      }
      #endregion
   }
   #endregion
}
