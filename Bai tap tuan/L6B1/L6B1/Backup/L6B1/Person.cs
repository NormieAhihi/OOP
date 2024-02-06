using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6B1
{
    class Person
    {
        public Person()
        {
        }
        private string _name;
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        private string _age;
        public string Age
        {
            set
            {
                _age = value;
            }
            get
            {
                return _age;
            }
        }

        public virtual void Say(string words)
        {
            Console.WriteLine("{0}:{1}",_name,words);
        }
    }
}
