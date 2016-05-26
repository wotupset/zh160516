using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Air
{
    public class Rooster:Animal,IBirdAbility
    {
        public Rooster(string name,string color) : base("雞", name, color) { }

        public override string Eat()
        {
            return "小米、小蟲！";
        }

        public override string Sound()
        {
            return "咕！咕！咕！";
        }

        public override string Move()
        {
            return "兩隻腳在地上慢慢走！";
        }

        public string Fly()
        {
            return "飛得不高、飛得不快！";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(string.Format("{0} 的飛：{1}\r\n", this.Name, this.Fly()));
            return sb.ToString();
        }
    }
}
