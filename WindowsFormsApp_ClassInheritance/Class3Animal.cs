using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_ClassInheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public Animal() { }

        public void Speak()
        {
            Console.WriteLine($"Animal Class :~)");
        }
    }

    public class Cat : Animal
    {
        public void Cry()
        {
            Console.WriteLine($"Cat : nyaong :~)");
        }
    }

    public class Bird : Animal
    {
        public void Sing()
        {
            Console.WriteLine($"Bird : JJeakk :~)");
        }
    }

    public class Dog : Animal
    {
        public void Shout()
        {
            Console.WriteLine($"Dog : wal wal :~)");
        }
    }
}
