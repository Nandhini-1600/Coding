string[] wordslist = File.ReadAllLines ("D:\\OneDrive - Trumpf Metamation Pvt Ltd\\words.txt");
char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
Dictionary<string, int> wordPoints = new Dictionary<string, int> ();

foreach (string word in wordslist) {
   if (word.Length >= 4 && word.Contains (letters[0]) && word.All (letters.Contains))
      wordPoints.Add (word, letters.All (l => word.Contains (l)) ? word.Length + 7 : word.Length == 4 ? 1 : word.Length);
}

var sortedWordPoints = wordPoints.OrderByDescending (kv => kv.Value).ToList ();

foreach (var kvp in sortedWordPoints) {
   if (kvp.Value == 15) Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine ($"{kvp.Value,3}. {kvp.Key}");
   Console.ResetColor ();
}
Console.WriteLine ("----");
Console.WriteLine ($"{wordPoints.Values.Sum()} total");
