Console.WriteLine("文字列を入力してください。");
string? arg = Console.ReadLine();
if (string.IsNullOrEmpty(arg))
{
    string message = "空の文字列は入力できません。";
    throw new ArgumentException(message);
}

Console.WriteLine("入力値:" + arg);
