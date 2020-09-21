﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Generics
{
    class MyStack<T> : IMyCollection<T>
    {
        private Stack<T> stack;
        private int _capacity;

        public MyStack(int capacity = 5)
        {
            _capacity = capacity;
            stack = new Stack<T>(capacity);
        }

        public bool IsEmpty => stack.Count == 0;

        public bool IsFull => stack.Count == _capacity;

        public void WriteElement(T element)
        {
            stack.Push(element);
        }
        public T ReadElement()
        {
            return stack.Pop();
        }
        public T CheckElement()
        {
            return stack.Peek();
        }

        public void DisplayAll()
        {
            if (IsEmpty)
                System.Console.WriteLine("Queue is empty - no elements to display");
            var i = 1;
            foreach (var item in stack)
            {
                System.Console.WriteLine($"Element {i++} : {item}");
            }
        }

        

        
    }
}
