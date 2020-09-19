using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Generics
{
    public class MyStack
    {
        private double[] elementsOfStack;
        private int topOfTheStack;
        
        public MyStack():this(5)
        {
        }

        public MyStack(int capacity)
        {
            elementsOfStack = new double[capacity];
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

        public void WriteElement(double element)
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

        public double ReadElement() 
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
            else
                return elementsOfStack[topOfTheStack--];
     
        }

        public double CheckElement() 
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty!");
                return 0;
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
    }
}
