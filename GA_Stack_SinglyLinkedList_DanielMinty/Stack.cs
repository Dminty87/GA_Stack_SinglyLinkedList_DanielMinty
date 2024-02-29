using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Stack_SinglyLinkedList_DanielMinty
{
    internal class Stack<T>
    {
        //Keep track of the top node and the number of nodes
        private StackNode<T> top;
        private int count;

        //Public property for count
        public int Count { get { return count; } }

        //Constructor creates an empty stack
        public Stack()
        {
            top = null;
            count = 0;
        }
        
        //Push method adds an item to the top of the stack
        public void Push(T value)
        {
            //If the stack is empty, create a new node as the top node
            if (top == null)
            {
                top = new StackNode<T>(value);
                count = 1;
            }
            else
            {//If the stack is not empty,
                //create a new node and insert it as the top node
                top = new StackNode<T>(value, top);
                //Increment count
                count++;
            }
        }

        //Return the top value and remove it from the stack
        public T Pop()
        {
            //If the stack is empty, throw exeption
            if (top == null)
            {
                throw new InvalidOperationException("The Stack is empty.");
            }
            //The stack is not empty

            //save the top value to be returned
            T oldTopValue = top.Value;
            //Remove the old top node from the stack, assigning the new top node
            top = top.Next;
            //decrement count
            count--;
            //return the value
            return oldTopValue;
        }

        //Return the top value without removing it from the stack
        public T Peek()
        {
            //If the stack is empty, throw exeption
            if (top == null)
            {
                throw new InvalidOperationException("The Stack is empty.");
            }
            //The stack is not empty

            //Return the value of the top node
            return top.Value;
        }

        class StackNode<T>
        {
            //Store the node's value and the next node in the stack
            private T value;
            private StackNode<T> next;

            //Properties
            public T Value { get { return value; } set { this.value = value; } }
            public StackNode<T> Next { get { return next; } set { next = value; } }

            //Constructor creates a node with the given value
            public StackNode(T value)
            {
                this.value = value;
                next = null;
            }

            //Creates a node with the given value and given next node
            public StackNode(T value, StackNode<T> next)
            {
                this.value = value;
                this.next = next;
            }

        }//Class StackNode
    }//Class Stack
}//Namespace
