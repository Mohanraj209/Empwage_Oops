using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage_Oops
{
    internal class EmployeeWage
    {

        /// <summary>
        /// Code to get Attendence..
        /// </summary>
        const int IS_PRESENT = 1;
        const int IS_ABSENT = 0;
        public void Attendance()
        {
            Random random = new Random();
            int checkAttendance = random.Next(0, 2);
            if (checkAttendance == IS_PRESENT)
                Console.WriteLine("\n Employee is Present");
            else if (checkAttendance == IS_ABSENT)
                Console.WriteLine("\n Employee is Absent");
        }
    }
}
