using System.Collections.Generic;

namespace _1_Generics
{
    public class MyQueue<T>:IMyCollection<T>
    {
        protected Queue<T> queue;
        public MyQueue()
        {
            queue = new Queue<T>();
        }

        public bool IsEmpty => queue.Count == 0;

        public bool IsFull => false;

        public void WriteElement(T element)
        {
            queue.Enqueue(element);
        }

        public T ReadElement()
        {
            return queue.Dequeue();
        }

        public T CheckElement()
        {
            return queue.Peek();
        }

        public void DisplayAll()
        {
            if (IsEmpty)
                System.Console.WriteLine("Queue is empty - no elements to display");
            var i = 1;
            foreach (var item in queue)
            {
                System.Console.WriteLine($"Element {i++} : {item}");
            }
        }    

        
    }
}