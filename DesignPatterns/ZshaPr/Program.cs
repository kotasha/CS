using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;

namespace ZshaPr
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RealObject
            #region fact
            RealObject ro = new RealObject();
            Console.WriteLine("Give the number to get factorial");
            Console.WriteLine(ro.fact(int.Parse(Console.ReadLine())));

            //Uri serviceUri = new Uri("http://ppcservices.thomsonreuters.com/ContentLocator/GetLatestDisclosure.asmx");
            //Console.WriteLine(serviceUri.Host);
            #endregion
            /////////////////////////////////////////////////
            #region String common elements
            Console.WriteLine("String1");
            string st1=Console.ReadLine();
            Console.WriteLine("String2");
            string st2=Console.ReadLine();
            Console.WriteLine("String Common elements {0}", ro.StrDuplicates(st1, st2));
            #endregion
            /////////////////////////////////////////////////
            #region Duplicates in String
            Console.WriteLine("String3");
            string st3 = Console.ReadLine();
            Console.WriteLine("String Common elements {0}", ro.DuplicatesInString(st3));
            #endregion
            /////////////////////////////////////////////////
            #region multidimensional arrays
            int[, ,] array3Da = new int[2, 2, 3] 
                                {      { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                       { { 7, 8, 9 }, { 10, 11, 12 } }
                                };

            int[, , ,] array4Da = new int[2, 2, 2, 3] {
                                                        {      { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                                               { { 7, 8, 9 }, { 10, 11, 12 } }
                                                        }
                                                        ,
                                                        {      { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                                               { { 7, 8, 9 }, { 10, 11, 12 } }
                                                        }
                                                        };
            #endregion
            /////////////////////////////////////////////////
            #region Stack
            Stack st = new Stack();
            st.push(1);
            st.push(11);
            st.push(111);
            int i = st.pop().Value;
            Console.WriteLine("Sorted Values using Stack");
            Console.WriteLine("poped val " + i);
            i = st.pop().Value;
            Console.WriteLine("poped val     " + i);
            Console.ReadLine();
            #endregion
            ///////////////////////////// QUEUE ////////////////////////
            # region Queue
            Queue qu = new Queue();
            qu.add(111);
            qu.add(11);
            qu.add(1);
            i = qu.delete().Value;
            Console.WriteLine("Sorted Values using Queue");
            Console.WriteLine("poped val " + i);
            i = qu.delete().Value;
            Console.WriteLine("poped val " + i);
            Console.ReadLine();
            #endregion
            ///////////////////////////// TREE TRAVERSAL //////////////
            #region Tree Traversal
            //And inorder like this:

            //visit left
            //print current
            //visit right

            //Preorder traversal goes like this:
            //print current.
            //visit left
            //visit right



            //Postorder traversal goes like this:
            //visit left
            //visit right
            //print current.




            //            Example
            //        7
            //     /     \
            //    3      10
            //   / \     / \
            //  2   5   9   12
            //             /
            //            11

            //            Inorder is: 2 3 5 7 9 10 11 12
            //            Preorder is 7 3 2 5 10 9 12 11
            //          Postorder is: 2 5 3 9 11 12 10 7


            var child513 = new Node<int> { Data = 300 };
            var child512 = new Node<int> { Data = 200 };
            //var child51 = new Node<int> { Data = 10, RightChild = child513 };
            //var child53 = new Node<int> { Data = 30 };
            //var child52 = new Node<int> { Data = 20, LeftChild = child512, RightChild = child53 };

            var child5 = new Node<int> { Data = 0 };
            var child1 = new Node<int> { Data = 1, LeftChild = child512, RightChild = child513 };
            var child2 = new Node<int> { Data = 2 };
            var child3 = new Node<int> { Data = 3, LeftChild = child1, RightChild = child5 };
            var root = new Node<int> { Data = 4, LeftChild = child3, RightChild = child2 };
            Console.WriteLine("Pre Order Traversal");
            foreach (var value in root)
                Console.WriteLine(value);
            Console.ReadLine();
            #endregion
            ///////////////////////////// QUICK SORT //////////////////
            #region QuickSort
            Console.WriteLine("sorted elements to QuickSort");
            List<int> unsorted = new List<int> { 9, 5, 8, 7, 6 };
            QuickSort qs = new QuickSort(unsorted);
            Console.ReadLine();
            #endregion
            ///////////////////////////// BUBBLE SORT ////////////////
            #region Bubblesort
            Console.WriteLine("sorted elements to BubbleSort");
            //List<int> unsorted = new List<int> { 9, 5, 8, 7, 6 };
            //BubbleSort Bs = new BubbleSort(unsorted);
            BubbleSort bs = new BubbleSort(new List<int> { 9, 1, 40, 5, 8 });
            Console.ReadLine();
            #endregion
            ///////////////////////////// MERGE SORT /////////////////
            #region MergeSort
            Console.WriteLine("sorted elements to MergeSort");
            MergeSort ms = new MergeSort(new List<int> { 9, 1, 40, 5, 8 });
            Console.ReadLine();
            #endregion
            ///////////////////////////// HEAP SORT ////////////////
            #region HeapSort
            Console.WriteLine("sorted elements to Heap Sort");
            HeapSort hs = new HeapSort(new List<int> { 9, 0, 4, 5, 8, 1, 7 });
            Console.ReadLine();
            #endregion
            ///////////////////////////// Insertion SORT ////////////
            #region InsertionSort
            Console.WriteLine("sorted elements to Insertion Sort");
            InsertionSort ist = new InsertionSort(new List<int> { 9, 0, 281, 8, 1, 7 });
            Console.ReadLine();
            #endregion
            ///////////////////////////// Selection SORT /////////////
            #region SelectionSort
            Console.WriteLine("sorted elements to Selection Sort");
            SelectionSort Ss = new SelectionSort(new List<int> { 9, 0, 281, 8, 1, 7 });
            Console.ReadLine();
            #endregion
            ///////////////////////////// Shell SORT /////////////
            #region Shell Sort
            Console.WriteLine("sorted elements to Shell Sort");
            ShellSort Shs = new ShellSort(new List<int> { 9, 0, 281, 8, 1, 7 });
            Console.ReadLine();
            #endregion
            ///////////////////////////// Real Object/////////////
            #endregion
        }
    }

    class Stack
    {
        public int[] arr = new int[10];
        public int top;
        public Stack()
        {
            top = -1;
        }
        public void push(int a)
        {
            if (top == 9)
            {
                Console.WriteLine("stack is full");
                return;
            }
            top++;
            arr[top] = a;
        }
        public int? pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            int a = arr[top];
            top--;
            return a;
        }
    }
    class Queue
    {
        public int[] arr = new int[10];
        public int front, rear;
        public Queue()
        {
            front = rear = -1;
        }
        public void add(int a)
        {
            if (rear == 9)
            {
                Console.WriteLine("Queue full");
                return;
            }
            rear++;
            arr[rear] = a;
            if (front == -1)
                front = 0;
        }
        public int? delete()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue empty");
                return null;
            }
            int a = arr[front];

            if (front == rear)
                front = rear = -1;
            else
                front++;

            return a;
        }
    }
    class QuickSort
    {
        public QuickSort(List<int> a)
        {

            List<int> sorted = new List<int>();
            sorted = SortElements(a);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public List<int> SortElements(List<int> a)
        {
            Random rn = new Random();
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            if (a.Count <= 1)
                return a;
            int pos = rn.Next(a.Count);
            int pivot = a[pos];
            a.RemoveAt(pos);
         
            foreach (int x in a)
                if (x > pivot)
                    greater.Add(x);
                else
                    less.Add(x);
            return concat(SortElements(less), pivot, SortElements(greater));
        }
        public List<int> concat(List<int> a, int pivot, List<int> b)
        {
            List<int> sorted = new List<int>(a);
            sorted.Add(pivot);
            foreach (int i in b)
                sorted.Add(i);

            return sorted;
        }

    }
    class BubbleSort
    {
        public BubbleSort(List<int> a)
        {
            List<int> sorted = new List<int>();
            sorted = SortElements(a);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public List<int> SortElements(List<int> a)
        {
            int temp;
            for (int i = 1; i < a.Count; i++)
                for (int j = 0; j < a.Count - 1; j++)
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }

            return a;
        }
    }
    class MergeSort
    {
        public MergeSort(List<int> a)
        {
            List<int> sorted = new List<int>();
            sorted = SortElements(a);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public List<int> SortElements(List<int> a)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            if (a.Count <= 1)
                return a;
            int middle = a.Count / 2;
            for (int i = 0; i < middle; i++)
                left.Add(a[i]);
            for (int i = middle; i < a.Count; i++)
                right.Add(a[i]);

            left = SortElements(left);
            right = SortElements(right);

            if (left[left.Count - 1] <= right[0])
                return append(left, right);

            return merge(left, right);
        }
        public List<int> append(List<int> a, List<int> b)
        {
            List<int> result = new List<int>(a);
            foreach (int x in b)
                result.Add(x);
            return result;
        }
        public List<int> merge(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            while (a.Count > 0 && b.Count > 0)
            {
                if (a[0] < b[0])
                {
                    result.Add(a[0]);
                    a.RemoveAt(0);
                }
                else
                {
                    result.Add(b[0]);
                    b.RemoveAt(0);
                }
            }
            while (a.Count > 0)
            {
                result.Add(a[0]);
                a.RemoveAt(0);
            }

            while (b.Count > 0)
            {
                result.Add(b[0]);
                b.RemoveAt(0);
            }
            return result;
        }
    }
    class HeapSort
    {
        public HeapSort(List<int> a)
        {
            List<int> sorted = new List<int>();
            sorted = SortElements(a);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public List<int> SortElements(List<int> a)
        {
            //int i, temp;
            //for (i = (a.Count / 2 - 1); i >= 0; i--)
            //    sink(a, i, a.Count);

            //for (i = (a.Count - 1); i >= 1; i--)
            //{
            //    temp = a[0];
            //    a[0] = a[i];
            //    a[i] = temp;
            //    sink(a, 0, i - 1);
            //}
            //return a;

            int i;
            int temp;

            for (i = (a.Count / 2) - 1; i >= 0; i--)
            {
                siftDown(i, a.Count, a);
            }

            for (i = a.Count - 1; i >= 1; i--)
            {
                temp = a[0];
                a[0] = a[i];
                a[i] = temp;
                siftDown(0, i - 1, a);
            }

            return a;
        }
        //public void sink(List<int> a, int root, int asize)
        //{
        //    int done, maxchild, temp;
        //    done = 0;
        //    while ((root * 2 <= asize) && done == 0)
        //    {
        //        if (root * 2 == asize)
        //            maxchild = root * 2;
        //        else if (a[root * 2] > a[root * 2 + 1])
        //            maxchild = root * 2;
        //        else
        //            maxchild = root * 2 + 1;

        //        if (a[root] < a[maxchild])
        //        {
        //            temp = a[root];
        //            a[root] = a[maxchild];
        //            a[maxchild] = temp;
        //        }
        //        else
        //            done = 1;
        //    }

        //}
        //private int[] a = new int[100];
        //// number of elements in array
        //private int x;
        //// Heap Sort Algorithm
        //public void sortArray()
        //{
        //    int i;
        //    int temp;

        //    for (i = (x / 2) - 1; i >= 0; i--)
        //    {
        //        siftDown(i, x);
        //    }

        //    for (i = x - 1; i >= 1; i--)
        //    {
        //        temp = a[0];
        //        a[0] = a[i];
        //        a[i] = temp;
        //        siftDown(0, i - 1);
        //    }

        //}

        public void siftDown(int root, int bottom, List<int> a)
        {
            bool done = false;
            int maxChild;
            int temp;

            while ((root * 2 <= bottom) && (!done))
            {
                if (root * 2 == bottom)
                    maxChild = root * 2;
                else if (a[root * 2] > a[root * 2 + 1])
                    maxChild = root * 2;
                else
                    maxChild = root * 2 + 1;

                if (a[root] < a[maxChild])
                {
                    temp = a[root];
                    a[root] = a[maxChild];
                    a[maxChild] = temp;
                    root = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }

    }
    class InsertionSort
    {
        public InsertionSort(List<int> a)
        {
            List<int> sorted = new List<int>();
            sorted = SortElements(a);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public List<int> SortElements(List<int> a)
        {
            int i, j;
            for (i = 1; i < a.Count; i++)
            {
                IComparable value = a[i];
                j = i - 1;
                while (j >= 0 && (a[j].CompareTo(value) > 0))
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = (int)value;
            }

            return a;
        }

    }
    class SelectionSort
    {
        public SelectionSort(List<int> a)
        {
            List<int> sorted = new List<int>();
            sorted = SortElements(a);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public List<int> SortElements(List<int> a)
        {
            int i, j, min, temp;
            for (i = 0; i < a.Count - 1; i++)
            {
                min = i;
                for (j = i + 1; j < a.Count; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
            return a;
        }
    }
    class ShellSort
    {
        public ShellSort(List<int> a)
        {
            List<int> sorted = new List<int>();
            sorted = SortElements(a);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public List<int> SortElements(List<int> a)
        {

            int i, j, increment, temp;
            increment = 3;

            while (increment > 0)
            {
                for (i = 0; i < a.Count; i++)
                {
                    j = i;
                    temp = a[i];

                    while ((j >= increment) && (a[j - increment] > temp))
                    {
                        a[j] = a[j - increment];
                        j = j - increment;
                    }

                    a[j] = temp;
                }

                if (increment / 2 != 0)
                {
                    increment = increment / 2;
                }
                else if (increment == 1)
                {
                    increment = 0;
                }
                else
                {
                    increment = 1;
                }
            }

            return a;
        }

    }
    class RealObject
    {
        public RealObject()
        {

        }
        public  int fact(int a)
        {
            //try
            {
                if (a == 1)
                    return 1;

                
                return a * fact(a - 1);
                //throw new Exception();
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine("" + e.Message);
            //}
            //finally
            //{
            //    //throw new Exception();
            //}
        }
        public string StrDuplicates(string s1,string s2)
        {
            try
            {
                string s = null;
                for (int i = 0; i < s1.Length; i++)
                {
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (s1[i] == s2[j])
                        {
                            s = s + s2[j];
                            break;
                        }
                    }
                }
                throw new Exception();
                return s;
            }catch(Exception e)
            {
                throw new Exception();
            }
            finally
            {
                throw new Exception();
            }
        }
        public string DuplicatesInString(string s1)
        {
            string s = "";
            for (int i = 0; i < s1.Length;i++)
                for (int j = i+1; j < s1.Length;j++ )
                    if ((i != j) && s1[i] != s1[j])
                    {
                        bool alreadyExists = false;
                        for (int ik = 0; ik < s.Length; ik++)
                            if (s[ik] == s1[i])
                                alreadyExists = true;
                        if (!alreadyExists)
                        s = s + s1[i];
                    }
            return s;
        }
    }
    public class Node<T> : IEnumerable<T>
    {
        public Node<T> LeftChild { get; set; }

        public Node<T> RightChild { get; set; }

        public T Data { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            yield return Data;

            if (LeftChild != null)
            {
                foreach (var child in LeftChild)
                    yield return child;
            }
            if (RightChild != null)
            {
                foreach (var child in RightChild)
                    yield return child;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //public static IEnumerable<T> Preorder<T>(Node<T> root)
        //{
        //    var stack = new Stack<Node<T>>();
        //    stack.Push(root);

        //    while (stack.Count > 0)
        //    {
        //        var node = stack.Pop();
        //        yield return node.Data;
        //        if (node.RightChild != null)
        //            stack.Push(node.RightChild);
        //        if (node.LeftChild != null)
        //            stack.Push(node.LeftChild);
        //    }
        //}
    }
    //Non-recursive static method
}

