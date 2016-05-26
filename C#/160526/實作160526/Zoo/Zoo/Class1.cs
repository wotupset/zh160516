using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        //定義屬性
        private string P_name;
        private string P_color;
        //索引子// Property//屬性
        public string C_name
        {
            get { return this.P_name; }
            set { this.P_name = value; }
        }
        public string C_color
        {
            get { return this.P_color; }
            set { this.P_color = value; }
        }
        //建構函式//建構子
        public Animal(string name,string color)
        {
            this.P_name = name;
            this.P_color = color;
        }
        //方法
        public abstract string Eat();
        public string F_Animal()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("名字={0} 顏色={1} \r\n", this.P_name, this.P_color));
            sb.Append(string.Format("{0} 吃：{1}\r\n", this.P_name, this.Eat()));
            return sb.ToString();
        }


    }
}
