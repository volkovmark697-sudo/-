using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace NotifierApp
{
    public interface INotifier
    {
        void Send(string message);
    }

    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Email] Отправка сообщения: {message}");
        }
    }

    public class SmsNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"[SMS] Отправка сообщения: {message}");
        }
    }

    public class TelegramNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Telegram] Отправка сообщения: {message}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<INotifier> notifiers = new List<INotifier>()
            {
                new EmailNotifier(),
                new SmsNotifier(),
                new TelegramNotifier()
            };

            string textMessage = "Привет! Это важное уведомление.";

            foreach (var notifier in notifiers)
            {
                notifier.Send(textMessage);
            }
        }
    }
}