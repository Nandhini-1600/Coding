// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// Program.cs
// MYLIST<T>
// Implement a custom MyList<T> class using arrays as the underlying data structure.
// --------------------------------------------------------------------------------------------
using Training;
namespace list {
   [TestClass]
   public class UnitTest1 {
      MyList<int> list1 = new ();
      List<int> list2 = new ();

      [TestMethod]
      public void TestAdd () {
         for (int i = 1; i <= 5; i++) {
            list1.Add (i);
            list2.Add (i);
         }
         Assert.AreEqual (list1.Capacity, list2.Capacity);
         Assert.AreEqual (list1.Count, list2.Count);
         list1[0] = 9;
         list2[0] = 9;
         Assert.AreEqual (list1[0], list2[0]);
      }

      [TestMethod]
      public void TestRemove () {
         for (int i = 1; i <= 7; i++) {
            list1.Add (i);
            list2.Add (i);
         }
         for (int i = 4; i <= 6; i++) {
            list1.Remove (i);
            list2.Remove (i);
         }
         Assert.AreEqual (list1.Count, list2.Count);
         Assert.AreEqual (list1[3], list2[3]);
      }

      [TestMethod]
      public void TestClear () {
         for (int i = 1; i <= 7; i++) {
            list1.Add (i);
            list2.Add (i);
         }
         list1.Clear ();
         list2.Clear ();
         Assert.AreEqual (list1.Count, list2.Count);
      }

      [TestMethod]
      public void TestInsert () {
         for (int i = 1; i <= 4; i++) {
            list1.Add (i);
            list2.Add (i);
         }
         list1.Insert (2, 8);
         list2.Insert (2, 8);
         Assert.AreEqual (list1.Count, list2.Count);
         Assert.AreEqual (list1.Capacity, list2.Capacity);
         Assert.AreEqual (list1[3], list2[3]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => list1.Insert (8, 9));
         Assert.ThrowsException<IndexOutOfRangeException> (() => list1.Insert (-2, 9));
      }

      [TestMethod]
      public void TestRemoveAt () {
         for (int i = 1; i <= 5; i++) {
            list1.Add (i);
            list2.Add (i);
         }
         list1.RemoveAt (0);
         list2.RemoveAt (0);
         Assert.AreEqual (list1.Count, list2.Count);
         list1.RemoveAt (1);
         list2.RemoveAt (1);
         Assert.AreEqual (list1.Count, list2.Count);
         Assert.ThrowsException<IndexOutOfRangeException> (() => list1.RemoveAt (10));
         Assert.ThrowsException<IndexOutOfRangeException> (() => list1.RemoveAt (-2));
      }

      [TestMethod]
      public void TestDisplay () {
         for (int i = 1; i <= 5; i++) {
            list1.Add (i);
            list2.Add (i);
         }
         list1.Display ();
      }
   }
}