using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classoop
{
    class Program
    {

        static void Main(string[] args)
        {
            stack stackPerson = new stack();
            stackPerson.push(1111111111);
            stackPerson.push(1111111111);
            Console.WriteLine(stackPerson.pop());
            Console.WriteLine(stackPerson.pop());
            Person p1 = new Person(20, "Ahad", "Soory");
            Console.WriteLine(p1);
            Person p2 = new Person(30, "Ali", "Mahaki");
            Console.WriteLine(p2);
            Person p3 = new Person(10, "Sadegh", "Naghdi");
            Console.WriteLine(p3);
            p3 = p1;
            p3._intAge = 12;
            Console.WriteLine(p1);
            Console.WriteLine(p3);
            Console.ReadKey();
        }
    }
}
