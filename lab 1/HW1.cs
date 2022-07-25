using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class HW1
    {
        static int MinElement(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < min)
                    min = array[i];
            return min;
        }
        static int MaxElement(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }
        static void reduceQueue(int[] array,int element)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] -= element;
        }
        public static long QueueTime(int[] customers, int n)
        {
            int[] queues = new int[n];
            int time=0;
           /* for (int i = 0; i < queues.Length; i++)
                queues[i] = customers[i];
            int element1 = MinElement(queues);
            reduceQueue(queues, element1);
            time += element;*/
            for (int i= 0; i<customers.Length;)
            {
                int element = MinElement(queues);
                reduceQueue(queues, element);
                for (int q = 0; q < queues.Length; q++)
                    if(queues[q]==0)
                    {
                        queues[q] = customers[i];
                        i++;
                        //time += element;
                    }
                time += element;
             /*  int index= MinElementIndex(queues);
               reduceQueue(queues, index);
               time += queues[index];
                queues[index] = customers[i];*/
            }
            return time+ MaxElement(queues);
        }
    }
}
