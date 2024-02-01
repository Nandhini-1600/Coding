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
using Training;
namespace TestStack {

   [TestClass]
   public class UnitTest1 {
      TStack<int> stack1 = new ();
      Stack<int> stack2 = new ();

      [TestMethod]
      public void PeekTest () {
         for (int i = 1; i < 4; i++) {
            stack1.Push (i);
            stack2.Push (i);
         }
         Assert.AreEqual (stack1.Peek (), stack2.Peek ());
         while (stack1.Count > 0 && stack2.Count > 0) Assert.AreEqual (stack1.Pop (), stack2.Pop ());
         Assert.IsTrue (stack1.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => stack1.Peek ());
      }

      [TestMethod]
      public void TestPop () {
         for (int i = 1; i < 4; i++) {
            stack1.Push (i);
            stack2.Push (i);
         }
         Assert.AreEqual (stack1.Count, stack2.Count);
         while (stack1.Count > 0 && stack2.Count > 0) Assert.AreEqual (stack1.Pop (), stack2.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => stack1.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => stack2.Pop ());
      }

      [TestMethod]
      public void TestPush () {
         for (int i = 1; i < 6; i++) {
            stack1.Push (i);
            stack2.Push (i);
         }
         Assert.AreEqual (stack1.Count, stack2.Count);
         Assert.AreEqual (stack2.EnsureCapacity (stack1.Count), stack1.Capacity);
      }
   }
}
