using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Kursovaya_Monopoly
{
    internal class Player
    {
        private double money;
        public string name;
        private int position;
        public bool canmove;
        public Image figure;
        public List<Land> Property=new List<Land>();
        public int Position
        {
            get { return position; }
            set {
                if (value > 39)
                {
                    position = value % 40;
                }
                else
                {
                    position = value;
                }
            }
        }
        public double Money
        {
            get { return money; }
            set { money = value; }
        }
        public Player(string name,Image image)
        {
            this.name = name;
            Money = 500;
            position = 0;
            figure= image;
            canmove = true;
        }
        public void Pay(Land Proper)
        {
            if (Proper.owner!=this&&Position!=0&&Proper.owner!=null)
            {
                money -= Proper.rent;
                Proper.owner.Money += Proper.rent;
            }
            
        }
        public void Buy(Land Proper)
        {
            if (Proper.owner == null)
            {
                money -= Proper.price;
                Property.Add(Proper);
                Proper.owner = this;
            }
        }
        public void SellProper(Land Proper)
        {
            money += Proper.price;
            Proper.owner = null;
            Property.Remove(Proper);
        }
        public int Move(int random)
        {
            if(money>=0)
                position += random;
            else
            {
                 MessageBox.Show("Вы проиграли");
                 canmove = false;
            }
            return position;
        }
        public double CheckMoney()
        {
            return Money;
        }
        public void Lose()
        {
            for(int i=0;i<Property.Count;i++)
            {
                Property[i].owner = null;
            }
            Property.Clear();
            canmove = false;
            figure = null;
            money = -100;
            name = null;
            position = -100;
        }
        public void GetSalary()
        {
            Money += 200;
        }
    }
}
