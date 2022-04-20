using System;
using System.Collections.Generic;

namespace HomeworkClasses
{
    public class Student
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public string? NativeTown { get; set; }

        public int HoursOfWorking { get; set; }

        public int Experience { get; set; }

        public int HoursOfSleeping(int hoursOfWorking, int studyingTime)
        {
            return 24 - hoursOfWorking - studyingTime;
        }

        public int HoursOfSleeping(int hoursOfWorking, int studyingTime, int transportTime)
        {
            return 24 - hoursOfWorking - studyingTime - transportTime;
        }

        public int PocketMoney(int salary, int foodMoney, int transportMoney)
        {
            return salary - foodMoney - transportMoney;
        }

        public int PocketMoney(int salary, int foodMoney, int transportMoney, int marks, int scholarship)
        {
            if (this.IsAGoodStudent(marks))
            {
                return salary + scholarship - foodMoney - transportMoney;
            }
            else
            {
                return salary - foodMoney - transportMoney;
            }
        }

        private bool IsAGoodStudent(int mark)
        {
            if (mark >= 60 && mark <= 100)
            {
                return true;
            }
            else if (mark > 0 && mark < 60)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Incorrect number");
                return false;
            }
        }
    }
}
