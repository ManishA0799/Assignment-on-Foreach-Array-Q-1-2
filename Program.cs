using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_Foreach_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student{Id=1,Name="Manish",Fees=2000},
                new Student{Id=2,Name="Raj",Fees=2200},
                new Student{Id=3,Name="Neel",Fees=2300},
                new Student{Id=4,Name="Ramesh",Fees=2400},
                new Student{Id=5,Name="Suresh",Fees=2500},
            };
            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }


            Employee[] employee =
           {
                new Employee{Id=1,Name="Manish",location="Pune"},
                new Employee{Id=2,Name="Raj",location="Mumbai"},
                new Employee{Id=3,Name="Neel",location="Thane"},
                new Employee{Id=4,Name="Suresh",location="Goa"},
                new Employee{Id=5,Name="Ramesh",location="Bihar"},

            };
            foreach (Employee e in employee)
            {
                Console.WriteLine(e);
            }











        }
    }
}
