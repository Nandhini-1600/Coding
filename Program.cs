// Extension of Spelling Bee assignment
// Display the first 7 letters to be used as the seed for the Spelling Bee program from the given word list.
// --------------------------------------------------------------------------------------------
using System;
// Reading all letter in the wordlist.
string wordsList = File.ReadAllText ("C:/etc/words.txt");
Dictionary<char, int> output = new ();
foreach (char ch in wordsList)
   if (ch >= 'A' && ch <= 'Z') output[ch] = output.TryGetValue (ch, out int cnt) ? cnt + 1 : 1;
// Arrange the letters in descending order based on the value.
var orderedLetters = output.OrderByDescending (kv => kv.Value).ToList ();
Console.WriteLine ("LETTER  COUNT");
Console.WriteLine ("------+------");
foreach (var kvp in orderedLetters) Console.WriteLine ($"{kvp.Key}       {kvp.Value}");
string finalOutput = string.Join (", ", orderedLetters.Select (kv => kv.Key).Take (7));
Console.WriteLine ($"Final Output : {finalOutput}");
