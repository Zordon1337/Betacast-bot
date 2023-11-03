using System;
using System.Collections.Generic;
using System.Text;

namespace Betacast_bot.Utils
{
    // Class mainly created for random related things like generating user
    public class Randomize
    {
        public static string GenerateUserName()
        {
            string[] firstNames = new string[]
            {
                "Emma", "Liam", "Olivia", "Noah", "Ava", "Isabella", "Sophia", "Mia", "Charlotte", "Amelia",
                "Harper", "Evelyn", "Abigail", "Emily", "Elizabeth", "Sofia", "Avery", "Ella", "Scarlett", "Grace",
                "Chloe", "Victoria", "Aubrey", "Zoey", "Penelope", "Lillian", "Addison", "Lily", "Natalie", "Riley",
                "Leilani", "Hazel", "Zoie", "Isabel", "Sophia", "Genesis", "Isabelle", "Nina", "Aurora", "Luna",
                "Savannah", "Ellie", "Audrey", "Kennedy", "Paisley", "Peyton", "Emery", "Eliza", "Hannah", "Violet",
                "Annabelle", "Kinsley", "Valeria", "Aurora", "Scarlett", "Ruby", "Autumn", "Piper", "Serenity", "Aurora",
                "Luna", "Maryam", "Anna", "Bella", "Evelyn", "Alice", "Sadie", "Penelope", "Hailey", "Grace", "Layla",
                "Nova", "Leah", "Eleanor", "Lila", "Eleanor", "Violet", "Alexa", "Adeline", "Lucy", "Hazel", "Stella",
                "Aurora", "Maria", "Diana", "Zoey", "Ellie", "Clara", "Willow", "Gabriella", "Savannah", "Aurora", "Zoe",
                "Mia", "Aria", "Hannah", "Abigail", "Lucy", "Violet", "Hazel"
            }; // thank you chatGPT
            string name = firstNames[GenerateNum(0, 99)];
            return name + GenerateRandomNum;

        }
        public static int GenerateRandomNum => new Random().Next(10000, 1000000);
        public static int GenerateNum(int num1,int num2)
        {
            return new Random().Next(num1, num2);
        }
        
    }
}
