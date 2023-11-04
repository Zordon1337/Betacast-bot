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
                    ViewBotUI();
                    break;
                case '2':
                    SubBotUI();
                    break;
                case '3':
                    VideoCommentBotUI();
                    break;
                case '4':
                    ProfileCommentBotUI();
                    break;
                default:
                    Console.WriteLine("Unknown Command");// if not 1,2 or 3 then we will show this to console
                    Menu men = new Menu();
                    break;
            }
        }
        public static void SubBotUI()
        {
            Console.Clear();
            Console.WriteLine("Type username of account that you want bot");
            string user = Console.ReadLine();
            Console.WriteLine("How much subs you want to add");
            string amount = Console.ReadLine();
            int inint = int.Parse(amount);
            Bots.SubBOT.SubBot(user, inint);
        }
        public static void ViewBotUI()
        {
            Console.Clear();
            Console.WriteLine("Type Video ID that you want bot");
            string id = Console.ReadLine();
            Console.WriteLine("How much Views you want to add");
            string amount = Console.ReadLine();
            int inint = int.Parse(amount);
            Bots.ViewBOT.Bot(id, inint);
        }
        public static void ProfileCommentBotUI()
        {
            Console.Clear();
            Console.WriteLine("Type username of user that you want bot");
            string user = Console.ReadLine();
            Console.WriteLine("What comments do you to spam");
            string msg = Console.ReadLine();
            Console.WriteLine("How much comments do you want to add");
            string amountofcmts = Console.ReadLine();
            int intoint = int.Parse(amountofcmts);
            ProfileCommentBot.Bot(user, msg, intoint);
        }
        public static void VideoCommentBotUI()
        {
            Console.Clear();
            Console.WriteLine("I need to find exploit for pressing button that is not 'interactible' even tho user can click it anyways");
            /*Console.WriteLine("Type ID of Video that you want bot");
            string id = Console.ReadLine();
            Console.WriteLine("What Comments do you to spam");
            string msg = Console.ReadLine();
            Console.WriteLine("How much comments do you want to add");
            string amountofcmts = Console.ReadLine();
            int intoint = int.Parse(amountofcmts);
            VideoCommentBot.Bot(id, msg, intoint);*/
        }
    }
}
