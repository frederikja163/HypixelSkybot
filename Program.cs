using System;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace HypixelSkybot
{
    public static class Program
    {
        private static DiscordSocketClient _bot;

        private static void Main(string[] args)
        {
            _bot = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Verbose,
                MessageCacheSize = 1000
            });
            
            _bot.LoginAsync(TokenType.Bot, "NzA4MzM0NjE5MDQ0NDc5MDM4.XrV5ew._I-6FO090D4LXKou-w7dmkZJiPw");
            _bot.StartAsync();

            _bot.MessageReceived += message =>
            {
                Console.WriteLine(message.Content);
                var channel = new SocketCommandContext(_bot, message as SocketUserMessage).Channel;
                return null;
            };
            Console.ReadKey();
            
            _bot.LogoutAsync();

        }
    }
}