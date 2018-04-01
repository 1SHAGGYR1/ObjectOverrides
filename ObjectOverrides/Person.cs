using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public Person (string firstName, string familyName, int age)
        {
            FirstName = firstName;
            SecondName = familyName;
            Age = age;
        }
        public Person()
        { }
        public override string ToString()
        {
            string str = string.Format("First Name: {0}, Last Name: {1}, Age: {2}", FirstName, SecondName, Age);
            return str;
        }
        public override bool Equals(object obj)
        {
            if (this.ToString()==obj.ToString())
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
