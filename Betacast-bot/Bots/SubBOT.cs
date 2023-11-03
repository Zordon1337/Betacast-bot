using Betacast_bot.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Support;
using System.Threading;

namespace Betacast_bot.Bots
{
    public class SubBOT
    {
        public static void SubBot(string user, int num)
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

                // subbing or idk how to name it lol
                driver.Navigate().GoToUrl(Utils.Utils.URL + $"/subscription_center?add_user={user}");



                // We are using FindElements because there may be more than one button with this class
                var Buttons = driver.FindElements(By.CssSelector("a.yt-button"));
                // Looping through each button found with that tag
                foreach (var button in Buttons)
                {
                    // Checking if the button has text equal to Subscribe, if yes, then click
                    if (button.Text == "Subscribe")
                    {
                        button.Click();
                    }
                }
                driver.Navigate().GoToUrl(Utils.Utils.URL + "/logout.php");
            }
            driver.Close();
            Betacast_bot.Utils.Menu men = new Betacast_bot.Utils.Menu();
        }

    }
}