using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    
    class Stack
    {
       //int Max[]= int[10];
       public const int max=10;
       int[] arr = new int[max];
       int top;

        //initialize the top to -1 in constructor
       public Stack()
      {
            top = -1;
      }
        //when adding the element to stack u need to increase the top and then assign the value in the array at relative index(@ top value)
        //if top = array length -1 then Stack is full
       public void Push(int item)
      {
             if(top == max-1)
            {
                  //cout<<endl<< "Stack is full";
                 Console.WriteLine("Full Stack");
                   return;
            }
 
            top++;
            arr[top] = item;
      }
       // if top is at -1 and then then if you try to remove then stack would be empty
        //then assign the top index value from the array to the returning variable and decrement the top
       public int? Pop()
      {
             if(top == -1)
            {

                 Console.WriteLine("Empty Stack");
                   return null;
            }
 
        int data = arr[top];
            top--;
 
             return data;
      }

 
    }

}
