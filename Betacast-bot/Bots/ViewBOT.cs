using Betacast_bot.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Betacast_bot.Bots
{
    public class ViewBOT
    {
        public static void Bot(string videoid, int num)
        {
            EdgeOptions options = new EdgeOptions();
            EdgeDriver driver = new EdgeDriver();

            for (int i = 0; i < num; i++) // Change 'num <= i' to 'i < num'
            {
                // registering account
                string username = Randomize.GenerateUserName();
                driver.Navigate().GoToUrl(Utils.Utils.URL + "/signup.php");
                driver.FindElement(By.Name("username")).SendKeys(username);
                driver.FindElement(By.Name("password")).SendKeys("JustAnNormalPassword");
                driver.FindElement(By.Name("confirm_password")).SendKeys("JustAnNormalPassword");
                driver.FindElement(By.ClassName("btn-primary")).Click();

                // logging in
                driver.FindElement(By.Name("username")).SendKeys(username);
                driver.FindElement(By.Name("password")).SendKeys("JustAnNormalPassword");
                driver.FindElement(By.ClassName("btn-primary")).Click();
                // ^ ofc its pasted from SubBOT because there were not point to literally make it from scratch while i made it already

                // navigating to the video
                driver.Navigate().GoToUrl(Utils.Utils.URL + $"/watch?v={videoid}");
                
                

                // Switch to the iframe context
                driver.SwitchTo().Frame(0);

                // clicking the play button because in betacast video doesn't start playing automaticaly
                // and to gain a view video needs to be "played"
                driver.FindElement(By.Id("playpause")).Click();

                // Switch back to the default content
                driver.SwitchTo().DefaultContent();

                // logging out
                driver.Navigate().GoToUrl(Utils.Utils.URL + "/logout.php");
            }
            driver.Close();
            Betacast_bot.Utils.Menu men = new Betacast_bot.Utils.Menu();
        }
    }
}
