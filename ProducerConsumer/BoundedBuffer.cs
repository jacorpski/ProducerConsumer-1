using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class BoundedBuffer
    {
        private int _capacity;

        private Queue<int> _queue; 

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public BoundedBuffer(int capacity)
        {
            Capacity = capacity;

            _queue = new Queue<int>(capacity);
        }

        public Boolean IsFull()
        {
            if (Capacity > _queue.Count)
                return false;

            return true;
        }

        public void Put(int element)
        {
            _queue.Enqueue(element);
        }

        public int Take()
        {
            return _queue.Dequeue();
        }
    }
}
