using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Polling;

internal class Program
{
    static ITelegramBotClient bot = new TelegramBotClient("6250620357:AAEBPqfxFbrOXKuvBc7tahEN-__aTLLvCwE");

    public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));

        String message = update.Message.Text;
        long chatId = update.Message.Chat.Id;
        Boolean isfind = false;

        if (message.Equals("/start"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] {"Информатика"},
                new KeyboardButton[] {"Математика"},
                new KeyboardButton[] {"Физика"}
            });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Доброго выбора суток! Хочешь выбрать тему для курсовой? Тогда для начала определись с предметом, по которому будешь писать курсовую!", replyMarkup: start);
        }

        if (message.Equals("Информатика"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] {"Сеть Интернет и ее использование в образовании"},
                new KeyboardButton[] {"Формы и методы проверки знаний учащихся при обучении информатики"},
                new KeyboardButton[] {"Сравнительный анализ образовательных Интернет-ресурсов"},
                new KeyboardButton[] {"Главное меню"}
            });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
        }

        if (message.Equals("Математика"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] {"Приближённые вычисление(округление, нахождение погрешностей)"},
                new KeyboardButton[] {"Функция.Область определения функции"},
                new KeyboardButton[] {"Нахождение пределов функции"},
                new KeyboardButton[] {"Действия над векторами"},
                new KeyboardButton[] {"Главное меню"}
            });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
        }

        if (message.Equals("Физика"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] {"Физика и музыка"},
                new KeyboardButton[] {"Физика и живопись"},
                new KeyboardButton[] {"Физические методы в современной археологии"},
                new KeyboardButton[] {"Главное меню"}
            });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
        }

        if (message.Equals("Главное меню"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] {"Информатика"},
                new KeyboardButton[] {"Математика"},
                new KeyboardButton[] {"Физика"}
            });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Возврат на главное меню", replyMarkup: start);
        }
        if (message.Equals("Сеть Интернет и ее использование в образовании"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\7y6hmOYtC5w.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "7y6hmOYtC5w.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Сеть Интернет и ее использование в образовании\n\nПрименение интернета в образовании позволяет: " +
               "частично или полностью автоматизировать порцесс обучения, " +
               "повысить качественный уровень знаний учеников, " +
               "получить образование дистанционно");
        }

        if (message.Equals("Формы и методы проверки знаний учащихся при обучении информатики"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\qKNmtQy8wFQ.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "qKNmtQy8wFQ.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Формы и методы проверки знаний учащихся при обучении информатики\n\nМетоды контроля:" +
               "Устные(опрос,устная кр и др.) " +
               "Письменные (математический диктант, кр, тематический реферат и тд.) " +
               "Практические(опыт, практическая работа, лабораторка, экспериментальное задание и др.) " +
               "Зачеты" +
               "Экзамены");
        }

        if (message.Equals("Сравнительный анализ образовательных Интернет-ресурсов"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\ZlsD8ZVkLyc.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "ZlsD8ZVkLyc.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Сравнительный анализ образовательных Интернет-ресурсов\n\nВ каталоге образовательных ресурсов сети Интернет представлены результаты анализа образовательных ресурсов, размещенных в сети Интернет и представляющих интерес для школьного образования. ");
        }
        if (message.Equals("Приближённые вычисление(округление, нахождение погрешностей)"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\Bg-JPd4U2PM.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Bg-JPd4U2PM.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Приближённые вычисление(округление, нахождение погрешностей)\n\nНекоторые величины известны с очень большой точностью, число достоверных значащих цифр может быть равно шести и даже больше.");
        }

        if (message.Equals("Функция.Область определения функции"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\Saved Pictures\\Функция.Область определения функции.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Функция.Область определения функции.jpg");
            await botClient.SendPhotoAsync(
                chatId: chatId,
                photo: photo,
                caption: "Функция.Область определения функции\n\nОбласть определения функции - это все значения, которые может принимать независимая переменная."
               );
        }

        if (message.Equals("Нахождение пределов функции"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\WHBIIK852RA.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "WHBIIK852RA.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Нахождение пределов функции\n\nТеория пределов- это один из разделов математического анализа. Любой предел состоит из трех частей: 1) значка предела; 2) Записи под значком предела; 3) функции под знаком предела.");
        }

        if (message.Equals("Действия над векторами"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\VbyaA6uQEDM.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "VbyaA6uQEDM.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Действия над векторами\n\nКаждая координата произведения вектора на число равна произведению соответствующей координаты вектора на это число.");
        }

        if (message.Equals("Физика и музыка"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\ali54q7FBN4.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "ali54q7FBN4.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Физика и музыка\n\nФизика считается точной наукой, а музыка- это что-то более возвышенное, создающее настроение.Многим людям невдомёк, что между физикой и музыкой очень много точек соприкосновения. ");
        }
        if (message.Equals("Физика и живопись"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\s9TuCEhLni0.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "s9TuCEhLni0.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Физика и живопись\n\n" +
            "Произведения литературы, искусства помогают во многих случаях раскрыть все связи физических явлений, делая восприятие тоньше и шире, позволяют глубже понять их, они учат нас быть внимательными, учат наблюдать, замечать и видеть проявление физики в окружающем мире.");
        }

        if (message.Equals("Физические методы в современной археологии"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\Виталий\\Pictures\\lOiu2WeaZY4.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "lOiu2WeaZY4.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Физические методы в современной археологии\n\n" +
            "Методы собственно археологических работ делятся традиционно на два вида: полевые, в ходе которых, по особой методике, добываются исходные для анализа данные, и камеральные методы, при реализации которых полученные в поле материалы классифицируются, разделяются на типы, описываются и анализируются.");
        }

        if (!isfind)
        {
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Мне не понятно ваше сообщение");
        }
    }

    public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

        var cts = new CancellationTokenSource();
        var cancellationToken = cts.Token;
        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = { },
        };
        bot.StartReceiving(
            HandleUpdateAsync,
            HandleErrorAsync,
            receiverOptions,
            cancellationToken
        );
        Console.ReadLine();
    }
}