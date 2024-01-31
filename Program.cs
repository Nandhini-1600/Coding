using System;
for (; ; ) {
   Console.Write ("Enter the number:");
   if (int.TryParse (Console.ReadLine (), out int number)) {
      int orgNumber = number;
      int revNumber = 0;
      while (number > 0) {
         int lastDigit = number % 10;
         revNumber = revNumber * 10 + lastDigit;
         number /= 10;
      }
      if (revNumber == orgNumber) Console.WriteLine ("It is a Palindrome");
      else Console.WriteLine ("It is not a Palindrome");
   }
   else Console.WriteLine ("Please enter valid input.");
}
