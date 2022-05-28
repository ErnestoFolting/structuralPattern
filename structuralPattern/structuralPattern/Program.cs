using System;
using System.Collections.Generic;
using structuralPattern.Structure;

namespace structuralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create positions
            IComponent pos1 = new Position("Position1", 0.5, 1500);
            IComponent pos2 = new Position("Position2", 1, 2500);
            IComponent pos3 = new Position("Position3", 2, 2500);
            IComponent pos4 = new Position("Position4", 3, 4500);
            IComponent pos5 = new Position("Position5", 1.5, 20000);
            
            //Create lists of positions
            List<IComponent> lst1 = new List<IComponent> { pos1, pos2 };
            List<IComponent> lst2 = new List<IComponent> { pos3, pos4 };

            //Create units
            IComponent unit1 = new Unit("121", "Unit1", lst1);
            IComponent unit2 = new Unit("123", "Unit2", lst2);
            
            //Add position to unit, add subunit to unit, ouput the schedule
            unit2.add(pos5);
            unit1.add(unit2);
            Console.WriteLine("*****Main schedule: *****\n");
            Tuple<double, double> tup2 = unit1.printSchedule("", true);
            Console.WriteLine("Total Rate: {0}", tup2.Item1);
            Console.WriteLine("Total Salary: {0}", tup2.Item2);
            Console.WriteLine();

            //Add position in concrete subunit
            unit1.addAt("Unit2", pos1);
            Console.WriteLine("*****Added position in concrete subunit: *****\n");
            Tuple<double, double> tup3 = unit1.printSchedule("", true);
            Console.WriteLine("Total Rate: {0}", tup3.Item1);
            Console.WriteLine("Total Salary: {0}", tup3.Item2);
            Console.WriteLine();

            //Remove position from unit and output of subunit
            unit2.remove(pos5);
            Console.WriteLine("*****Remove position from subunit and output of this subunit: *****\n");
            Tuple<double, double> tup4 = unit2.printSchedule("", true);
            Console.WriteLine("Total Rate: {0}", tup4.Item1);
            Console.WriteLine("Total Salary: {0}", tup4.Item2);
            Console.WriteLine();

            //Remove subunit from unit and ouput
            unit1.remove(unit2);
            Console.WriteLine("*****Remove subunit from unit and output of unit: *****\n");
            Tuple<double, double> tup5 = unit1.printSchedule("", true);
            Console.WriteLine("Total Rate: {0}", tup5.Item1);
            Console.WriteLine("Total Salary: {0}", tup5.Item2);
            Console.WriteLine();
        }
    }
}