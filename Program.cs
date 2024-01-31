using System;
for (; ; ) {
   Console.Write ("Enter the number 1 :");
   int.TryParse (Console.ReadLine (), out int num1);
   Console.Write ("Enter the number 2 :");
   int.TryParse (Console.ReadLine (), out int num2);
   SwapNumber (ref num1, ref num2);
   Console.WriteLine ($"After swapping :num1={num1},num2={num2}");
}

static void SwapNumber (ref int num1, ref int num2) {
   int temp = num1;
   num1 = num2;
   num2 = temp;
}
