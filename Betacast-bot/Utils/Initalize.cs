using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Betacast_bot.Utils
{
    public class Initalize
    {
        public Initalize()
        {
            InitalizeConfig();
        }
        public void InitalizeConfig()
        {
            if(!System.IO.File.Exists("./url.txt"))
            {
                System.IO.File.Create("./url.txt");
                Console.WriteLine("Configuration file created, enter betacast instance url in url.txt and restart app");
                Thread.Sleep(5000000);
            } else
            {
                if (!System.IO.File.ReadAllText("./url.txt").Contains("http") && !System.IO.File.ReadAllText("./url.txt").Contains("https"))
                {
                    Console.WriteLine("Configuration file seems invalid, please review url.txt");
                    Thread.Sleep(5000000);
                }
            }
        }
    }
}
