using System;
for (; ; ) {
   Console.Write ("Enter the number : ");
   if (int.TryParse (Console.ReadLine (), out int num)) Console.WriteLine ("Factorial number for " + num + "! is " + FactorialNumber (num));
   else Console.WriteLine ("Invalid Input");
}

static long FactorialNumber (int num) {
   long factorial = 1;
   for (int i = 1; i <= num; i++) factorial *= i;
   return factorial;
}
