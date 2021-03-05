using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1___repaso
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double hourlyWage;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public double HourlyWage { get { return hourlyWage; } }
    }
}
