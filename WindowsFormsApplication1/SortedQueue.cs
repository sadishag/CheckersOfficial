using System;
using System.Collections.Generic;

// Created to store AI moves in a queue
namespace WindowsFormsApplication1
{
    public class SortedQueue
    {
        List<Tuple<int, Tuple<int,int>, Boolean, Colour, Tuple<int,int>>> queue = new List<Tuple<int,Tuple<int,int>,bool,Colour,Tuple<int,int>>>();
 
        public void enqueue(Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>> item)
        {   
          queue.Add(item);
        }

        public Boolean isEmpty()
        {
            if (this.queue.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       public Tuple <int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>> top()
       {
           
           return queue[0];
       }
  
        public void sort()
        {
            int n = queue.Count;
            Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>> [] temp = new Tuple<int, Tuple<int, int>, Boolean, Colour, Tuple<int, int>> [n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = queue[i]; ///might not work
            }

            Array.Sort(temp);
            queue.Clear();

            for (int i = 0; i < n; i++)
            {
                queue.Add(temp[i]);
            }

        }
      


       


    }
}
