using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Land
{
    public class Lion:Animal
    {
        public Lion(string name) : base("獅子", name, "黃") { }


        public override string Eat()
        {
            return "其他動物的肉";
        }

        public override string Sound()
        {
            return "吼！吼！吼！";
        }        
        public override string Move()
        {
            return "跑跑跳跳！";
        }
        
    }
}
