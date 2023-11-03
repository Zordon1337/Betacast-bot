using System;
using System.Collections.Generic;
using System.Text;

namespace Betacast_bot.Utils
{
    public class Utils
    {
        public static string URL => System.IO.File.ReadAllText("./url.txt");
    }
}
