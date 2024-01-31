using System;
if (int.TryParse (args[0], out int num)) Console.WriteLine ($"The {num}th Armstrong number is: " + NthArmstrongNumber (num));
else  Console.WriteLine ("Invalid Input");

static int NthArmstrongNumber (int num) {
   int count = 0, i = 0;
   if (num < 10) return num;
   while (count < num)
      if (IsArmstrong (++i)) count++;
   return i;
}

static bool IsArmstrong (int i) {
   int n = i.ToString ().Length;
   int temp = i, result = 0;
   while (temp != 0) {
      int remainder = temp % 10;
      int power = (int)Math.Pow (remainder, n);
      result += power;
      temp /= 10;
   }
   return result == i;
}
