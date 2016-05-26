using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Animal
    {
        private string type;
        private string name;
        private string color;

        public string Type
        {
            get { return this.type; }
        }
        public string Color
        {
            get { return this.color; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Feed
        {
            get { return 1; }
        }
        //
        public Animal(string type, string name, string color)
        {
            this.type = type;
            this.name = name;
            this.color = color;
        }
        //
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} 的名字：{1}\r\n", this.type, this.name));

            return sb.ToString();
        }
    }
}
