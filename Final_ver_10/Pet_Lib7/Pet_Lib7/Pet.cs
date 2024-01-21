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
        int mood;//Настроение(в процентах)
        int satiety;//Уровень сытости(проценты)
        int forces;//Силы(проценты)
        int weight;//Вес
        string name;//Имя
        int mood1;//Настроение(в процентах)
        int satiety1;//Уровень сытости(проценты)
        int forces1;//Силы(проценты)
        int weight1;//Вес
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
        
        List<Pet> ves = new List<Pet>();
        public List<Pet> Ves
        {
            get { return ves; }
            set { ves = value; }
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
        public int Mood1
        {
            get { return mood1; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Настроение не может быть меньше или =0");
                }
                else
                {
                    mood1 = value;
                }
            }
        }
        public int Satiety1
        {
            get { return satiety1; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Сытость не может быть меньше или =0");
                }
                else
                {
                    satiety1 = value;
                }
            }
        }
        public int Forces1
        {
            get { return forces1; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Силы не может быть меньше или =0");
                }
                else
                {
                    forces1 = value;
                }
            }
        }
        public int Weight1
        {
            get { return weight1; }
            set
            {
                if (value <= 0)
                {
                    throw new PetException("Вес не может быть меньше или =0");
                }
                else
                {
                    weight1 = value;
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

        public virtual void Feed(int y, int f, int z)// покормить(увеличивается сытость и вес) 
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
