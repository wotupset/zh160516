using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Land
{
    public class Dog:Animal
    {
        public Dog(string name, string color): base("狗狗", name, color)
        { }

        public override string Eat()
        {
            return "肉、骨頭、西莎、寶路";
        }
        public override string Move()
        {
            return "跑跑跳跳！";
        }
        public override string Sound()
        {
            return "汪！汪！汪！";
        }

    }
}
