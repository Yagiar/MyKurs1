using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_Monopoly
{
    internal class BlueLand:Land
    {
        private string color;
        public override string Color
        {
            get { return color; }
        }
        public BlueLand(double price, double rent, string name) : base(price, rent, name)
        {
            color = "Blue";
        }
    }
}
