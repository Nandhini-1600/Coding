// QUEUE<T>
// Implement a Queue<T> using arrays as the underlying data structure. The queue should grow the array when needed (like the TStack before does).
// If the array does not have to be grown, both Enqueue and Dequeue should be constant time (O(1)) operations. Throw exceptions as needed.
// class TQueue<T> { 
// public void Enqueue (T a) { }
// public T Dequeue () { }
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

   #region TQueue<T> ------------------------------------------------------------------------------
   /// <summary>Create a class</summary>
   /// <typeparam name="T">Datatype of the array</typeparam>
   public class TQueue<T> {
      #region Constructor -------------------------------------------
      /// <summary>Creating the constructor for initializing the values</summary>
      public TQueue () { }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Delete a element from the array and return it</summary>
      /// <returns>Element to be return</returns>
      public T Dequeue () {
         Exception ();
         T item = mArray[mFront];
         mArray[mFront] = default;
         mFront = (mFront + 1) % mArray.Length;
         mCount--;
         return item;
      }

      /// <summary>Add a element to the array</summary>
      /// <param name="a">Element to be add</param>
      public void Enqueue (T a) {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mRear] = a;
         mRear = (mRear + 1) % mArray.Length;
         mCount++;
      }

      /// <summary>Expection handling</summary>
      /// <exception cref="InvalidOperationException">When the array is empty</exception>
      public void Exception () {
         if (IsEmpty)
            throw new InvalidOperationException ("It is an empty queue.");
      }

      /// <summary>Display the top elememt</summary>
      /// <returns>Top element in the array</returns>
      public T Peek () {
         Exception ();
         return mArray[mFront];
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
      int mRear = 0;
      int mFront = 0;
      #endregion
   }
   #endregion
}
