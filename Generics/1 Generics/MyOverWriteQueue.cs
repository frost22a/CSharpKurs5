using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1_Generics
{
    class MyOverWriteQueue<T>: MyQueue<T>, IMyCollection<T>
    {
        int _capacity;
        public MyOverWriteQueue(int capacity = 3)
        {
            _capacity = capacity;
        }

        public override void WriteElement(T element)
        {
            base.WriteElement(element);

            if (queue.Count > _capacity)
            {
                queue.Dequeue();
            }
        }

        public override bool IsFull
        {
            get 
            {
                return queue.Count == _capacity;
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
    }
}
