using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_Monopoly
{
    internal class OrangeLand:Land
    {
        private string color;
        public override string Color
        {
            get { return color; }
        }
        public OrangeLand(double price, double rent, string name) : base(price, rent, name)
        {
            color = "Orange";
        }
    }
}
