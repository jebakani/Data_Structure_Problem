using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    class StackNode
    {
        public StackNode Next;
        public WeekDayNode week;
        public StackNode(WeekDayNode node)
        {
            this.week = node;
            Next = null;
        }
    }

    class CustomStack
    {
        StackNode top;
        public void Push(WeekDayNode node)
        {
            StackNode stack = new StackNode(node);
            if (top == null)
            {
                top = stack;
            }
            else
            {
                stack.Next = top;
                top = stack;
            }
        }
        //remove the element from stack
        public WeekDayNode Pop()
        {
            WeekDayNode temp=null;
            if (top == null)
            {
                Console.WriteLine("No element to pop");
            }
            else
            {
                temp = top.week;
                top = top.Next;
            }
            return temp;
        }

        public int Count()
        {
            int count = 0;
            if(top==null)
            {
                return count;
            }
            else
            {
                StackNode temp =top;
                while(temp!=null)
                {
                    temp = temp.Next;
                    count++;
                }
            }
            return count;
        }
    }
}
