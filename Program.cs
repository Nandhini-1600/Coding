using System;
for ( ; ; ) {
   string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
   string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
   string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
   string NumberToWords (int number) {
      if (number == 0)
         return "Zero";
      else if (number >= 1 && number < 10)
         return ones[number];
      else if (number >= 11 && number < 20)
         return teens[number - 10];
      else if (number >= 10 && number < 100)
         return tens[number / 10] + (number % 10 != 0 ? " " + ones[number % 10] : "");
      else if (number >= 100 && number < 1000)
         return ones[number / 100] + " Hundred" + (number % 100 != 0 ? " and " + NumberToWords (number % 100) : "");
      else if (number >= 1000 && number < 10000)
         return NumberToWords (number / 1000) + " Thousand" + (number % 1000 != 0 ? " " + NumberToWords (number % 1000) : "");
      else if (number >= 10000 && number < 100000)
         return NumberToWords (number / 1000) + " Thousand" + (number % 10000 != 0 ? " " + NumberToWords (number % 1000) : "");
      else return "Number out of range";
   }
   string NumberToRoman (int number) {
      int[] val = { 100000, 90000, 50000, 40000, 10000, 9000, 5000, 4000, 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
      string[] syb = { "!C", "X!C", "!L", "X!L", "!X", "M!X", "!V", "M!V", "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
      string romanNum = "";
      int i = 0;
      if (number > 0) {
         while (number > 0) {
            int div = number / val[i];
            for (int j = 0; j < div; j++) {
               romanNum += syb[i];
               number -= val[i];
            }
            i++;
         }
         return romanNum;
      } else  return "Enter valid number";
   }
   Console.Write ("Enter a number: ");
   if (int.TryParse (Console.ReadLine (), out int number)) {
      for (; ; ) {
         Console.Write ("Choose conversion (1 for words, 2 for Roman numerals): ");
         int choice = int.Parse (Console.ReadLine ());
         if (choice == 1) {
            string words = NumberToWords (number);
            Console.WriteLine ($"{number} - {words}");
            break;
         } else if (choice == 2) {
            string roman = NumberToRoman (number);
            Console.WriteLine ($"{number} - {roman}");
            break;
         } else Console.WriteLine ("Invalid choice");
      }
   } else Console.WriteLine ("Enter Valid Number");
}
