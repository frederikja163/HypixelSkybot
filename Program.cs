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
            using (new DiscordBot())
            {
                HypixelSkybot.StartTimer();
                Console.ReadKey();
            }
        }
    }
}