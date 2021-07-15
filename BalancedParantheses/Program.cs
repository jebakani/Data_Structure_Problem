using System;

namespace BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            int unbalanced=0;
            StackImplementation<char> stack = new StackImplementation<char>();
            string equation = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            for(int i=0;i<equation.Length;i++)
            {
                if(equation[i].Equals('('))
                {
                    stack.Push(equation[i]);
                }
                else if(equation[i].Equals(')'))
                {
                    unbalanced = stack.pop();
                    if(unbalanced==1)
                    {
                        break;
                    }
                }
            }
            if(stack.CheckTop()==1)
            {
                Console.WriteLine("Equation is balanced");
            }
            else if(stack.CheckTop()==0 && unbalanced==0)
            {
                Console.WriteLine("Equation is unbalanced");
            }
         }
    }
}
