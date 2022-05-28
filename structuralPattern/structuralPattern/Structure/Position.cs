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
        public Tuple<double,double> printSchedule(string indent, bool last)
        {

            Console.Write(indent);
            if (last)
            {
                Console.Write("\\-");
                indent += "  ";
            }
            else
            {
                Console.Write("|-");
                indent += "| ";
            }
            Console.WriteLine("Position: {0} Rate: {1} Salary: {2}", name,rate,salary);
            
            return Tuple.Create(rate, rate * salary);
        }
        public bool addAt(string Name, IComponent temp)
        {
            return false;
        }
        public void add(IComponent temp)
        {
            Console.WriteLine("Can not add positions or units to position.");
        }

        public void remove(IComponent temp)
        {
            Console.WriteLine("Can not remove positions or units from position.");
        }
    }
}
