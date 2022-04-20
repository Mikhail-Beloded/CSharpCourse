using System;
using System.Collections.Generic;

namespace HomeworkClasses
{
    internal class Employer
    {
        public string? nameValue = Console.ReadLine();

        public Employer()
        {
            this.Name = this.nameValue;
        }

        public List<Student> Employee { get; set; }

        public string? Name { get; set; }

        public void AddEmployee(Student student)
        {
            this.Employee.Add(student);
        }
    }
}
