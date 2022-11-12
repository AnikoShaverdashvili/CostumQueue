using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumQueue
{
    public class MyQueue<T>
    {
        private readonly List<T>? _queue;
        private int i;

        public MyQueue(List<T>? queue)
        {
            _queue = queue;
        }

        public MyQueue(int capacity)
        {
            _queue = new List<T>(capacity);
        }

       
        public void Enqueue(T element)
        {
            _queue!.Add(element);
        }

       
        public T Dequeue ()
        {
            if (_queue == null || _queue?.Count == 0)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }

            T element = _queue![i];
            i++;

            return element;
        }

        public MyQueue()
        {
            _queue = new List<T>();
        }

        public int Size()
        {
            if (_queue == null)
            {
                return 0;
            }

            return _queue.Count;
        }

        public bool IsEmpty()
        {
            return _queue?.Count == 0;
        }
    }

}
