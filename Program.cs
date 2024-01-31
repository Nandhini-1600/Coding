// Program to implement a double ended queue.
// This queue can enqueue as well as dequeue elements from both the ends and also known as deque.
// ------------------------------------------------------------------------------------------------
using System;

namespace Training {
   #region Class Program -----------------------------------------------------------------------
   class Program {
      static void Main () { }
   }
   #endregion

   #region class  TDeque -------------------------------------------------------------------
   /// <summary>Double ended queue</summary>
   /// <typeparam name="T">Datatype</typeparam>
   public class TDeque<T> {
      #region Property -------------------------------------------
      /// <summary>Gets the capacity of the array</summary>
      public int Capacity => mArray.Length;

      /// <summary>Gets the number of elements in the array</summary>
      public int Count => mCount;

      /// <summary>Checks whether the mArray is empty or not</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Implementation -------------------------------------
      /// <summary>Removes an element from the front</summary>
      /// <returns>Returns dequeue element</returns>
      public T DequeueFront () {
         T dequeueItem;
         Exception ();
         (dequeueItem, mArray[mFront]) = (mArray[mFront], default);
         mCount--;
         mFront = (mFront + 1) % Capacity;
         return dequeueItem;
      }

      /// <summary>Removes an element from the rear</summary>
      /// <returns>Returns dequeue element</returns>
      /// <exception cref="InvalidOperationException">Throw expection when the array is empty</exception>
      public T DequeueRear () {
         T dequeItem;
         Exception ();
         mRear = (mRear + Capacity - 1) % Capacity;
         (dequeItem, mArray[mRear]) = (mArray[mRear], default);
         mCount--;
         return dequeItem;
      }

      /// <summary>Adds the element at the front end of the array</summary>
      /// <param name="item">Element to be added</param>
      public void EnqueueFront (T item) {
         if (Count == Capacity) Resize ();
         mFront = (mFront + Capacity - 1) % Capacity;
         mArray[mFront] = item;
         mCount++;
      }

      /// <summary>Adds the element at the rear end of the array</summary>
      /// <param name="item">Element to be added</param>
      public void EnqueueRear (T item) {
         if (Count == Capacity) Resize ();
         mArray[mRear] = item;
         mCount++;
         mRear = (mRear + 1) % Capacity;
      }

      /// <summary>Exception handling</summary>
      /// <exception cref="InvalidOperationException">Throws exception hen the array is empty</exception>
      void Exception () {
         if (IsEmpty) throw new InvalidOperationException ("It is an empty queue.");
      }

      /// <summary>Returns the first element added to the front of the deque</summary>
      /// <returns>Returns the first element of the queue</returns>
      public T PeekFront () {
         Exception ();
         return mArray[mFront];
      }

      /// <summary>Returns the first element added to the rear of the deque</summary>
      /// <returns>Returns the first element of the queue</returns>
      public T PeekRear () {
         Exception ();
         return mArray[(mRear + Capacity - 1) % Capacity];
      }

      /// <summary>Resizes the array by increasing the capacity</summary>
      void Resize () {
         T[] newArray = new T[mCount * 2];
         for (int i = 0; i < mCount; i++) newArray[i] = mArray[(mFront + i) % mCount];
         mArray = newArray;
         (mFront, mRear) = (0, mCount);
      }
      #endregion

      #region Private data ---------------------------------------
      T[] mArray = new T[4];
      int mCount = 0, mFront = 0, mRear = 0;
      #endregion
   }
   #endregion
}
