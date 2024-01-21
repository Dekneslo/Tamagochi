using System;
using System.Collections.Generic;
using System.Text;

namespace Test1712
{
    class ParamList
    {
        private ParamNode _head;
        private ParamNode _tail;
        private int _count;
        public ParamNode Head
        {
            get { return _head; }
            set { _head = value; }
        }
        public ParamNode Tail
        {
            get { return _tail; }
            set { _tail = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public void Add(string name, int mood, int satiety, int forces, int weight, int fluff_num)
        {
            ParamNode node = new ParamNode(name, mood, satiety, forces, weight, fluff_num);
            if (Head == null)
                Head = node;
            else
                Tail.Next = node;
            Tail = node;
            Count++;
        }
        public bool Delete(string name)
        {
            ParamNode current = Head;
            ParamNode prev = null;
            while (current != null)
            {
                if (current.Name == name)
                {
                    if (prev != null)
                    {
                        prev.Next = current.Next;
                        if (current.Next == null)
                            Tail = prev;
                    }
                    else
                    {
                        Head = Head.Next;
                        if (Head == null)
                            Tail = null;
                    }
                    Count--;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }

        public int[][] AllToArray()
        {
            int[][] paramCount = new int[5][];
            int counter = 0;
            paramCount[0] = new int[Count];
            paramCount[1] = new int[Count];
            paramCount[2] = new int[Count];
            paramCount[3] = new int[Count];
            paramCount[4] = new int[Count];
            ParamNode current = Head;
            ParamNode prev = null;
            while (current != null)
            {
                    paramCount[0][counter] = current.Mood;
                    paramCount[1][counter] = current.Satiety;
                    paramCount[2][counter] = current.Forces;
                    paramCount[3][counter] = current.Weight;
                    paramCount[4][counter] = current.Fluff_num;
                
                prev = current;
                current = current.Next;
                counter++;
            }
            return paramCount;
        }

        public void ArrayMediumAndAVG(int[][] param)
        {
            int[] sum = new int[5];
            double[] mediana = new double[5];
            double[] avg = new double[5];

            for (int i = 0; i < sum.Length; i++)
            {
                foreach (int j in param[i])
                    sum[i] += j;
            }

            for (int i = 0; i < mediana.Length; i++)
            {
                mediana[i] = ArrayMediana(param[i]);
            }

            for (int i = 0; i < avg.Length; i++)
            {
                avg[i] = (double)sum[i] / param[i].Length;
            }

            Console.WriteLine("Mediana:");
            foreach (double i in mediana)
            {
                Console.Write("{0}; ", i);
            }
            Console.WriteLine("\nAVG: ");
            foreach (double i in avg)
            {
                Console.Write("{0}; ", i);
            }
        }

        public double ArrayMediana(int[] array)
        {
            int div2 = array.Length / 2;
            Array.Sort(array);
            if (array.Length % 2 != 0)
                return (double)array[div2];
            else
                return ((double)array[div2 - 1] + array[div2]) / 2;
        }
    }
}
