using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    internal class CustomerQueue
    {
        //members
        private readonly int maxsize = 20;//constant value that can only be accessed and modified within the containing class, and once it is initialized, it cannot be changed. 
        private string[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;

        //constructors
        public CustomerQueue()
        {
            store = new string[maxsize];
        }
        
        public void Enqeue(string value)
        {

            store[tail] = value;
            tail++;
            numItems++;

            // checks if the  queue is already full , we start from the top again
            if (tail == maxsize)
            {
                tail = 0;
            }
        }
        public void Dequeue()
        {
            numItems--;
            store[head] = null;
            head++;

            // checks if the queue is already empty
            if (head == maxsize)
            {
                head = 0;
            }
            //return item;   //should return the value removed
        }
        public string Peek()
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
        public string[] Store
        {
            get { return store; }
            set { store = value; }
        }

        public int Count()
        {
            return numItems;
        }
    }
}
