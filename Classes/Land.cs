using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_Monopoly
{
    internal class Land:Tile
    {
        public double price;
        public double rent;
        public virtual string Color
        {
            get;
        }
        public Land(double price, double rent, string name)
        {
            this.price = price;
            this.rent = rent;
            base.name = name;
            owner = null;
        }
    }
}
