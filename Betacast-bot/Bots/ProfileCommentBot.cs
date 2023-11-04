using Betacast_bot.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Support;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace Betacast_bot.Bots
{
    public class ProfileCommentBot
    {
        public static void Bot(string user, string msg, int num)
        {
            FirefoxOptions options = new FirefoxOptions();
            FirefoxDriver driver = new FirefoxDriver();

            for (int i = 0; i < num; i++) 
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

                // go to profile
                driver.Navigate().GoToUrl(Utils.Utils.URL + $"/profile_add_comment?user={user}");

                // Finding the TextArea
                var textarea = driver.FindElement(By.Name("msg"));
                // Finding submit button
                var submitbtn = driver.FindElement(By.Name("post_comment"));

                // writing the message to the textarea
                textarea.SendKeys(msg);

                // submiting the comment
                submitbtn.Click();
                // logging out
                driver.Navigate().GoToUrl(Utils.Utils.URL + "/logout.php");
            }
            driver.Close();
            Betacast_bot.Utils.Menu men = new Betacast_bot.Utils.Menu();
        }
    }
}
