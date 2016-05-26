using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Sea
{
    public class Shark:Animal
    {
        public Shark(string name, string color) : base("鯊魚", name, color) { }

        public override string Eat()
        {
            return "海豹、海龜！";
        }

        public override string Sound()
        {
            return "沒有聲音！";
        }

        public override string Move()
        {
            return "游得很快！";
        }
    }
}
