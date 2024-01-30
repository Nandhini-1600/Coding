using System;
for (; ; ) {
   Console.Write ("Enter a decimal number: ");
   if (int.TryParse (Console.ReadLine (), out int decimalnum)) {
      if (decimalnum > 0) {
         string[] hexacha = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
         string hexadeci = "";
         int num = decimalnum;
         while (num > 0) {
            string reminder = hexacha[num % 16];
            hexadeci = reminder + hexadeci;
            num /= 16;
         }
         Console.WriteLine ($"Hexadecimal: {hexadeci}");
         string binary = "";
         while (decimalnum > 0) {
            int remainder = decimalnum % 2;
            binary = remainder.ToString () + binary;
            decimalnum /= 2;
         }
         Console.WriteLine ($"Binary:{binary}");
      }
      else {
         Console.WriteLine ($"Binary : 00000000");
         Console.WriteLine ($"Hexadecimal : 0");
      }
   } 
   else Console.WriteLine ("enter valid number");
}
