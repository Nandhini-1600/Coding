// ------------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023.
// Copyright (c) Metamation India.
// ----------------------------------------------------------------------------
// A10.2
// Test cases for the implementation of double ended queue.
// This queue can enqueue as well as dequeue elements from both the ends.
// ------------------------------------------------------------------------------------------------
using Training;
namespace Deque;

[TestClass]
public class UnitTest1 {
   [TestMethod]
   public void Dequeue () {
      Assert.ThrowsException<InvalidOperationException> (() => mTest.DequeueFront ());
      Assert.ThrowsException<InvalidOperationException> (() => mTest.DequeueRear ());
      for (int i = 1; i <= 4; i++) mTest.EnqueueFront (i);
      Assert.AreEqual (4, mTest.DequeueFront ());
      Assert.AreEqual (3, mTest.DequeueFront ());
      Assert.AreEqual (1, mTest.DequeueRear ());
      Assert.AreEqual (1, mTest.Count);
      for (int i = 5; i <= 9; i++) mTest.EnqueueRear (i);
      mTest.EnqueueFront (10);
      Assert.AreEqual (10, mTest.DequeueFront ());
      Assert.AreEqual (9, mTest.DequeueRear ());
   }

   [TestMethod]
   public void Enqueue () {
      for (int i = 1; i <= 5; i++) mTest.EnqueueFront (i);
      Assert.AreEqual (5, mTest.Count);
      Assert.AreEqual (8, mTest.Capacity);
      for (int i = 6; i <= 9; i++) mTest.EnqueueRear (i);
      Assert.AreEqual (9, mTest.Count);
      Assert.AreEqual (16, mTest.Capacity);
   }

   [TestMethod]
   public void Peek () {
      Assert.ThrowsException<InvalidOperationException> (() => mTest.PeekFront ());
      Assert.ThrowsException<InvalidOperationException> (() => mTest.PeekFront ());
      for (int i = 1; i <= 5; i++) mTest.EnqueueFront (i);
      Assert.AreEqual (5, mTest.Count);
      Assert.AreEqual (5, mTest.PeekFront ());
      for (int i = 6; i <= 10; i++) mTest.EnqueueRear (i);
      Assert.AreEqual (10, mTest.Count);
      Assert.AreEqual (10, mTest.PeekRear ());
   }
   TDeque<int> mTest = new ();
}