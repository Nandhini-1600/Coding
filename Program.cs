using System;
Console.Write ("Enter a word or phrase:");
string text = Console.ReadLine ();
string original = text.Replace (" " , "").ToLower ();
if (original.Equals (ReverseString (original))) Console.WriteLine (text + " is a Palindrome!");
else Console.WriteLine (text + " is not a Palindrome!");

string ReverseString (string original) {
   char[] chars = original.ToCharArray ();
   string rev = "";
   for (int i = chars.Length - 1; i >= 0; i--)
      rev += chars[i];
   return rev;
}
