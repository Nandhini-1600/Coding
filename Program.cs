using System;
Console.Write ("Enter a positive number: ");
bool var = int.TryParse (Console.ReadLine (), out int number);
if (number == 1 || number == 0)  
   Console.Write ("neither prime number nor composite");
else if (number == 2)
   Console.Write ("a prime number");
else  {
   for (int i = 2; i < number; i++) {
      if (number % i == 0) {
         Console.WriteLine (" not prime");
         break;
      }
      else {
         Console.WriteLine ("prime");
         break;
      }
   }
}
