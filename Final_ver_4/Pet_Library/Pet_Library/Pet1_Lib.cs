using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Library
{
    public class Pet1_Lib
    {

        string name;//Имя
        int mood = 50;//Настроение(в процентах)
        int satiety = 50;//Уровень сытости(проценты)
        int forces = 50;//Силы(проценты)
        int weight;//Вес
        Random r = new Random();
        //параметр максимум увеличение/уменьшение 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Mood
        {
            get { return mood; }
            set { mood = value; }
        }
        public int Satiety
        {
            get { return satiety; }
            set { satiety = value; }
        }
        public int Forces
        {
            get { return forces; }
            set { forces = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
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
        /// Вычисляет процент веса и сытости
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public void Feed(/*int x,*/ int y, int f)// покормить(увеличивается сытость и настроение) 
        {
            /*Mood = Math.Min(Mood + r.Next(1, x), 100);
            Satiety = Math.Min(Satiety + r.Next(1, y), 100);*/
            Weight = Math.Min(Weight + r.Next(1, f), 100);
            Satiety = Math.Min(Satiety + r.Next(1, y), 100); //При кормежке увеличиваются вес, сытость
        }
        /// <summary>
        /// Вычисляет процент Настроения, сытости и сил
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public void Train(int x, int y, int z)// дрессировать(уменьшаются все параметры)
        {
            Mood -= r.Next(1, x);
            Forces -= r.Next(1, z);
            Satiety -= r.Next(1, y);
        }
        public string Info()
        {
            return "При кормежке увеличился вес, настроение на" + Feed();
        }
    }

    public class Dog : Pet1_Lib
    {
        Random r = new Random();
        public void Feed(int x, int y, int f) 
            {
                Mood = Math.Min(Mood + r.Next(1, x), 100);
                Weight = Math.Min(Weight + r.Next(1, f), 100);//При кормежке увеличиваются вес, сытость, настроение
                Satiety = Math.Min(Satiety + r.Next(1, y), 100);
            }
            public string Info()
            {
                return "При кормежке увеличился вес, настроение на" + Feed();
            }
    }

    public class Cat : Pet1_Lib
    {
        Random r = new Random();
        public void Feed(int x, int f) 
            {
                Mood = Math.Min(Mood + r.Next(1, x), 100);
                Weight = Math.Min(Weight + r.Next(1, f), 100);//При кормежке увеличиваются вес, настроение
            }

            public string Info()
            {
                return "При кормежке увеличился вес, настроение на" + Feed();
            }
    }

    
}


