using System;
using System.Collections.Generic;

namespace HomeworkClasses
{
    public static class ExtensionMethod
    {
        public static int CalculateSalary(this int hoursOfWorking, int experience)
        {
            int salary = 0;
            if (experience < 2)
            {
                salary = 500;
            }
            else if (experience >= 2 && experience < 6)
            {
                salary = 2000;
            }
            else if (experience >= 6)
            {
                salary = 5000;
            }

            if (hoursOfWorking < 7)
            {
                salary = salary / 2;
            }

            return salary;
        }
    }
}
