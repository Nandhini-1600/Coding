// MYLIST<T> 
// Implement a custom MyList<T> class using arrays as the underlying data structure.
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   class Program {
      #region Method ---------------------------------------------
      static void Main () { }
      #endregion
   }
   #endregion

   #region MyList<T> ------------------------------------------------------------------------------
   /// <summary>Create a class</summary>
   /// <typeparam name="T">Datatype of the list</typeparam>
   public class MyList<T> {
      #region Constructor -------------------------------------------
      /// <summary>Creating a Constructor</summary>
      public MyList () { }
      #endregion

      #region Properties --------------------------------------------
      /// <summary>Calculating capacity of the array</summary>
      public int Capacity => mArray.Length;

      /// <summary>Gets the number of elements in the list</summary>
      public int Count => mCount;

      /// <summary>Set and return the value based on the index</summary>
      /// <param name="index">Index to be change</param>
      /// <returns>Changed value of the index</returns>
      public T this[int index] {
         get {
            CheckIndexRange (index);
            return mArray[index];
         }
         set {
            CheckIndexRange (index);
            mArray[index] = value;
         }
      }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Add the value to the end</summary>
      /// <param name="a">Value to be add</param>
      public void Add (T a) {
         CheckCapacity ();
         mArray[mCount++] = a;
      }

      /// <summary>Check the array capacity</summary>
      private void CheckCapacity () {
         if (mCount == mArray.Length)
            Array.Resize (ref mArray, mArray.Length * 2);
      }

      /// <summary>Checking the index valid or not</summary>
      /// <param name="index">Index</param>
      /// <exception cref="IndexOutOfRangeException">When the index is not in range</exception>
      private void CheckIndexRange (int index) {
         if (index < 0 || index >= mCount)
            throw new IndexOutOfRangeException ("Index is out of the valid range.");
      }

      /// <summary>Clear the elements</summary>
      public void Clear () {
         Array.Clear (mArray, 0, mCount);
         mCount = 0;
      }

      /// <summary>Display the list</summary>
      public void Display () {
         for (int i = 0; i < mCount; i++)
            Console.Write (mArray[i]);
         Console.WriteLine ();
      }

      /// <summary>Insert the value</summary>
      /// <param name="index">The index where to add</param>
      /// <param name="item">The value to be add</param>
      /// <exception cref="IndexOutOfRangeException">When the index is not in range</exception>
      public void Insert (int index, T item) {
         if (index < 0 || index > mCount)
            throw new IndexOutOfRangeException ("Index is out of the valid range.");
         CheckCapacity ();
         for (int i = mCount; i > index; i--)
            mArray[i] = mArray[i - 1];
         mArray[index] = item;
         mCount++;
      }

      /// <summary>Remove the value</summary>
      /// <param name="a">Value to be remove</param>
      /// <returns>Removes the value at the index</returns>
      /// <exception cref="InvalidOperationException">When the item not found</exception>
      public bool Remove (T a) {
         int index = Array.IndexOf (mArray, a);
         mArray[index] = default;
         mCount--;
         for (int i = index; i < mCount; i++)
            mArray[i] = mArray[i + 1];
         return true;
      }

      /// <summary>Remove the value</summary>
      /// <param name="index">Index where to remove the element</param>
      public void RemoveAt (int index) {
         CheckIndexRange (index);
         Remove (this[index]);
      }
      #endregion
      #region Private data ------------------------------------------
      T[] mArray = new T[4];
      int mCount = 0;
      #endregion
   }
   #endregion
}
