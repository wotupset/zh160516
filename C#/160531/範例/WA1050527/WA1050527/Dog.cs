using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA1050527
{
    class Dog
    {
        private string name;
        private string color;
        private int weight;

        public Dog(string name, string color, int weight)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}公斤",this.name,this.color,this.weight);
        }

        public override int GetHashCode()
        {
            return (this.name + this.color).GetHashCode() + this.weight;
        }

        public override bool Equals(object obj)
        {
            bool ans = false;
            if (obj is Dog)
            {
                Dog dd = obj as Dog;
                if (dd.name == this.name && dd.color == this.color && dd.weight == this.weight)
                    ans = true;
            }

            return ans;
        }

    }
}
