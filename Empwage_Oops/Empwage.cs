using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage_Oops
{
    internal class EmployeeWage
    {

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 0;
        const int IS_PRESENT = 1;
        const int IS_ABSENT = 0;
        const int RATE_PER_HOUR = 20;

        /// <summary>
        /// Code to get Attendence..
        /// </summary>
        public void Attendance()
        {
            Random random = new Random();
            int checkAttendance = random.Next(0, 2);
            if (checkAttendance == IS_PRESENT)
                Console.WriteLine("\n Employee is Present");
            else if (checkAttendance == IS_ABSENT)
                Console.WriteLine("\n Employee is Absent");
        }

        /// <summary>
        /// Code to get PartTime Employee and wage..
        /// </summary>
        public void DailyWage()
        {
            int dailyWage = 0;
            int dailyHours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                dailyHours = 16;
            else if (empCheck == IS_PART_TIME)
                dailyHours = 8;
            dailyWage = dailyHours * RATE_PER_HOUR;
            Console.WriteLine("\n Employee Daily Wage: " + dailyWage);
        }
    }
}
