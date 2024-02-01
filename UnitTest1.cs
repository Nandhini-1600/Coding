// Test cases for filename parser.
// ------------------------------------------------------------------------------------------------
namespace Training {
   [TestClass]
   public class UnitTest1 {
      [TestMethod]
      public void TestMethod1 () {
         var tests = new Dictionary<string, bool> {
                { @"Cz:\abc\def\r.txt", false },
                { @"C:\abc\def\r.txt", true },
                { @"C:\Readme.txt", false },
                { @"C:\abc\.bcf", false },
                { @"C:\abc\bcf.", false },
                { @"Readme.txt", false },
                { @"C:\abc\def", false },
                { @"C:\abc d", false },
                { @"\abcd\Readme.txt", false },
                { " ", false },
                { @"C:\ab.c\def\r.txt", false },
                { @"C:\abc:d", false },
                { @".\abc", false },
                { ".abc", false },
                { "abc", false },
                { @"C:\abc6\def\r.txt", false },
                { @"C:\work\r.txt", true },
                { @"C:\abc\def\r.txt.txt", false },
                { @"C:\Program Files\<>*&^%$#@!.txt", false },
                { @"C:\work~\r.txt~", false }
         };
         var fileParse = new FileParse ();
         foreach (var testCase in tests) {
            bool parseResult = fileParse.FileNameParse (testCase.Key, out _);
            Assert.AreEqual (testCase.Value, parseResult);
         }
      }
   }
}
