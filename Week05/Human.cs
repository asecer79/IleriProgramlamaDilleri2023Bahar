using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    public class Human
    {
        //Members

        //1. Field Members 
        private string? firstName;
        public void SetFirstName(string? firstName)
        {
            this.firstName = firstName;
        }
        public string? GetFirstName()
        {
            return firstName;
        }


        //2. Property Members 
        public string? FirstName { get; set; }
        public string? LastName { get; set;}

        //3. delegates or events
        public event EventHandler FirstNameUpdated;

        //4. Methods
        public void Run()
        {
            Console.WriteLine("Human started to run...");
        }
        public void WhatIsYourName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        //5.Constructors
        
        public Human()//default constructor
        {
            int a = 1 + 6;
        }


    }
}
