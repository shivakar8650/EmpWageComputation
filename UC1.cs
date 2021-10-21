using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculaton
{
    class UC1
    {
        public static void CheckEmployee()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
