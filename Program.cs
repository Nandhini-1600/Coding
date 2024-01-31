using System;
for ( ; ; ) {
   Console.Write ("Enter the number:");
   if (int.TryParse (Console.ReadLine (), out int num)) {
      while (num >= 10) {
         int sum = 0;
         while (num > 0) {
            sum += num % 10;
            num /= 10;
         }
         num = sum;
      } Console.WriteLine (num);
   } else Console.WriteLine ("Enter valid number");
}
