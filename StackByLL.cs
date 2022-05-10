using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class StackByLL
    {
        private class Node
        {
            public int data;

            public Node link;
        }


        Node top;

        public StackByLL()
        {
            this.top = null;
        }



        public void push(int x)
        {
            Node temp = new Node();


            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            temp.data = x;

            temp.link = top;

            top = temp;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            // check for empty stack
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        // Utility function to pop top element from the stack
        public void pop() // remove at the beginning
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            // update the top pointer to
            // point to the next node
            top = (top).link;
        }

        public void display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {


                    Console.Write("{0}->", temp.data);

                    temp = temp.link;
                }
            }
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}