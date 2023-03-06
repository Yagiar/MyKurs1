using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kursovaya_Monopoly
{
    public partial class Game : Window
    {

        readonly Random rnd = new Random();
        readonly List<Player> players = new List<Player>();
        readonly Land[] lands = new Land[40];
        readonly List<Image> ImagePlayers = new List<Image>();
        readonly List<TextBlock> Moneys = new List<TextBlock>();
        readonly List<TextBlock> pos = new List<TextBlock>();
        readonly List<ListBox> ProperList=new List<ListBox>();
        Chance chance;
        int CurrentPlayer = 0;
        Land temp;
        readonly int[] NotProper = new int[18] {0,2,4,5,7,10,12,15,17,20,22,25,28,30,33,35,36,38};
        public Game()
        {
            InitializeComponent();
        }
        public Game(int Persons) : this()
        {

            switch (Persons)
            {
                case 2:
                    {
                        Player Player1 = new Player("Gale", igrok1);
                        Player Player2 = new Player("Max", igrok2);
                        players.Add(Player1);
                        players.Add(Player2);
                        ImagePlayers.Add(igrok1);
                        ImagePlayers.Add(igrok2);
                        Player_1.Content = Player1.name;
                        money1.Text = Player1.Money.ToString();
                        Player_2.Content = Player2.name;
                        money2.Text = Player2.Money.ToString();
                        Moneys.Add(money1);
                        Moneys.Add(money2);
                        pos.Add(Position1);
                        pos.Add(Position2);
                        ProperList.Add(ProperPlayer1);
                        ProperList.Add(ProperPlayer2);
                        break;
                    }
                         case 3:
                             {
                                 Player Player1 = new Player("Gale",igrok1);
                                 Player Player2 = new Player("Max",igrok2);
                                 Player Player3 = new Player("Gleb",igrok3);
                                 players.Add(Player1);
                                 players.Add(Player2);
                                 players.Add(Player3);
                                 ImagePlayers.Add(igrok1);
                                 ImagePlayers.Add(igrok2);
                                 ImagePlayers.Add(igrok3);
                                 Moneys.Add(money1);
                                 Moneys.Add(money2);
                                 Moneys.Add(money3);
                                 pos.Add(Position1);
                                 pos.Add(Position2);
                                 pos.Add(Position3);
                                 ProperList.Add(ProperPlayer1);
                                 ProperList.Add(ProperPlayer2);
                                 ProperList.Add(ProperPlayer3);  
                                 Player_1.Content = Player1.name;
                                 money1.Text = Player1.Money.ToString();
                                 Player_2.Content = Player2.name;
                                 money2.Text = Player2.Money.ToString();
                                 Player_3.Content = Player3.name;
                                 money3.Text = Player3.Money.ToString();
                                 GridPlayer3.Visibility = Visibility.Visible;
                                 ProperPlayer3.Visibility = Visibility.Visible;
                                 igrok3.Visibility = Visibility.Visible;
                                 break;
                             }
                         case 4:
                             {
                                 Player Player1 = new Player("Gale",igrok1);
                                 Player Player2 = new Player("Max",igrok2);
                                 Player Player3 = new Player("Gleb",igrok3);
                                 Player Player4 = new Player("Slava",igrok4);
                                 players.Add(Player1);
                                 players.Add(Player2);
                                 players.Add(Player3);
                                 players.Add(Player4);   
                                 ImagePlayers.Add(igrok1);
                                 ImagePlayers.Add(igrok2);
                                 ImagePlayers.Add(igrok3);  
                                 ImagePlayers.Add(igrok4);
                                 Moneys.Add(money1);
                                 Moneys.Add(money2);
                                 Moneys.Add(money3);
                                 Moneys.Add(money4);         
                                 pos.Add(Position1);
                                 pos.Add(Position2);
                                 pos.Add(Position3);
                                 pos.Add(Position4);
                                 ProperList.Add(ProperPlayer1);
                                 ProperList.Add(ProperPlayer2);
                                 ProperList.Add(ProperPlayer3);
                                 ProperList.Add(ProperPlayer4);
                                 igrok3.Visibility=Visibility.Visible;
                                 igrok4.Visibility = Visibility.Visible;
                                 Player_1.Content = Player1.name;
                                 money1.Text = Player1.Money.ToString();
                                 Player_2.Content = Player2.name;
                                 money2.Text = Player2.Money.ToString();
                                 Player_3.Content = Player3.name;
                                 money3.Text = Player3.Money.ToString();
                                 Player_4.Content = Player4.name;
                                 money4.Text = Player4.Money.ToString();
                                 GridPlayer3.Visibility = Visibility.Visible;
                                 GridPlayer4.Visibility = Visibility.Visible;
                                 break;
                             }
                    
            }
            chance = new Chance();
            Land brown1 = new BrownLand(45, 5, "VINE STREET");
            Land brown2 = new BrownLand(55, 6, "COVENTRY STREET");
            Land lightblue1 = new BlueLand(70, 7, "LEICESTER STREET");
            Land lightblue2 = new BlueLand(75, 8, "BOW STREET");
            Land lightblue3 = new BlueLand(80, 9, "VWHITECHAPEL ROAD");
            Land pink1 = new PinkLand(91, 10, "ANGEL ISLINGTON");
            Land pink2 = new PinkLand(97, 11, "TRAFALGAR SQUARE");
            Land pink3 = new PinkLand(112, 12, "NORTHUMRLD AVENUE");
            Land orange1 = new OrangeLand(125, 13, "M'BOROUGH STREET");
            Land orange2 = new OrangeLand(148, 14, "FLEET STREET");
            Land orange3 = new OrangeLand(208, 15, "OLD KENT ROAD");
            Land red1 = new RedLand(211, 16, "WHITEHALL ROAD");
            Land red2 = new RedLand(215, 17, "PENTONVILLE");
            Land red3 = new RedLand(228, 18, "PALL MALL");
            Land yellow1 = new YellowLand(271, 19, "BOND STREET");
            Land yellow2 = new YellowLand(320, 20, "STRAND");
            Land yellow3 = new YellowLand(370, 21, "REGENT STREET");
            Land green1 = new GreenLand(404, 22, "EUSTON ROAD");
            Land green2 = new GreenLand(440, 23, "PICCADILLY");
            Land green3 = new GreenLand(550, 24, "OXFORD STREET");
            Land darkblue1 = new DarkBlueLand(562, 28, "PARK LANE");
            Land darkblue2 = new DarkBlueLand(900, 30, "MAYFAIR");
            lands[0] = null;
            lands[1] = brown1;
            lands[2] = null;
            lands[3] = brown2;
            lands[4] = null;
            lands[5] = null;
            lands[6]=lightblue1;
            lands[7] = null;
            lands[8] = lightblue2;
            lands[9] = lightblue3;
            lands[10] = null;
            lands[11] = pink1;
            lands[12] = null;
            lands[13] = pink2;
            lands[14] = pink3;
            lands[15] = null;
            lands[16] = orange1;
            lands[17] = null;
            lands[18] = orange2;
            lands[19] = orange3;
            lands[20] = null;
            lands[21] = red1;
            lands[22] = null;
            lands[23] = red2;
            lands[24] = red3;
            lands[25] = null;
            lands[26] = yellow1;
            lands[27] =yellow2;
            lands[28] = null;
            lands[29] = yellow3;
            lands[30] = null;
            lands[31] = green1;
            lands[32] = green2;
            lands[33] = null;
            lands[34] = green3;
            lands[35] = null;
            lands[36] = null;
            lands[37] = darkblue1;
            lands[38] = null;
            lands[39] = darkblue2;
            Сreatemap();
        }
        readonly List<Thickness> positions = new List<Thickness>();
        public void Сreatemap()
        {
            positions.Add(new Thickness(590,550,0,0));
            for (int i = 1; i < 10; i++)
                positions.Add(new Thickness(590-i*52-i*2, 550 , 0, 0));

            for (int i = 10; i < 20; i++)
                positions.Add(new Thickness(32, 550-(i-10)*52-(i-10)*1.05, 0, 0));

            for (int i = 20; i < 30; i++)
                positions.Add(new Thickness(32 + (i - 20) * 52 + (i - 20) * 2, 43, 0, 0));

            for (int i = 30; i < 40; i++)
                positions.Add(new Thickness(590, 43 + (i - 30) * 52-(i-30)*1.2 , 0, 0));
        }
       
        private void Move_Click(object sender, RoutedEventArgs e)
        {
            if (players[CurrentPlayer].canmove)
            {
                int step = rnd.Next(1,13);
                players[CurrentPlayer].Position = players[CurrentPlayer].Move(step);
                players[CurrentPlayer].figure.Margin = positions[players[CurrentPlayer].Position];
                if (players[CurrentPlayer].Position > 0)
                {
                    if (players[CurrentPlayer].CheckMoney() >= 0)
                        BuyLand(lands[players[CurrentPlayer].Position], players[CurrentPlayer]);
                    else
                        LoseGame(players[CurrentPlayer]);
                    
                    if (players[CurrentPlayer].CheckMoney() >= 0)
                        PayRent(lands[players[CurrentPlayer].Position], players[CurrentPlayer]);
                    else
                        LoseGame(players[CurrentPlayer]);
                    
                    if (players[CurrentPlayer].Position == 4)
                        IncomeTax(players[CurrentPlayer]);
                    
                    if(players[CurrentPlayer].Position==38)
                        LaxuryTax(players[CurrentPlayer]);

                    if (players[CurrentPlayer].Position==7|| players[CurrentPlayer].Position ==22 || players[CurrentPlayer].Position == 36)
                    {
                        Chance(players[CurrentPlayer], rnd.Next(0, 2));
                    }

                    NextKrug(players[CurrentPlayer],step);
                }
                if (players[CurrentPlayer].Money < 0)
                    LoseGame(players[CurrentPlayer]);

                RefreshStat();
                NextCurrentPlayer(players.Count);
            }
            else
            {
                LoseGame(players[CurrentPlayer]);
            }
        }
        private bool CheckProper(Player player)
        {
            for(int i=0;i<NotProper.Length;i++)
            {
                if (NotProper[i] == player.Position)
                    return false;
            }
            return true;
        }
        private void NextKrug(Player player,int step)
        {
            if (player.Position + step > 39)
                player.GetSalary();
        }
        private void Chance(Player player,int choice)
        {
            switch (choice)
            {
                case 0:
                    {
                        chance.UpMoney(player);
                        MessageBox.Show("Выпал шанс: вы получили 100 фишек");
                        break;
                    }
                case 1:
                    {
                        chance.DownMoney(player);
                        MessageBox.Show("Выпал шанс: вы потеряли 100 фишек");
                        break;
                    }
            }
        }
        
        private void LoseGame(Player player)
        {
            int count = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].canmove == false)
                    count++;
            }
            ImagePlayers[CurrentPlayer].Visibility = Visibility.Hidden;
            player.Lose();
            MessageBox.Show("Игрок " + CurrentPlayer.ToString() + " проиграл.");
            if (players.Count == 2)
            {
                NextCurrentPlayer(players.Count);
                MessageBox.Show("Игра окончкна выиграл игрок " + CurrentPlayer.ToString());
                this.Close();
            }
            
            if (players.Count-count==1)
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].canmove)
                    {
                        MessageBox.Show("Игра окончкна выиграл игрок " + i.ToString());
                        this.Close();
                    }       
                }
            RefreshStat();
        }
      
        private void BuyLand(Land Proper, Player player)
        {
            if (CheckProper(player))
            {
                
                    MessageBoxResult result = MessageBox.Show("Хочешь купить" + " " + Proper.name.ToString() + "?"+" "+"Стоимость="+Proper.price.ToString(), "Собственность", MessageBoxButton.YesNo);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            {

                                player.Buy(Proper);
                                Button but = new Button
                                {
                                    Content = Proper.name
                                };
                                but.Click += new RoutedEventHandler(ChoseProper);
                                switch (CurrentPlayer)
                                {
                                    case 0:
                                        ProperPlayer1.Items.Add(but);
                                        break;
                                    case 1:
                                        ProperPlayer2.Items.Add(but);
                                        break;
                                    case 2:
                                        ProperPlayer3.Items.Add(but);
                                        break;
                                    case 3:
                                        ProperPlayer4.Items.Add(but);
                                        break;
                                }
                            }
                            break;
                        case MessageBoxResult.No:
                            break;
                    }
                
            }
            RefreshStat();
        }
        public void ChoseProper(object sender, EventArgs e)
        {
            var current = sender as Button;
            MessageBoxResult result = MessageBox.Show("Хочешь продать?" + current.Content.ToString(), "Собственность", MessageBoxButton.YesNo);
            
            switch (result)
            {

                case MessageBoxResult.Yes:
                    {
                        
                        for (int j = 1; j < lands.Length; j++)
                         {
                             if (lands[j] == null)
                                 continue;
                             else
                             {
                               if (lands[j].name == current.Content.ToString() && lands[j].owner == players[CurrentPlayer])
                               {
                                 temp = lands[j];
                               }
                             }
                         }
                        if (temp!=null&&players[CurrentPlayer] == temp.owner)
                        {
                            players[CurrentPlayer].SellProper(temp);
                            ProperList[CurrentPlayer].Items.Remove(current);
                        }
                        else
                        {
                            MessageBox.Show("Ай-ай, ты не можешь продать чужое имущество");
                        }
                    }
                    break;
                case MessageBoxResult.No:
                    break;
            }
            RefreshStat();
        }

        private void PayRent(Land Proper, Player player)
        {
            if (CheckProper(player))
            {
                if (Proper.owner != player)
                {
                    player.Pay(Proper);
                }
            }
            RefreshStat();
        }
        private void IncomeTax(Player player)
        {
            player.Money -= 200;
            MessageBox.Show("Налог, заплатите 200 фишек");
        }
        private void LaxuryTax(Player player)
        {
            player.Money -= 100;
            MessageBox.Show("Налог на роскошь, заплатите 100 фишек");
        }
        private void NextCurrentPlayer(int CountPlayers)
        {
            CurrentPlayer++;
            NumberPlayer.Content = (CurrentPlayer+1).ToString();
            if (CurrentPlayer > CountPlayers - 1)
            {
                CurrentPlayer = 0;
                NumberPlayer.Content = (CurrentPlayer+1).ToString();
            }
            RefreshStat();
        }
        private void RefreshStat()
        {
            for (int i = 0; i < players.Count; i++)
            {
                Moneys[i].Text = players[i].Money.ToString();
                pos[i].Text = players[i].Position.ToString();
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NextCurrentPlayer(players.Count);
            NumberPlayer.Content = (CurrentPlayer+1).ToString();
            RefreshStat();
        }
    }
}
