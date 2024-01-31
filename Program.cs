using System;
using System.Linq;
for (; ; ) {
   Console.Write ("Enter the word:");
   string word = Console.ReadLine ().ToLower ();
   var res = (Isogram (word)) ? "is an isogram." : "is not an isogram.";
   Console.WriteLine ($"{word} {res}");
}

bool Isogram (string word) => word.Distinct ().Count () == word.Length;
