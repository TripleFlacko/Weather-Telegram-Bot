using Newtonsoft.Json;
using System;
using System.Text.Json.Nodes;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Weather_Telegram_Bot.Bot;
using Telegram.Bot.Exceptions;

namespace Weather_Discord_Bot
{
    class Program
    {
        public static Task Main(string[] args) => new Program().MainAsync();
        async Task MainAsync()
        {
            var bot = new BotEngine();
            bot.Connect();
        }
    }
}