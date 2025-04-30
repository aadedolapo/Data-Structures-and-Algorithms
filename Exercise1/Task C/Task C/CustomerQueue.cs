using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class CustomerQueue
    {
        //members
        private readonly int maxsize = 10;
        private Customer[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;

        //constructors
        public CustomerQueue()
        {
            store = new Customer[maxsize];
        }
        public void Enqeue(Customer value)
        {

            store[tail] = value;
            tail++;
            numItems++;
        }
        public void Dequeue()
        {
            numItems--;
            store[head] = null;
            head++;
        }
        public Customer Peek()
        {
            return store[head];
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }
        public bool IsFull()
        {
            return numItems == maxsize;
        }

        public Customer[] Store
        {
            get { return store; }
            set { store = value; }
        }
        public int Count()
        {
            return numItems;
        }

        public void Reverse(int k)
        {
            for (int i = head; i < k; i++)
            {
                int j = k + head - 1;
                var temp = store[i];
                store[i] = store[j];
                store[j] = temp;
                k--;
            }
        }
    }
}
