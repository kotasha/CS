using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            #region Stack
                Stack s= new Stack();
                s.Push(1);
                s.Push(2);
                s.Push(3);

                int i =s.Pop().Value;
                Console.WriteLine("Item Popped"+ i);
                i = s.Pop().Value;
                Console.WriteLine("Item Popped" + i);
                Console.ReadLine();
                #endregion

            #region Queue
                 Queue q= new Queue();
                  q.Add(1);
                  q.Add(2);
                  q.Add(3);
                    i = q.Delete().Value;
                  //cout<<endl<< "item="" deleted="<<i<<<span class=" hiddenspellerror"="" pre="">endl;
                     Console.WriteLine("Item Popped"+ i);
                  i = q.Delete().Value;
                  //cout<<endl<< "Item deleted = "<<i<<endl;
                     Console.WriteLine("Item Popped"+ i);
                     Console.ReadLine();
             #endregion
        }
    }
}
