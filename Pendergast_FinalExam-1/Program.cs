using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_FinalExam_1
{
    public class MyStack
    {
        private List<int> stack;

        public MyStack()
        {
            stack = new List<int>();
        }

        public void Push(int n)
        {
            stack.Add(n);
        }

        public int Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int lastIndex = stack.Count - 1;
            int element = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return element;
        }

        public int Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return stack[stack.Count - 1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop());  
            Console.WriteLine(stack.Pop()); 

            stack.Push(40);

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());

            // Trying to pop an empty stack will throw an exception
            Console.WriteLine(stack.Pop()); 
        }
    }
}
