using System;
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
            using (var bot = new DiscordBot())
            {
                var profile = Hypixel.SkyblockProfile();
                var timer = new Timer(30000);
                timer.AutoReset = true;
                timer.Elapsed += (sender, eventArgs) => { };
                timer.Start();
                Console.ReadKey();
            }
        }
    }
}