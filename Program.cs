using System.Windows.Markup;
using Telegram.Bot;
using Telegram.Bot.Polling;

namespace CosmeticsManagerTGBot
{
    internal class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("6010354846:AAFxBij-TWE9Dd2Pz0DtHWcsCeW_DEnepSE");
        
        static void Main(string[] args)
        {
            Console.WriteLine("Info: " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(BotEngine.HandleUpdateAsync, BotEngine.HandleErrorAsync, receiverOptions, cancellationToken);

            Console.ReadLine();
        }
    }
}











