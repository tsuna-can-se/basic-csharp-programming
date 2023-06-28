using PolymorphismSample;

Console.WriteLine("===具象クラスを利用する例===");
Animal animal = new Cat();
animal.Walk();

Console.WriteLine("===抽象クラスを利用する例===");
string loggerType = "FlatText";

DoSomething(loggerType);

static void DoSomething(string loggerType)
{
    ConsoleLoggerBase consoleLogger = CreateConsoleLogger(loggerType);
    consoleLogger.WriteLog("ログテキスト");
}

static ConsoleLoggerBase CreateConsoleLogger(string loggerType)
{
    switch (loggerType)
    {
        case "FlatText":
            return new FlatTextConsoleLogger();
        case "Json":
            return new JsonConsoleLogger();
        default:
            throw new NotSupportedException();
    }
}

