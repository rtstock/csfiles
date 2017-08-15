

using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Elements elements = new Elements();
            for (int i = 0; i < 10; i++)
            {
                elements[i] = new Element() { Key = i.ToString() + "K", Value = new Person("Person"+i.ToString() + "(Name)", i *10) };
            }
            foreach (Element x in elements)
            {
                Console.WriteLine("Key Value {0} {1} {2}", x.Key,  x.Value.Name, x.Value.Age);
            }
            Console.ReadLine();
        }
    }

    class Element
    {
        public string Key { get; set; }
        public Person Value { get; set; }

    }
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //Other properties, methods, events...
    }

    class Elements : IEnumerable
    {
        ArrayList mylist = new ArrayList();

        public Element this[int index]
        {
            get { return (Element)mylist[index]; }
            set { mylist.Insert(index, value); }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return mylist.GetEnumerator();
        }
    }
}
