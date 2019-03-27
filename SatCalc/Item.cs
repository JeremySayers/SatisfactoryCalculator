using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatCalc
{
    public class Item
    {
        public string Name;
        public int MadeInKey;
        public double OutputPerMinute;
        public int OutputQuantity;

        public override string ToString()
        {
            return Name;
        }
    }
}
