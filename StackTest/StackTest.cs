using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    internal class Stack<T>
    {
        private int top; // location of the top element
        private T[] elements; // array that stores stack elements

        // parameterless constructor creates a stack of the default size
        public Stack() : this(10)
        {
            //empty constructor: calls constructor of the line 21 to perform
        }
        // constructor creates a stack of specified number of elements
        public Stack(int stacksize)
        {
            if(stacksize <= 0)
            {
                throw new ArgumentException("stack size must be positive");
            }
            elements = new T[stacksize];
            top = -1; // Stack initially emty
        }
        //push element onto the atack ; if unsuccesfull
        public void Push(T pushValue)
        {
            if(top == elements.Length -1)
            {
                throw new FullStackExcepcion($"Stack is full, cannot push {pushValue}");
            }
            ++top;
            elements[top] = pushValue;
        }
        //return the top
        //
        public T Pop()
        {
            if(top == -1)
            {
                throw new EmpttyStackException("Stack is mpty, cannot pop");
            }
            --top;
            return elements[top +1]; // return top value
        }
    }
}
