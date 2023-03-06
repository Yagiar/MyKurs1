using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_Monopoly
{
    internal class Chance:Tile
    {
        public Chance()
        {
            base.name = "Chance";
            owner = null;
        }
        public void UpMoney(Player player)
        {
            player.Money += 100;
        }
        public void DownMoney(Player player)
        {
            player.Money -= 100;
        }
    }
}
