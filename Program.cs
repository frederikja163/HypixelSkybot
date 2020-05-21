using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace HypixelSkybot
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            string discordToken = "";
            string hypixelKey = "";
            if (args.Length > 2)
            {
                discordToken = args[0];
                hypixelKey = args[1];
            }
            else if (File.Exists("keys.txt"))
            {
                args = File.ReadAllLines("keys.txt");
                discordToken = args[0];
                hypixelKey = args[1];
            }

            if (string.IsNullOrWhiteSpace(discordToken))
            {
                Console.Write("Write the discord token here: ");
                discordToken = Console.ReadLine();
                Console.Write("Write the hypixel api key here: ");
                hypixelKey = Console.ReadLine();
            }
            
            using (new DiscordBot(discordToken))
            {
                Hypixel.ApiKey = hypixelKey;
                Console.ReadKey();
            }
        }
    }
}