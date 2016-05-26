using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zoo.air;

namespace Zoo.Air
{
    public class Eagle : Animal, inf_bird
    {
        public Eagle(string name) : base("老鷹",  "褐白") { }
    }
        public string Eat()
        {
            return "蟲";
        }

}
