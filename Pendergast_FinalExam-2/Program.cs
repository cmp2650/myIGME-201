using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_FinalExam_1
{
    public class MyQueue
    {
        private List<int> queue;

        public MyQueue()
        {
            queue = new List<int>();
        }

        public void Enqueue(int n)
        {
            queue.Add(n);
        }

        public int Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int element = queue[0];
            queue.RemoveAt(0);
            return element;
        }

        public int Peek()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return queue[0];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());  

            queue.Enqueue(40);

            Console.WriteLine(queue.Peek()); 

            Console.WriteLine(queue.Dequeue());  
            Console.WriteLine(queue.Dequeue());  

            // Trying to dequeue an empty queue will throw an exception
            Console.WriteLine(queue.Dequeue());  
        }
    }
}
