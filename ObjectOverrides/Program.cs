using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with System.Object");
            Person p1 = new Person("Homer", "Simpson", 50);
            Person p4 = new Person("Homer", "Simpson", 50);
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("GetHash: {0}", p1.GetHashCode());
            Console.WriteLine("GetType: {0}", p1.GetType());

            Person p2 = p1;
            object o = p2;
            if (o.Equals(p1) && p2.Equals(o))
                Console.WriteLine("Same reference");
            Console.WriteLine(object.Equals(p1, p4));
            Console.WriteLine(object.ReferenceEquals(p1,p4));
            Console.ReadKey();
        }
    }
}
