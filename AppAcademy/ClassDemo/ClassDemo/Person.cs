using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Person
    {
        //field
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }

        public Person(string firstName,string LastName)
        {
            _firstName = firstName;
            LastName = LastName;
        }
    }
}
