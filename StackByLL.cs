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
    }
}