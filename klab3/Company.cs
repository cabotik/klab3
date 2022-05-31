using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klab3
{
    class Company
    {   
        private string type;
        private string name;

        public string Type { get; set; }
        public string Name { get; set; }
        // перегрузка конструктора
        public Company() { }
        public Company(string type) {this.type = type;}
        public Company(string type, string name) { this.type = type; this.name = name; }

        public virtual string Print() // виртуальный метод для вызова свойств
        {
            return $" Фирма :{this.type} {this.name}";
        }
    }
}
