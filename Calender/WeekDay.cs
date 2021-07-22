using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    //create the class of Week and Days 
    public class WeekDayNode
    {
        public WeekDayNode Next;
        public string day;
        public int date;
        public WeekDayNode(string day,int date)
        {
            this.date = date;
            this.day = day;
            this.Next = null;
        }
    }
    class WeekDay
    {
        
        CustomStack stack1 = new CustomStack();
        CustomStack stack2 = new CustomStack();
        //add the current node at the begining of the list
        public void Enqueue(string day,int date)
        {
            WeekDayNode weekDay = new WeekDayNode(day, date);
            // Move all elements from s1 to s2
            while (stack1.Count()>0)
            {
                stack2.Push(stack1.Pop());
            }
            // Push item into s1
            stack1.Push(weekDay);
            // Push everything back to s1
            while (stack2.Count() > 0)
            {
                stack1.Push(stack2.Pop());
                //s2.Pop();
            }
        }
        //remove the element fm 
        public WeekDayNode Dequeue()
        {
            //return top of stack 1
            if (stack1.Count() == 0)
            {
                return null;

            }
            return stack1.Pop();
        }
    }
}
