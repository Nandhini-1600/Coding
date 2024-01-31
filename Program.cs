// Implementation of file name parser using state machine.
using System;
using static System.Console;

namespace Training {
   #region Class Program -----------------------------------------------------------------------
   /// <summary>Program</summary>
   public class Program {
      #region Methods --------------------------------------------
      /// <summary>Gets filepath as an input from the user</summary>
      static void Main () {
         WriteLine ("Enter a file path:");
         string s = ReadLine ()!;
         FileParse fileParser = new FileParse ();
         if (fileParser.FileNameParse (s, out var res)) {
            WriteLine ($"Drive Letter: {res.drive}");
            WriteLine ($"Folder Path: {res.folder}");
            WriteLine ($"File Name: {res.file}");
            WriteLine ($"Extension: {res.ext}");
         } else WriteLine ("Enter a valid file path name.");
      }
      #endregion
   }
   #endregion

   #region Class FileParse ---------------------------------------------------------------------
   /// <summary>File name parse</summary>
   public class FileParse {
      #region Methods --------------------------------------------
      /// <summary>When given a string it parses it into parts and returns the components of file path</summary>
      /// <param name="input">Given string</param>
      /// <param name="res">Tuple containing drive, folder, file, and ext</param>
      /// <returns>True if parsing was successful; otherwise, false</returns>
      public bool FileNameParse (string input, out (string drive, string folder, string file, string ext) res) {
         State s = State.A;
         Action none = () => { }, todo;
         string folder = "", drive = "", file = "", ext = "";
         foreach (var ch in input.Trim ().ToUpper () + '~') {
            (s, todo) = (s, ch) switch {
               (State.A, >= 'A' and <= 'Z') => (State.B, () => drive = ch.ToString ()),
               (State.B, ':') => (State.C, none),
               (State.C, '\\') => (State.D, none),
               (State.D or State.E, >= 'A' and <= 'Z') => (State.E, () => folder += ch),
               (State.E, '\\') => (State.F, none),
               (State.F or State.G, >= 'A' and <= 'Z') => (State.G, () => file += ch),
               (State.G, '\\') => (State.F, () => { folder += '\\' + file; file = string.Empty; }),
               (State.G, '.') => (State.H, none),
               (State.H or State.I, >= 'A' and <= 'Z') => (State.I, () => ext += ch),
               (State.I, '~') => (State.J, none),
               _ => (State.Z, none),
            };
            todo ();
         }
         if (s == State.J) {
            res = (drive, folder, file, ext);
            return true;
         } else {
            res = ("", "", "", "");
            return false;
         }
      }

      /// <summary>States involved
      /// see file://D:/Work/statemachinedia.png</summary>
      public enum State { A, B, C, D, E, F, G, H, I, J, Z };
      #endregion
   }
   #endregion
}
