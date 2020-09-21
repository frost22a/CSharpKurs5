using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Generics.Tests
{
    [TestClass()]
    public class MyStackTests
    {
        [TestMethod()]
        public void NewStack_IsEmpyty()
        {
            var stack = new MyStack<double>();

            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod()]
        public void FourElementsStackAddedFourElements_IsFull()
        {
            var stack = new MyStack<double>(4);
            stack.WriteElement(12);
            stack.WriteElement(15);
            stack.WriteElement(10);
            stack.WriteElement(11);

            Assert.IsTrue(stack.IsFull);
        }

        [TestMethod()]
        public void Last_In_First_Out()
        {
            // Arrange
            var stack = new MyStack<string>(4);
            var value1 = "3.3";
            var value2 = "6.5";
            var value3 = "9.4";
            var value4 = "6.6";

            //Act
            stack.WriteElement(value1);
            stack.WriteElement(value2);
            stack.WriteElement(value3);
            stack.WriteElement(value4);

            //Assert
            Assert.AreEqual(value4, stack.ReadElement());
            Assert.AreEqual(value3, stack.ReadElement());
            Assert.AreEqual(value2, stack.ReadElement());
            Assert.AreEqual(value1, stack.ReadElement());
            Assert.IsTrue(stack.IsEmpty);


        }

        [TestMethod()]
        public void The_Output_Elemnet_Is_The_Top_Of_The_Stack()
        {
            //Arrange
            var stack = new MyStack<double>(10);

            //Act
            stack.WriteElement(1);
            stack.WriteElement(2);
            stack.WriteElement(3);
            stack.WriteElement(4);
            stack.WriteElement(5);

            //Assert
            Assert.AreEqual(5, stack.CheckElement());

        }

        //[TestMethod()]
        //public void CheckElementTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DisplayAllTest()
        //{
        //    Assert.Fail();
        //}
    }
}


