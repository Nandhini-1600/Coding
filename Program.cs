using System;
for (; ; ) {
   Console.Write ("Enter a password: ");
   string password = Console.ReadLine ();
   bool hasLength = password.Length >= 6;
   bool hasDigit = false;
   bool hasLower = false;
   bool hasUpper = false;
   bool hasSpecial = false;
   foreach (char c in password) {
      if (char.IsDigit (c)) {
         if (hasDigit == false)
            hasDigit = true;
         continue;
      } else if (char.IsLower (c)) {
         if (hasLower == false)
            hasLower = true;
         continue;
      } else if (char.IsUpper (c)) {
         if (hasUpper == false)
            hasUpper = true;
         continue;
      } else if ("!@#$%^&*()-+".Contains (c)) {
         if (hasSpecial == false)
            hasSpecial = true;
         continue;
      }
   }
   if (hasLength && hasDigit && hasLower && hasUpper && hasSpecial)
      Console.WriteLine ("Password is strong.");
   else {
      Console.WriteLine ("Password is not strong.");
      if (!hasLength) Console.WriteLine ("Password should be at least 6 characters long.");
      if (!hasDigit) Console.WriteLine ("Password should contain at least one digit.");
      if (!hasLower) Console.WriteLine ("Password should contain at least one lowercase character.");
      if (!hasUpper) Console.WriteLine ("Password should contain at least one uppercase character.");
      if (!hasSpecial) Console.WriteLine ("Password should contain at least one special character (!@#$%^&*()-+).");
   }
}
