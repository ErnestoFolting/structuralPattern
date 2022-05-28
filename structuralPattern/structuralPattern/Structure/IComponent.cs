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
        public Tuple<double, double> printSchedule(string indent, bool last);
        public bool addAt(string Name, IComponent temp);

        public void add(IComponent temp);

        public void remove(IComponent temp);
    }
}
