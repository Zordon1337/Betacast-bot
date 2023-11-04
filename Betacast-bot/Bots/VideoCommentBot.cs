using Betacast_bot.Utils;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Betacast_bot.Bots
{
    public class VideoCommentBot
    {
        public static void Bot(string videoid, string msg, int amount)
        {
            FirefoxOptions options = new FirefoxOptions();
            FirefoxDriver driver = new FirefoxDriver();


            for (int i = 0; i < amount; i++)
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

                // navigating to video
                driver.Navigate().GoToUrl(Utils.Utils.URL + $"/watch?v={videoid}");

                // Finding the TextArea
                var textarea = driver.FindElement(By.Name("msg"));
                // Finding submit button
                var submitbtn = driver.FindElement(By.Name("post_comment"));

                // writing the message to the textarea
                textarea.SendKeys(msg);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", submitbtn);
                submitbtn.Click();


                // logging out
                driver.Navigate().GoToUrl(Utils.Utils.URL + "/logout.php");
            }
            driver.Close();
            Betacast_bot.Utils.Menu men = new Betacast_bot.Utils.Menu();
        }
    }
}
