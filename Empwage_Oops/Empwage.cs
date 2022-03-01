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
        const int WORKING_DAYS_PER_MONTH = 20;

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
        /// Code to get Daily Employee wage for a month using switch..
        /// </summary>
        public void DailyWage()
        {
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
           
                for (int day = 0; day < WORKING_DAYS_PER_MONTH; day++)
                {

                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 8;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 16;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    empWage = empHrs * RATE_PER_HOUR;
                    totalEmpWage += empWage;   //int a=6; a+=10;a=a+10
                    Console.WriteLine("Emp Wage: " + empWage);
                }
                Console.WriteLine("Total Emp Wage: " + totalEmpWage);

            }

        }

    }

}

