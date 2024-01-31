using System;
Console.WriteLine ("Multiplication Table ");
for (int i = 1; i <= 10; i++) {
   Console.WriteLine ($"\nTable for {i}:");
   for (int j = 1; j <= 10; j++) Console.WriteLine ("{0} * {1,2} = {2} ", i, j, i * j);
}
