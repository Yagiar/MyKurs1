using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_Monopoly
{
    internal class GreenLand:Land
    {
        private string color;
        public override string Color
        {
            get { return color; }
        }
        public GreenLand(double price, double rent, string name) : base(price, rent, name)
        {
            color = "Green";
        }
    }
}
