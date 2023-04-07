using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    public class Human
    {
        public List<string> Address { get; set; } = new List<string>()
        {
                "Ankara",
                "Istanbul"
        };
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        private int Age { get; set; }

        //default varsayılan yapıcı metot-1
        public Human()
        {
            FirstName = "No data";
            LastName = "No data";
            Age = 0;
        }

        public Human(int age)
        {
            FirstName = "No data";
            LastName = "No data";
            Age = age;
        }

        //overloaded constructor method-2
        public Human(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = 0;

        }

        //overloaded constructor method-3
        public Human(string? firstName, string? lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

        public string this[int index]
        {
            get
            {
                return Address[index];
            }

            set
            {
                Address[index]= value;
            }
        }

        ~Human()
        {
            Console.WriteLine("Object disposed....");
        }

    }
}
