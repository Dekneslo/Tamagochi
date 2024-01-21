using System;
using System.Collections.Generic;
using System.Text;

namespace Test1712
{
    class ParamNode
    {
        private ParamNode _next;
        public ParamNode Next
        {
            get { return _next; }
            set { _next = value; }
        }
        private string _name;
        private int _mood;
        private int _satiety;
        private int _forces;
        private int _weight;
        private int _fluff_num;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Mood
        {
            get { return _mood; }
            set { _mood = value; }
        }
        public int Satiety
        {
            get { return _satiety; }
            set { _satiety = value; }
        }
        public int Forces
        {
            get { return _forces; }
            set { _forces = value; }
        }
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public int Fluff_num
        {
            get { return _fluff_num; }
            set { _fluff_num = value; }
        }

        public ParamNode()
        {

        }

        public ParamNode(string name, int mood, int satiety, int forces, int weight, int fluff_num)
        {
            Name = name;
            Mood = mood;
            Satiety = satiety;
            Forces = forces;
            Weight = weight;
            Fluff_num = fluff_num;
        }

        public ParamNode(ParamNode nextnode, string name, int mood, int satiety, int forces, int weight, int fluff_num) : this(name, mood, satiety, forces, weight, fluff_num)
        {
            Next = nextnode;
        }

    }
}
