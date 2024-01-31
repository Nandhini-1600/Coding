// STACK<T>
// Implement a Stack<T> class using arrays as the underlying data structure. The Stack<T> should start with an initial capacity of 4 and double its capacity when needed.
// Use the template shown below for implementation. Throw exceptions when necessary.
// class TStack<T> { 
// public void Push (T a) { }
// public T Pop () { }
// public T Peek () { }
// public bool IsEmpty { get; }
// }
// --------------------------------------------------------------------------------------------
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   class Program {
      #region Method ---------------------------------------------
      static void Main () { }
      #endregion
   }
   #endregion

   #region TStack<T> ------------------------------------------------------------------------------
   /// <summary>Create a class</summary>
   /// <typeparam name="T">Datatype of the array</typeparam>
   public class TStack<T> {
      #region Constructor -------------------------------------------
      /// <summary>Creating the constructor</summary>
      public TStack () { }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Expection handling</summary>
      /// <exception cref="InvalidOperationException">When the array is empty</exception>
      public void InvalidException () {
         if (IsEmpty)
            throw new InvalidOperationException ("It is an empty stack.");
      }

      /// <summary>Display the top elememt</summary>
      /// <returns>Top element in the array</returns>
      public T Peek () {
         InvalidException ();
         return mArray[mCount - 1];
      }

      /// <summary>Delete a element from the array and return it</summary>
      /// <returns>Element to be return</returns>
      public T Pop () {
         InvalidException ();
         return mArray[--mCount];
      }

      /// <summary>Add an element to the array</summary>
      /// <param name="item">Element to be added</param>
      public void Push (T item) {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mCount++] = item;
      }
      #endregion

      #region Properties --------------------------------------------
      /// <summary>Calculating capacity of the array</summary>
      public int Capacity => mArray.Length;

      /// <summary>Gets the number of elements in the list</summary>
      public int Count => mCount;

      /// <summary>Check the array is empty or not</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Private data ------------------------------------------
      T[] mArray = new T[4];
      int mCount = 0;
      #endregion
   }
   #endregion
}
