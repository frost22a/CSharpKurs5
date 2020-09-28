using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericsMethodsAndDelegates
{
    public class MyStack<T> : IMyCollection<T>
    {
        private Stack<T> stack;
        private int _capacity;

        public MyStack(int capacity = 5)
        {
            this._capacity = capacity;
            this.stack = new Stack<T>(capacity);
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

        public IEnumerator<T> GetEnumerator()
        {
            // najprostsza metoda - > dodać - > return queue.GetEnumerator();
            // robimy własny:
            foreach (var item in stack)
            {
                // możemy tu coś wpisać , a na końcu musimy:
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerable<TOutput> AsEnumerableOf<TOutput>()
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in stack)
            {
                TOutput result = (TOutput)converter.ConvertTo(item, typeof(TOutput));
                yield return result;
            }
        }
    }
}
