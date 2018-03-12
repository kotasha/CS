using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class Queue
    {
        public const int MAX = 10;
        int[] arr = new int[MAX];
        int front, rear;
        //initialize front and rear to -1
        public Queue()
        {
            front = -1;
            rear = -1;

        }
        
        //increment rear and add the new value at the incremented rear index of the arr, if front is -1 then change to zero when insertion successful
        public void Add(int item)
        {
            if (rear == MAX - 1)
            {
                Console.WriteLine("Queue is Full");
                return;
            }

            rear++;
            arr[rear] = item;

            if (front == -1)
                front = 0;
        }
        //delete the element if front not equal to -1 and then store the value to a temp var and increaes the front, if front and rear are equal then set both -1 else increment the front
        public int? Delete()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is empty");
                return null;
            }

            int data = arr[front];

            if (front == rear)
                front = rear = -1;
            else
                front++;

            return data;
        }
    }
}