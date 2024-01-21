using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pet_Lib7
{

    public class Pet
    {
        string name;//Имя
        int mood;//Настроение(в процентах)
        int satiety;//Уровень сытости(проценты)
        int forces;//Силы(проценты)
        int weight;//Вес
        int flufy;
        string fluff;
        int testing1;
        int testing2;
        int testing3;
        int smert1;
        int smert2;
        int smert3;

        Random r = new Random();
        //параметр максимум увеличение/уменьшение 
        public class PetException : Exception
        {
            public PetException(string message)
            : base(message) { }
        }
        //public class ParamNode : Pet
        //{

        //    private ParamNode _next;
        //    public ParamNode Next
        //    {
        //        get { return _next; }
        //        set { _next = value; }
        //    }
        //    private string _name;
        //    private int _mood;
        //    private int _satiety;
        //    private int _forces;
        //    private int _weight;
        //    private int _flufy;
        //    public string _Name
        //    {
        //        get { return _name; }
        //        set { _name = value; }
        //    }
        //    public int Mood
        //    {
        //        get { return _mood; }
        //        set { _mood = value; }
        //    }
        //    public int Satiety
        //    {
        //        get { return _satiety; }
        //        set { _satiety = value; }
        //    }
        //    public int Forces
        //    {
        //        get { return _forces; }
        //        set { _forces = value; }
        //    }
        //    public int Weight
        //    {
        //        get { return _weight; }
        //        set { _weight = value; }
        //    }
        //    public int Flufy
        //    {
        //        get { return _flufy; }
        //        set { _flufy = value; }
        //    }


        //    public ParamNode(string name, int mood, int satiety, int forces, int weight, int flufy)
        //    {
        //        Name = name;
        //        Mood = mood;
        //        Satiety = satiety;
        //        Forces = forces;
        //        Weight = weight;
        //        Flufy = flufy;
        //    }

        //    public ParamNode(ParamNode nextnode, string name, int mood, int satiety, int forces, int weight, int fluff_num) : this(name, mood, satiety, forces, weight, fluff_num)
        //    {
        //        Next = nextnode;
        //    }
        //}
        //public class ParamList : Pet
        //{
        //    private ParamNode _head;
        //    private ParamNode _tail;
        //    private int _count;
        //    public ParamNode Head
        //    {
        //        get { return _head; }
        //        set { _head = value; }
        //    }
        //    public ParamNode Tail
        //    {
        //        get { return _tail; }
        //        set { _tail = value; }
        //    }
        //    public int Count
        //    {
        //        get { return _count; }
        //        set { _count = value; }
        //    }

        //    public void Add(string name, int mood, int satiety, int forces, int weight, int flufy)
        //    {
        //        ParamNode node = new ParamNode(name, mood, satiety, forces, weight, flufy);
        //        if (Head == null)
        //            Head = node;
        //        else
        //            Tail.Next = node;
        //        Tail = node;
        //        Count++;
        //    }

        //    public int[][] AllToArray()
        //    {
        //        int[][] paramCount = new int[5][];
        //        int counter = 0;
        //        paramCount[0] = new int[Count];
        //        paramCount[1] = new int[Count];
        //        paramCount[2] = new int[Count];
        //        paramCount[3] = new int[Count];
        //        paramCount[4] = new int[Count];
        //        ParamNode current = Head;
        //        ParamNode prev = null;
        //        while (current != null)
        //        {
        //            paramCount[0][counter] = current.Mood;
        //            paramCount[1][counter] = current.Satiety;
        //            paramCount[2][counter] = current.Forces;
        //            paramCount[3][counter] = current.Weight;
        //            paramCount[4][counter] = current.Flufy;

        //            prev = current;
        //            current = current.Next;
        //            counter++;
        //        }
        //        return paramCount;
        //    }

        //    public void ArrayMediumAndAVG(int[][] param)
        //    {
        //        int[] sum = new int[5];
        //        double[] mediana = new double[5];
        //        double[] avg = new double[5];

        //        for (int i = 0; i < sum.Length; i++)
        //        {
        //            foreach (int j in param[i])
        //                sum[i] += j;
        //        }

        //        for (int i = 0; i < mediana.Length; i++)
        //        {
        //            mediana[i] = ArrayMediana(param[i]);
        //        }

        //        for (int i = 0; i < avg.Length; i++)
        //        {
        //            avg[i] = (double)sum[i] / param[i].Length;
        //        }

        //        //Console.WriteLine("Mediana:");
        //        foreach (double i in mediana)
        //        {
        //            Console.Write("{0}; ", i);
        //        }
        //        //Console.WriteLine("\nAVG: ");
        //        foreach (double i in avg)
        //        {
        //            Console.Write("{0}; ", i);
        //        }
        //    }

        //    public double ArrayMediana(int[] array)
        //    {
        //        int div2 = array.Length / 2;
        //        Array.Sort(array);
        //        if (array.Length % 2 != 0)
        //            return (double)array[div2];
        //        else
        //            return ((double)array[div2 - 1] + array[div2]) / 2;
        //    }
        //}


        //public class Median
        //{
        //    public static void Main()
        //    {
        //        int i = 0, j = 0, n = 0, max = 0;

        //        float median, temp;

        //        float[] a = new float[max];

        //        /* Reading array elements */
        //        Console.WriteLine("Input " + n + " values");
        //        for (i = 0; i < n; i++)
        //        {
        //            a[i] = float.Parse(Console.ReadLine());

        //        }

        //        temp = 0;
                /* sorting */
//                for (i = 0; i<n - 1; i++)
//                {
//                    for (j = 0; j<n - i - 1; j++)
//                    {
//                        if (a[j] < a[j + 1])
//                         {
//                            temp = a[j];
//                            a[j] = a[j + 1];
//                            a[j + 1] = temp;
//                        }
//}
//                }


        //        /* calculation median */
        //        if (n % 2 == 0)
        //        {
        //            median = (a[(n / 2) - 1] + a[(n / 2)]) / 2.0F;
        //        }
        //        else
        //        {
        //            median = a[(n / 2)];
        //        }

        //        /*printing result */

        //        for (i = 0; i < n; i++)
        //            Console.WriteLine(a[i] + "\t");

        //        Console.WriteLine("Median is " + median);
        //        Console.ReadKey();
        //    }
        //}



        //public decimal GetMedian(this IEnumerable<int> source)
        //{
        //    // Create a copy of the input, and sort the copy
        //    int[] temp = source.ToArray();
        //    Array.Sort(temp);
        //    int count = temp.Length;
        //    if (count == 0)
        //    {
        //        throw new InvalidOperationException("Empty collection");
        //    }
        //    else if (count % 2 == 0)
        //    {
        //        // count is even, average two middle elements
        //        int a = temp[count / 2 - 1];
        //        int b = temp[count / 2];
        //        return (a + b) / 2m;
        //    }
        //    else
        //    {
        //        // count is odd, return the middle element
        //        return temp[count / 2];
        //    }
        //}
        //public int GetMode(this IEnumerable<int> list)
        //{
        //    // Initialize the return value
        //    int mode = default(int);
        //    // Test for a null reference and an empty list
        //    if (list != null && list.Count() > 0)
        //    {
        //        // Store the number of occurences for each element
        //        Dictionary<int, int> counts = new Dictionary<int, int>();
        //        // Add one to the count for the occurence of a character
        //        foreach (int element in list)
        //        {
        //            if (counts.ContainsKey(element))
        //                counts[element]++;
        //            else
        //                counts.Add(element, 1);
        //        }
        //        // Loop through the counts of each element and find the 
        //        // element that occurred most often
        //        int max = 0;
        //        foreach (KeyValuePair<int, int> count in counts)
        //        {
        //            if (count.Value > max)
        //            {
        //                // Update the mode
        //                mode = count.Key;
        //                max = count.Value;
        //            }
        //        }
        //    }
        //    return mode;
        //}

        List<Pet> ves = new List<Pet>();
        public List<Pet> Ves
        {
            get { return ves; }
            set { ves = value; }
        }
      
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new PetException("Ой, а как зовут-то?");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Flufy
        {
            get { return flufy; }
            set { flufy = value; }
        }
        public int Mood
        {
            get { return mood; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Настроение не может быть меньше или =0");
                }
                else
                {
                    mood = value;
                }
            }
        }
        public int Satiety
        {
            get { return satiety; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Сытость не может быть меньше или =0");
                }
                else
                {
                    satiety = value;
                }
            }
        }
        public int Forces
        {
            get { return forces; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Силы не может быть меньше или =0");
                }
                else
                {
                    forces = value;
                }
            }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Вес не может быть меньше или =0");
                }
                else
                {
                    weight = value;
                }
            }
        }
        public string Fluff
        {
            get { return fluff; }
            set { fluff = value; }
        }
        public int Testing1
        {
            get { return testing1; }
            set
            {
                testing1 = value;
                if (value> Mood)
                    throw new PetException("Питомец может сделать dead");            
            }
        }
        public int Testing2
        {
            get { return testing2; }
            set
            {
                testing2 = value;
                if (value > Satiety)
                    throw new PetException("Питомец может сделать dead");
            }
        }
        public int Testing3
        {
            get { return testing3; }
            set
            {
                testing3 = value;
                if (value > Forces)
                    throw new PetException("Питомец может сделать dead");
            }
        }


        public int Smert1
        {
            get { return smert1; }
            set
            {
                if (Mood <= 0)
                {
                    throw new PetException("Он сдох >:(");
                }
                else
                {
                    smert1 = Mood;
                }
            }
        }
        public int Smert2
        {
            get { return smert2; }
            set
            {
                if (Satiety <= 0)
                {
                    throw new PetException("Он сдох >:(");
                }
                else
                {
                    smert2 = Satiety;
                }
            }
        }
        public int Smert3
        {
            get { return smert3; }
            set
            {
                if (Forces <= 0)
                {
                    throw new PetException("Он сдох >:(");
                }
                else
                {
                    smert3 = Forces;
                }
            }
        }
        public virtual string Info()
        {
            return String.Format("\nИмя Питомца: {0}\nВес: {1}\nНастроение: {2}\nСытость: {3}\nСилы: {4}\nСтепень пушистости: {5}\nПушистость: {6}",Name, Weight, Mood, Satiety, Forces, Fluff, Flufy);
            //return "\nИмя Питомца: " + Name + "\nВес: " + Weight + "\nНастроение: " + Mood + "\nСытость: " + Satiety + "\nСилы: " + Forces + "\nСтепень пушистости: " + Fluff + "";
        }
        public void Sherst1()// Пушистость Лысый шерсть в мм
        {
            Flufy = r.Next(0,6);
        }
        public void Sherst2()// Пушистость Короткошерстный шерсть в мм
        {
            Flufy = r.Next(6,11);
        }
        public void Sherst3()// Пушистость Среднешерстный шерсть в мм
        {
            Flufy = r.Next(11,31);
        }
        public void Sherst4()// Пушистость Длинношерстный шерсть в мм
        {
            Flufy = r.Next(51,101);
        }
        public void Sherst5()// Пушистость Кудрявый шерсть в мм
        {
            Flufy = r.Next(31,51);
        }
        /// <summary>
        /// Вычисляет процент Настроения и сил
        /// </summary>
        /// <param name="x"> параметр в рандоме для настроения</param>
        /// <param name="z">параметр в рандоме для силы</param>
        /// <returns></returns>
        public void Caress(int x, int z) //приласкать(улучшается настроение и увеличиваются силы)
        {

            Forces = Math.Min(Forces + r.Next(1, z), 100);
            Mood = Math.Min(Mood + r.Next(1, x), 100);
        }
        /// <summary>
        /// Вычисляет процент Настроения,сытости и сил 
        /// </summary>
        /// <param name="x">параметр в рандоме для настроения</param>
        /// <param name="y">параметр в рандоме для сытости</param>
        /// <param name="z">параметр в рандоме для силы</param>
        /// <returns></returns>
        public void Play(int x, int y, int z)// поиграть(улучшается настроение, уменьшаются силы и сытость)
        {

            Mood = Math.Min(Mood + r.Next(1, x), 100);
            Forces -= r.Next(1, z);
            Satiety -= r.Next(1, y);
        }
        
        /// <summary>
        /// Вычисляет процент Настроения и сытости
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>     

        public virtual void Feed(int x, int y, int f)// покормить(увеличивается сытость и вес) 
        {
            Satiety += r.Next(1, y);
            Weight += r.Next(1, f);
        }

        public void Train(int x, int y, int z)// дрессировать(уменьшаются все параметры)
        {
            Mood -= r.Next(1, x);
            Forces -= r.Next(1, z);
            Satiety -= r.Next(1, y);
        }

        public int Test1(int x)
        {
            if (x >= Mood)
            {
                throw new PetException("Следующий ход может убить питомца");
            }
            else
            {
                Mood +=0;
            }
            return Mood;
            //if (x >= Mood) return true;//вернуть 1-сообщение о вероятности убить питомца
            //else return false;//все хорошо =)
        }
        public int Test2(int y)
        {
            if (y >= Satiety)
            {
                throw new PetException("Следующий ход может убить питомца");
            }
            else
            {
                Satiety += 0;
            }
            return Satiety;
        }
        public int Test3(int z)
        {
            if (z >= Forces)
            {
                throw new PetException("Следующий ход может убить питомца");
            }
            else
            {
                Forces += 0;
            }
            return Forces;
        }

    }

    public class Dog : Pet
    {
        Random r = new Random();
        public override void Feed(int x, int y, int f)
        {
            Mood += r.Next(1, x);
            Satiety += r.Next(1, y);
            Weight += r.Next(1, f);//При кормежке увеличиваются вес, сытость, настроение
        }
        public override string Info()
        {
            return String.Format("\nИмя Собаки: {0}\nВес: {1}\nНастроение: {2}\nСытость: {3}\nСилы: {4}\nСтепень пушистости: {5}\nПушистость: {6}", Name, Weight, Mood, Satiety, Forces, Fluff, Flufy);
            //return "\nИмя Питомца: " + Name + "\nВес: " + Weight + "\nНастроение: " + Mood + "\nСытость: " + Satiety + "\nСилы: " + Forces + "\nСтепень пушистости: " + Fluff + "";
        }
        // public override string Info()
        // {
        //     return "\nИмя Собаки: " + Name + "\nВес: " + Weight + "\nНастроение: " + Mood + "\nСытость: " + Satiety + "\nСилы: " + Forces + "\nСтепень пушистости: " + Fluff + "";
        //  }
        //public override string Info()
        //{
        //    return "\nИмя Собаки: " + Name + "\nВес: " + Weight + "\nНастроение: " + Mood + "\nСытость: " + Satiety + "\nСилы: " + Forces;
        //}
    }

    public class Cat : Pet
    {
        Random r = new Random();
        public override void Feed(int x, int y, int f)
        {
            Mood += r.Next(1, x);
            Weight += r.Next(1, f);//При кормежке увеличиваются вес, настроение
        }
        public override string Info()
        {
            return String.Format("\nИмя Кошки: {0}\nВес: {1}\nНастроение: {2}\nСытость: {3}\nСилы: {4}\nСтепень пушистости: {5}\nПушистость: {6}", Name, Weight, Mood, Satiety, Forces, Fluff, Flufy);
            //return "\nИмя Питомца: " + Name + "\nВес: " + Weight + "\nНастроение: " + Mood + "\nСытость: " + Satiety + "\nСилы: " + Forces + "\nСтепень пушистости: " + Fluff + "";
        }
        //  public override string Info()
        //  {
        //     return "\nИмя Кошки: " + Name + "\nВес: " + Weight + "\nНастроение: " + Mood + "\nСытость: " + Satiety + "\nСилы: " + Forces + "\nСтепень пушистости: " + Fluff + "";
        //  }
        //public override string Info()
        //{
        //    return "\nИмя Кошки: " + Name + "\nВес: " + Weight + "\nНастроение: " + Mood + "\nСытость: " + Satiety + "\nСилы: " + Forces;
        //}

    }
}
