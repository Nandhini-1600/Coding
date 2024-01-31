using System;
for (; ; ) {
   Console.Write ("Enter an integer: ");
   if (int.TryParse (Console.ReadLine (), out int num)) {
      if (IsArmstrongNumber (num)) Console.WriteLine (num + " is an Armstrong number.");
      else Console.WriteLine (num + " is not an Armstrong number.");
   } else Console.WriteLine ("Invalid input.");
}

bool IsArmstrongNumber (int num) {
   int input = num;
   string numStr = num.ToString ();
   int n = numStr.Length;
   double result = 0;
   while (num != 0) {
      int remainder = num % 10;
      double power = Math.Pow (remainder, n);
      result += power;
      num /= 10;
   }
   return result == input;
}
