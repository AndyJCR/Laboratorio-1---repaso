using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1___repaso
{
    public class EmployeeSalary : Employee
    {
        int hoursOfMonth;
        short workedMonth;
        double totalSalary;
        public int HoursOfMonth { get { return hoursOfMonth; } set { hoursOfMonth = value; } }
        public short WorkedMonth { get { return workedMonth; } set { workedMonth = value; } }
        public double TotalSalary { get { return totalSalary; } set { totalSalary = value; } }

        public EmployeeSalary(int Id_C, string Name_C, double HourlyWage_C)
        {
            id = Id_C;
            name = Name_C;
            hourlyWage = HourlyWage_C;
        }
    }
}
