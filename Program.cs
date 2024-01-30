using System;
for (; ; ) {
   Console.Write ("Enter the first number: ");
   int.TryParse (Console.ReadLine (), out int a);
   Console.Write ("Enter the second number: ");
   int.TryParse (Console.ReadLine (), out int b);
   int gcd = CalculateGCD (a, b);
   int lcm = (a * b) / gcd;
   Console.WriteLine ($"GCD of {a} and {b} is: {gcd}");
   Console.WriteLine ($"LCM of {a} and {b} is: {lcm}");
}

int CalculateGCD (int X, int Y) {
   while (Y != 0) {
      int temp = Y;
      Y = X % Y;
      X = temp;
   }
   return X;
}
