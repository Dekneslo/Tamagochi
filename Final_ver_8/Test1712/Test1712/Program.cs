using System;

namespace Test1712
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = 0;
                ParamList list = new ParamList();
                while (count < 2)
                {
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter mood");
                    int mood = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter satiety");
                    int satiety = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter forces");
                    int forces = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter weight");
                    int weight = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter fluff");
                    int fluff = int.Parse(Console.ReadLine());
                    list.Add(name, mood, satiety, forces, weight, fluff);
                    count++;
                }
                var arr = list.AllToArray();
                list.ArrayMediumAndAVG(arr);
                Console.ReadKey();

            }
            catch
            {

            }
        }
    }
}
