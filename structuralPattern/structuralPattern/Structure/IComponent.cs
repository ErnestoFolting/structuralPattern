using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuralPattern
{
     interface IComponent
    {
        string name { get; set; }
        public Tuple<double, double> printSchedule();

        public void addAt(string Name, IComponent temp);
    }
}
