using System;
using System.Linq;
string[] words = { "apple", "effort", "cherry", "glory", "fig", "grape", "aegilops", "adopt", "mother", "office" };
string longestAbecedarianWord = FindLongestAbecedarianWord (words);
var res = string.IsNullOrEmpty (longestAbecedarianWord) ? $"No abecedarian word found in the array." : $"Longest Abecedarian Word:{longestAbecedarianWord}";
Console.WriteLine (res);

bool IsAbecedarian (string word) => word == new string (word.OrderBy (c => c).ToArray ());

string FindLongestAbecedarianWord (string[] words) {
   string longestAbecedarianWord = "";
   foreach (string word in words) if (IsAbecedarian (word) && word.Length > longestAbecedarianWord.Length) longestAbecedarianWord = word;
   return longestAbecedarianWord;
}
