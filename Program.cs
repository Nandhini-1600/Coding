using System;
for (; ; ) {
   Console.Write ("Enter the rows:");
   if (int.TryParse (Console.ReadLine (), out int rows)) {
      for (int i = 0; i < rows; i++) {
         for (int j = 0; j < rows - i; j++) 
            Console.Write (" ");
         int val = 1;
         for (int j = 0; j <= i; j++) {
            Console.Write (val + " ");
            val = val * (i - j) / (j + 1);
         }
         Console.WriteLine ();
      }
   } else Console.WriteLine ("Enter valid number");
}
