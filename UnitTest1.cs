// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// UnitTest1.cs
// QUEUE<T>
// Implement a Queue<T> using arrays as the underlying data structure. The queue should grow the array when needed (like the TStack above does).
// If the array does not have to be grown, both Enqueue and Dequeue should be constant time (O(1)) operations. Throw exceptions as needed.
// class TQueue<T> { 
// public void Enqueue (T a) { }
// public T Dequeue () { }
// public T Peek () { }
// public bool IsEmpty { get; }
// }
// --------------------------------------------------------------------------------------------
using Training;
namespace TestQueue {
   [TestClass]
   public class UnitTest1 {
      TQueue<int> queue1 = new ();
      Queue<int> queue2 = new ();

      [TestMethod]
      public void TestDequeue () {
         for (int i = 1; i < 4; i++) {
            queue1.Enqueue (i);
            queue2.Enqueue (i);
         }
         Assert.AreEqual (queue1.Count, queue2.Count);
         while (queue1.Count > 0 && queue2.Count > 0) Assert.AreEqual (queue1.Dequeue (), queue2.Dequeue ());
         Assert.IsTrue (queue1.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => queue1.Dequeue ());
         Assert.ThrowsException<InvalidOperationException> (() => queue2.Dequeue ());
      }

      [TestMethod]
      public void TestEnqueue () {
         for (int i = 1; i < 5; i++) {
            queue1.Enqueue (i);
            queue2.Enqueue (i);
         }
         Assert.AreEqual (queue1.Count, queue2.Count);
         Assert.AreEqual (queue2.EnsureCapacity (queue1.Count), queue1.Capacity);
         queue1.Enqueue (5);
         Assert.AreEqual (queue2.EnsureCapacity (queue1.Count), queue1.Capacity);
      }

      [TestMethod]
      public void TestPeek () {
         for (int i = 1; i < 4; i++) {
            queue1.Enqueue (i);
            queue2.Enqueue (i);
         }
         Assert.AreEqual (queue1.Peek (), queue2.Peek ());
         Assert.AreEqual (queue1.Count, queue2.Count);
         while (queue1.Count > 0 && queue2.Count > 0) Assert.AreEqual (queue1.Dequeue (), queue2.Dequeue ());
         Assert.IsTrue (queue1.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => queue1.Peek ());
         Assert.ThrowsException<InvalidOperationException> (() => queue2.Peek ());
      }
   }
}