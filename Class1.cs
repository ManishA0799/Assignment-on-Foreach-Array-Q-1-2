using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_Foreach_Array
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Fees { get; set; }

        public override string ToString()
        {
            return $"Student details : {Id} {Name} {Fees}";
        }


        public class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string location { get; set; }

            public override string ToString()
            {
                return $"Student details : {Id} {Name} {location}";
            }









        }
}
