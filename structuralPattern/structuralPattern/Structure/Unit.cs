using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuralPattern.Structure
{
     class Unit:IComponent
    {
        public string code { get; set; }
        public string name { get; set; }

        List<IComponent> children = new List<IComponent>();

        public Unit(string Code, string Name, List<IComponent> lst)
        {
            code = Code;
            name = Name;
            children = lst;
        }

        public Tuple<double, double> printSchedule()
        {
            double totalRate = 0;
            double totalSalary = 0;
            Console.WriteLine("-----Unit {0}-----", name);
            foreach (var child in children)
            {
                Tuple<double,double> temp = child.printSchedule();
                totalRate += temp.Item1;
                totalSalary += temp.Item2;
            }
            return Tuple.Create(totalRate, totalSalary);
        }
        public void add(IComponent temp)
        {
            children.Add(temp);
        }
        public void remove(IComponent temp)
        {
            children.Remove(temp);
        }
        public void addAt(string Name,IComponent temp)
        {
            if(name == Name)
            {
                Console.WriteLine("\nSuccessfully added\n");
                children.Add(temp);
            }
            else
            {
                foreach(var child in children)
                {
                    child.addAt(Name, temp);
                }
            }
        }
    }
}
