using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;
using System.Runtime.Intrinsics.Arm;

namespace CosmeticsManagerTGBot
{
    internal partial class BotEngine
    {
        public static async void HandleUserMessage(ITelegramBotClient botClient, Telegram.Bot.Types.Message message)
        {
            await SendReply(botClient, message, "You said: " + message.Text.ToString());
        }

        public static async Task SendReply(ITelegramBotClient botClient, Telegram.Bot.Types.Message message, string content)
        {
            await botClient.SendTextMessageAsync(message.Chat.Id, content, replyMarkup: new ReplyKeyboardRemove());
        }

    }
}
