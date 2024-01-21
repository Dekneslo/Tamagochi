﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Lib4
{
    public class Pet

    {

        string name;//Имя
        int mood;//Настроение(в процентах)
        int satiety;//Уровень сытости(проценты)
        int forces;//Силы(проценты)
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
        /// Вычисляет процент Настроения и сытости
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>     

        public virtual void Feed(int x, int y, int f)// покормить(увеличивается сытость и настроение) 
        {
            Satiety += r.Next(1, y); //При кормежке увеличиваются вес, сытость
            Weight += r.Next(1, f);
        }

        public void Train(int x, int y, int z)// дрессировать(уменьшаются все параметры)
        {
            Mood -= r.Next(1, x);
            Forces -= r.Next(1, z);
            Satiety -= r.Next(1, y);
        }

        public string Test(int x, int y, int z)
        {
            if (x > Mood) return "1";//вернуть 1-сообщение о вероятности убить питомца
            else if (y > Satiety) return "1";
            else if (z > Forces) return "1";
            else return "0";//все хорошо =)
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

    }

    public class Cat : Pet
    {
        Random r = new Random();
        public override void Feed(int x, int y, int f)
        {
            Mood += r.Next(1, x);
            Weight += r.Next(1, f);//При кормежке увеличиваются вес, настроение
        }

    }
}
