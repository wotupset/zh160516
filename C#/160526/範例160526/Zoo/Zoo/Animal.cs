using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Animal
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

        public Animal(string type,string name,string color)
        {
            this.type = type;
            this.name = name;
            this.color = color;

        }

        public abstract string Eat();
        public abstract string Sound();
        public abstract string Move();
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} 的名字：{1}\r\n", this.type, this.name));
            sb.Append(string.Format("{0} 的顏色：{1}\r\n", this.name, this.color));
            sb.Append(string.Format("{0} 吃：{1}\r\n", this.name, this.Eat()));
            sb.Append(string.Format("{0} 的聲音：{1}\r\n", this.name, this.Sound()));
            sb.Append(string.Format("{0} 的動作：{1}\r\n", this.name, this.Move()));
            return sb.ToString();
        }

        
    }
}
