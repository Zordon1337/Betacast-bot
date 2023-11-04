using Betacast_bot.Bots;
using System;
using System.Collections.Generic;
using System.Text;

namespace Betacast_bot.Utils
{
    public class Menu
    {
        // gets called after initalizing as Menu xxx = new Menu()
        public Menu()
        {
            Console.Clear();
            Console.WriteLine("BetaCast BOT made by Zordon1337");
            Console.WriteLine("Select Option");
            Console.WriteLine("1) View BOT");
            Console.WriteLine("2) Sub BOT");
            Console.WriteLine("3) Video Comment Bot");
            Console.WriteLine("4) Profile Comment Bot");
            switch(Console.ReadKey().KeyChar)
            {
                case '1':
                    ViewBot();
                    break;
                case '2':
                    SubBot();
                    break;
                case '3':
                    Console.WriteLine("Soon");
                    break;
                case '4':
                    ProfileCommentBot2();
                    break;
                default:
                    Console.WriteLine("Unknown Command");// if not 1,2 or 3 then we will show this to console
                    break;
            }
        }
        public static void SubBot()
        {
            Console.Clear();
            Console.WriteLine("Type username of account that you want bot");
            string user = Console.ReadLine();
            Console.WriteLine("How much subs you want to add");
            string amount = Console.ReadLine();
            int inint = int.Parse(amount);
            Bots.SubBOT.SubBot(user, inint);
        }
        public static void ViewBot()
        {
            Console.Clear();
            Console.WriteLine("Type Video ID that you want bot");
            string id = Console.ReadLine();
            Console.WriteLine("How much Views you want to add");
            string amount = Console.ReadLine();
            int inint = int.Parse(amount);
            Bots.ViewBOT.Bot(id, inint);
        }
        public static void ProfileCommentBot2()
        {
            Console.Clear();
            Console.WriteLine("Type username of user that you want bot");
            string user = Console.ReadLine();
            Console.WriteLine("What Message do you to spam");
            string msg = Console.ReadLine();
            Console.WriteLine("How much comments do you want to add");
            string amountofcmts = Console.ReadLine();
            int intoint = int.Parse(amountofcmts);
            ProfileCommentBot.Bot(user, msg, intoint);
        }
    }
}
