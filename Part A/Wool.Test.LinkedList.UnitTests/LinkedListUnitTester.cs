using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Wool.Test.LinkedList.UnitTests
{
    [TestClass]
    public class LinkedListUnitTester
    {
        [TestMethod]
        public void GetFromEnd_Should_Return_Right_Value()
        {
            var list = new Domain.LinkedList();
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);
            list.AddNode(6);
            list.AddNode(7);
            list.AddNode(8);
            list.AddNode(9);
            list.AddNode(10);
            Assert.IsTrue(list.GetFromEnd(3)==8);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "rankFromEnd must not be bigger than list length")]
        public void GetFromEnd_Should_Throw_Exception_If_rankFromEnd_Is_Too_Big()
        {
            var list = new Domain.LinkedList();
            list.AddNode(2);
            list.AddNode(3);
            list.GetFromEnd(3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "LinkedList is not initialized")]
        public void GetFromEnd_Should_Throw_Exception_If_LinkedList_Is_Not_Initialized()
        {
            var list = new Domain.LinkedList();
            list.GetFromEnd(3);
        }
    }
}
