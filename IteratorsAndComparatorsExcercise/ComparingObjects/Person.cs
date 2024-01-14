using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
		private string name;
        private int age;
        private string town;

        public Person(string name1, int age1, string town1)
        {
            Name = name1;
            Age = age1; 
            Town = town1;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Town
		{
			get { return town; }
			set { town = value; }
		}

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);

            if(result != 0)
            {
                return result;
            }

            result = Age.CompareTo(other.Age);

            if(result != 0)
            {
                return result;
            }
            result = Town.CompareTo(other.Town);

                return result;

        }
    }
}
