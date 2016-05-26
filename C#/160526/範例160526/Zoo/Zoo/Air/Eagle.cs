using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Air
{
    public class Eagle:Animal,IBirdAbility
    {
        public Eagle(string name) : base("老鷹", name, "褐白") { }

        public override string Eat()
        {
            return "其他小動物！";
        }

        public override string Sound()
        {
            return "啊！啊！啊！";
        }

        public override string Move()
        {
            return "兩隻腳在地上慢慢走！";
        }

        public string Fly()
        {
            return "飛得很高、飛得很快！";
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
