using System;
using System.Collections.Generic;

namespace HomeworkClasses
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            Console.WriteLine("Add new employer.");
            Employer employer = new Employer();
            var student = new Student();

            Console.WriteLine("Enter student's name.");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter student's age.");
            string? studentsAge = Console.ReadLine();
            if (int.TryParse(studentsAge, out var age))
            {
                student.Age = age;
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }

            Console.WriteLine("Enter student's native town");
            student.NativeTown = Console.ReadLine();

            Console.WriteLine("Enter student's experience");
            string? studentsExperience = Console.ReadLine();
            if (int.TryParse(studentsExperience, out var experience))
            {
                student.Experience = experience;
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }

            Console.WriteLine("Enter student's hors of working per day");
            string? studentsWorkingHours = Console.ReadLine();
            if (int.TryParse(studentsWorkingHours, out var workingHours))
            {
                student.HoursOfWorking = workingHours;
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }

            student.Salary = ExtensionMethod.CalculateSalary(student.HoursOfWorking, student.Experience);
            employer.AddEmployee(student);

            Console.WriteLine("Enter student's hours of studing.");
            string? studyingHours = Console.ReadLine();
            if (!int.TryParse(studyingHours, out var studing))
            {
                Console.WriteLine("Incorrect number");
            }

            Console.WriteLine("Enter student's hours for transport.");
            string? transport = Console.ReadLine();
            if (!int.TryParse(transport, out var transportTime))
            {
                Console.WriteLine("Incorrect number");
            }

            if (transport == null)
            {
                student.HoursOfSleeping(student.HoursOfWorking, studing);
            }
            else
            {
                student.HoursOfSleeping(student.HoursOfWorking, studing, transportTime);
            }

            Console.WriteLine("Enter student's money which he spends for food.");
            string? food = Console.ReadLine();
            if (!int.TryParse(food, out var foodMoney))
            {
                Console.WriteLine("Incorrect number");
            }

            Console.WriteLine("Enter student's money which he spends for transport.");
            string? studentTransport = Console.ReadLine();
            if (!int.TryParse(studentTransport, out var transportMoney))
            {
                Console.WriteLine("Incorrect number");
            }

            Console.WriteLine("Enter student's marks.");
            string? marks = Console.ReadLine();
            if (!int.TryParse(marks, out var studentMarks))
            {
                Console.WriteLine("Incorrect number");
            }

            int scholarship = 2000;

            if (marks == null)
            {
                student.PocketMoney(student.Salary, foodMoney, transportMoney);
            }
            else
            {
                student.PocketMoney(student.Salary, foodMoney, transportMoney, studentMarks, scholarship);
            }

            foreach (var person in employer.Employee)
            {
                Console.WriteLine($"Name: {person.Name}, age: {person.Age}, native town: {person.NativeTown};");
                Console.WriteLine($"Hours of working per day: {person.HoursOfWorking}, experience: {person.Experience}, salary: {person.Salary}");
                Console.WriteLine($"");
            }
        }
    }
}