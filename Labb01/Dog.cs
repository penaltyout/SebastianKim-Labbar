using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb01
{
    class Dog
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }

        public Dog(string name, string age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public string Introduction()
        {
            return String.Format("My dog's name is {0}, and he is {1} years old. He is a {2}.", Name, Age, Breed);
        }
    }
}
