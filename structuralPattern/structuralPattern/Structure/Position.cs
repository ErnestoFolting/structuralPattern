using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuralPattern.Structure
{
    internal class Position:IComponent
    {
        public string name { get; set; }
        public double rate { get; set; }
        public double salary { get; set; }

        public Position(string Name,double Rate,double Salary)
        {
            name = Name;
            rate = Rate;
            salary = Salary;
        }
        public Tuple<double,double> printSchedule()
        {
            Console.WriteLine("Position: {0}\nRate: {1}\nSalary: {2}\n", name, rate, salary);
            return Tuple.Create(rate, salary);
        }
        public void addAt(string Name, IComponent temp)
        {
        }
    }
}
