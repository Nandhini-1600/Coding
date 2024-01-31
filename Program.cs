using System;
int i, j, count, number,rows;
Console.Write ("Enter number of rows:");
rows= int.Parse (Console.ReadLine ());
number = rows + 1;
count = number -1;
for (j = 1; j <= number; j++) {
   for (i = 1; i <= count; i++)
      Console.Write (" ");
   count--;
   for (i = 1; i <= 2 * j-1; i++)
      Console.Write ("*");
   Console.WriteLine ();
}
count = 1;
for (j = 1; j <= number - 1; j++) {
   for (i = 1; i <= count; i++)
      Console.Write (" ");
   count++;
   for (i = 1; i <= 2 * (number - j) - 1; i++)
      Console.Write ("*");
   Console.WriteLine ();
}
