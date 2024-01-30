using System;
for (; ; ) {
   Console.Write ("Enter the number: ");
   int firstNum = 0, secondNum = 1, nextNum, num;
   if (int.TryParse (Console.ReadLine (), out num)) {
      if (num < 2) {
         Console.Write ("Please Enter a number greater than two");
      } else {
         Console.Write (firstNum + " " + secondNum + " ");
         for (int i = 2; i < num; i++) {
            nextNum = firstNum + secondNum;
            Console.Write (nextNum + " ");
            firstNum = secondNum;
            secondNum = nextNum;
         }
      }
   } else Console.WriteLine ("Enter Valid number");
}
