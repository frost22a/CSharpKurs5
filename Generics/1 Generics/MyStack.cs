using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Generics
{
    public class MyStack<T>
    {
        private T[] elementsOfStack;
        private int topOfTheStack;
        
        public MyStack():this(5)
        {
        }

        public MyStack(int capacity)
        {
            elementsOfStack = new T[capacity];
            topOfTheStack = -1;
        }

        public int Capacity 
        {
            get { return elementsOfStack.Length; } 
        }

        public bool IsEmpty
        {
            get { return topOfTheStack == -1; }
        }
        public bool IsFull 
        {
            get { return topOfTheStack == (Capacity - 1); }
        }

        public void WriteElement(T element)
        {
            if (IsFull)
            {
                Console.WriteLine("Stack is full!");
                Console.WriteLine("Element not added");
            }
            else
            {
                elementsOfStack[++topOfTheStack] = element;
                Console.WriteLine("Element has been successfully added !");
            }
        }

        public T ReadElement() 
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty!");
                return default;
            }
            else
                return elementsOfStack[topOfTheStack--];
     
        }

        public T CheckElement() 
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty!");
                return default;
            }
            else return elementsOfStack[topOfTheStack];
        }

        public void DisplayAll()
        {
            if (IsEmpty)            
                Console.WriteLine("No elements to display");

            for (int i = topOfTheStack; i > -1; i--)
                Console.WriteLine($"Element {i+1} : {elementsOfStack[i]}");
        }

        //public double SumOfElements()
        //{
        //    var sum = 0.0;

        //    for (int i = topOfTheStack; i > -1; i--)
        //    {
        //        if (elementsOfStack[i] is double)
        //        {
        //            sum += (double)elementsOfStack[i];
        //        }
                
        //    }

        //    return sum;
        //}
    }
}
