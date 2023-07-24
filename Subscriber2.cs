using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractices
{
    public class Subscriber2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Subscriber2(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void EventHandler(Object obj)
        {
            if (obj is Subscriber2 s)
            {
                Console.WriteLine(s.Name + " " + s.Age);
            }
        }
    }
}
