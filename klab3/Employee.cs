using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klab3
{
    class Employee : Company
    {
        private string post;
        private string fullName;
        private int experence;

        public string Post { get; set; }
        public string FullName { get; set; }
        public int Experence { get; set; }
        // перегрузка конструктора
        public Employee() : base() { }
        public Employee(string type, string name) : base(type, name) { }
        public Employee(string type, string name, string post) : base(type, name) 
        { 
            this.post = post; 
        }
        public Employee(string type, string name, string post, string fullName) : base(type, name) 
        { 
            this.post = post; this.fullName = fullName; 
        }
        public Employee(string type, string name, string post, string fullName, int experence) : base(type, name) 
        { 
            this.post = post;
            this.fullName = fullName;
            this.experence = experence;
        }
        public override string Print()
        {
            return $" {base.Print()}, {post} {fullName}, с опытом работы {experence} лет/года/месяцев. ";
        }

    }
}
