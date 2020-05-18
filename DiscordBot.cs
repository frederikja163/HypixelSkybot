using System;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace HypixelSkybot
{
    public class DiscordBot : IDisposable
    {
        private DiscordSocketClient _bot;
        private static ISocketMessageChannel _channel;
        
        public DiscordBot()
        {
            _bot = new DiscordSocketClient();
            
            _bot.LoginAsync(TokenType.Bot, "NzA4MzM0NjE5MDQ0NDc5MDM4.XrV5ew._I-6FO090D4LXKou-w7dmkZJiPw");
            _bot.StartAsync();

            _bot.MessageReceived += message =>
            {
                if (message.Content == "start")
                {
                    _channel = new SocketCommandContext(_bot, message as SocketUserMessage).Channel;
                    SendMessage("Bot initiated for this channel.");
                }
                else if (message.Content == "stop")
                {
                    Dispose();
                    Environment.Exit(1);
                }
                return null;
            };
        }

        public static void SendMessage(string message)
        {
            _channel?.SendMessageAsync(message);
        }
        
        public void Dispose()
        {
            _bot.LogoutAsync();
        }
    }
}