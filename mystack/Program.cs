using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mystack
{
    class Program
    {
        class stack2
        {
            static int ARR_LENGTH = 10;
            private int[] stackArr;
            private int pos;

            public stack2()
            {
                this.stackArr = new int[ARR_LENGTH];
                this.pos = -1;
            }
            
            //check if stack is empty
            public bool isEmpty()
            {
                if (pos == -1)
                    return true;
                else
                    return false;
            }
            //check if stack is full return bool
            public bool isFull()
            {
                if (pos == stackArr.Length - 1)
                    return true;
                else
                    return false;
            }
            public bool push(int userInput)
            {
                if (isFull())
                {
                    Console.WriteLine("Stack is full");
                    return false;
                }
                stackArr[++pos] = userInput;
                return true;
            }
            public bool pop()
            {
                if(isEmpty())
                {
                    Console.WriteLine("Stack is Empty");
                    return false;
                }
                stackArr[pos--] = int.MinValue;
                return true;
            }
            public void display()
            {
                if(isEmpty())
                {
                    Console.WriteLine("Stack is Empty");
                }
                for(int i = pos; i>-1; i--)
                {
                    Console.WriteLine(stackArr[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            stack2 oneStack = new stack2();
            Console.WriteLine("try to display stack");
            oneStack.display();
            Console.WriteLine("try to pop top of the stack");
            oneStack.pop();

            Console.WriteLine("push 10 values in to the stack");
            for (int i = 0; i < 10; i++)
                oneStack.push(i);

            Console.WriteLine("try to display stack");
            oneStack.display();

            Console.WriteLine("try to push another integer to the stack");
            oneStack.push(100);

            Console.WriteLine("pop the stack twice");
            oneStack.pop();
            oneStack.pop();

            Console.WriteLine("displaying stack");
            oneStack.display();

            Console.ReadKey();

            
        }
    }
}
