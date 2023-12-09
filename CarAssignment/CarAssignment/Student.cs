using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    public class Student
    {

    private string name;
	private int age; 
	private string major; 

        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public void Introduce()
        {
            Console.WriteLine($"Student Name is {this.name} , his age is {this.age} and he is in major {this.major}");

        }

    }
}
