using System;
using System.Collections.Generic;
using structuralPattern.Structure;

namespace structuralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComponent pos1 = new Position("Check1", 0.5, 1500);
            IComponent pos2 = new Position("Check2", 1, 2500);
            IComponent pos3 = new Position("Check3", 2, 2500);
            IComponent pos4 = new Position("Check4", 3, 4500);

            List<IComponent> lst2 = new List<IComponent> { pos3, pos2 };
            Unit unit2 = new Unit("121", "Unit2", lst2);
            unit2.add(pos1);
            unit2.remove(pos3);

            List<IComponent> lst1 = new List<IComponent> { pos1, pos4, unit2,unit2 };
           
            IComponent unit1 = new Unit("112", "Unit1", lst1);
            Tuple<double,double> tup = unit1.printSchedule();
            Console.WriteLine("Total Rate: {0}",tup.Item1);
            Console.WriteLine("Total Salary: {0}",tup.Item2);

            unit1.addAt("Unit2", pos3);
            unit1.printSchedule();
        }
    }
}