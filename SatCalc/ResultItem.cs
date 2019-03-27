using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatCalc
{
    public class ResultItem
    {
        public string Item;
        public double AmountPerMinute;
        public string Machine;
        public double AmountOfMachine;

        public override string ToString()
        {
            return Item + $" {AmountPerMinute.ToString("#.000")}/minute ({AmountOfMachine.ToString("#.000")} x {Machine})";
        }
    }

    
}
