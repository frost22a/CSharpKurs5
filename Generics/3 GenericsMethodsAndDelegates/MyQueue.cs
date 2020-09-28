using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace GenericsMethodsAndDelegates
{
    public class MyQueue<T> : IMyCollection<T>
    {
        protected Queue<T> queue;
        public MyQueue()
        {
            queue = new Queue<T>();
        }

        public bool IsEmpty => queue.Count == 0;

        public virtual bool IsFull => false;// virtual, gdyż w klasie MyOverWriteQueue nadpisujemy te metody

        public virtual void WriteElement(T element)
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

        public IEnumerator<T> GetEnumerator()
        {
            // najprostsza metoda - > dodać - > return queue.GetEnumerator();
            // robimy własny:
            foreach (var item in queue)
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

            foreach (var item in queue)
            {
                var result = converter.ConvertTo(item, typeof(TOutput));
                yield return  (TOutput)result;
            }
        }
    }
}