using System;
int random_num = new Random ().Next (1, 101);
for (; ; ) {
   Console.Write ("Enter your guess:");
   bool var = int.TryParse (Console.ReadLine (), out int guess_num);
   if (var == false) Console.WriteLine ("Invalid guess");
   else {
      if (guess_num > random_num) Console.WriteLine ("Your guess is too high.");
      else if (guess_num < random_num) Console.WriteLine ("Your guess is too low.");
      else {
         Console.WriteLine ("Your guessed correctly.");
         break;
      }
   }
}
